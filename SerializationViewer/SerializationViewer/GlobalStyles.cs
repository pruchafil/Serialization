using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SerializationViewer
{
    internal static class GlobalStyles
    {
        private static Dictionary<Type, Action<View>> _dict = new Dictionary<Type, Action<View>>()
        {
            {
                typeof (StackLayout),
                (x) => {
                    if (Serialization.SaveSystem.ConfigLoader.Self.Data.DarkMode)
                        x.BackgroundColor = Color.Black;
                }
            },
            {
                typeof (ScrollView),
                (x) => {
                    if (Serialization.SaveSystem.ConfigLoader.Self.Data.DarkMode)
                        x.BackgroundColor = Color.Black;
                }
            },
            {
                typeof (Label),
                (x) => {
                    if (Serialization.SaveSystem.ConfigLoader.Self.Data.DarkMode)
                        ((Label)x).TextColor = Color.White;
                    else
                        ((Label)x).TextColor = Color.Black;
                }
            },
            {
                typeof (Entry),
                (x) => {
                    if (Serialization.SaveSystem.ConfigLoader.Self.Data.DarkMode)
                    {
                        x.BackgroundColor = Color.White;
                        ((Entry)x).TextColor = Color.Black;
                    }
                }
            },
        };

        public static void ChangeStyle(ContentPage contentPage)
        {
            var v = (contentPage.Content as StackLayout);
            _dict[ typeof (StackLayout) ](v);

            RecursiveCall(v);
        }

        private static void RecursiveCall(Layout layout)
        {
            foreach (var item in layout.Children)
            {
                Type type = item.GetType();

                if (type == typeof (StackLayout))
                {
                    _dict[type]((StackLayout)item);
                    RecursiveCall((StackLayout)item);
                }
                else if (type == typeof(ScrollView))
                {
                    _dict[type]((ScrollView)item);
                    RecursiveCall((ScrollView)item);
                }
                else if (_dict.ContainsKey(type))
                {
                    _dict[type]((View)item);
                }
            }
        }

    }
}