using Newtonsoft.Json;
using Serialization.JsonModels;
using System;
using System.IO;

namespace Serialization.SaveSystem
{
    public class ConfigLoader : ILoader<Config>
    {
        private static ConfigLoader _self;
        private Config              _data;
        private bool                _outDated;

        public static ConfigLoader Self
        {
            get
            {
                if (_self == null)
                    _self = new ConfigLoader();

                return _self;
            }
        }

        /// <summary>
        /// Get latest config by calling Load, but only if the config has changed since the last call
        /// </summary>
        public Config Data
        {
            get
            {
                if (_outDated || _data == null)
                    Data = Load();

                return _data;
            }
            private set
            {
                _data = value;
            }
        }

        public string Path
        {
            get
            {
                return $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\config.json";
            }
        }

        private ConfigLoader()
        {
            _outDated = default;
            _data     = default;
        }

        public void Update(Config config)
        {
            _outDated = true;

            string str = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(Path, str);
        }

        /// <summary>
        /// If file does not exist (first launch)
        /// </summary>
        private void ApplyDefaultSettings()
        {
            Config config = new Config()
            {
                AutoUpdate = true,
                DarkMode = true
            };

            Update(config);
        }

        private Config Load()
        {
            if (!File.Exists(Path))
                ApplyDefaultSettings();

            Config c = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path));

            return c;
        }
    }
}