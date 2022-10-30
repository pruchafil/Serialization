using Newtonsoft.Json;
using Serialization.JsonModels.NASA;
using System;
using System.IO;

namespace Serialization.SaveSystem
{
    public class DataLoader : ILoader<Objects>
    {
        private static DataLoader _self;
        private Objects           _data;
        private bool              _outDated;

        public static DataLoader Self
        {
            get
            {
                if (_self == null)
                    _self = new DataLoader();

                return _self;
            }
        }

        public Objects Data
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
                return $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\data.json";
            }
        }

        private DataLoader()
        {
            _outDated = default;
            _data     = default;
        }

        public void Update(Objects config)
        {
            _outDated = true;

            string str = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(Path, str);
        }

        public void Update(string jsonString)
        {
            _outDated = true;

            File.WriteAllText(Path, jsonString);
        }

        /// <summary>
        /// This should be exception safe, as the default setting in the configuration says that the file
        /// will be downloaded at least once when the application starts.
        /// </summary>
        /// <returns>Data</returns>
        private Objects Load()
        {
            Objects c = JsonConvert.DeserializeObject<Objects>(File.ReadAllText(Path));

            return c;
        }
    }
}