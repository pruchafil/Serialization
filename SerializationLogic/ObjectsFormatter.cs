using Serialization.JsonModels.NASA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public static class ObjectsFormatter
    {
        public static String ToFormattedString(this Objects obj)
        {
            var str = obj.ToString();
            int space = 0;

            StringBuilder sb = new StringBuilder();

            foreach (var item in str)
            {
                if (item is '(')
                {
                    sb.Append(Environment.NewLine);

                    for (int i = 0; i < space; i++)
                    {
                        sb.Append(' ');
                    }

                    sb.Append(item);
                    sb.Append(Environment.NewLine);

                    space += 4;

                    for (int i = 0; i < space; i++)
                    {
                        sb.Append(' ');
                    }
                }
                else if (item is ')')
                {
                    sb.Append(Environment.NewLine);

                    space -= 4;

                    for (int i = 0; i < space; i++)
                    {
                        sb.Append(' ');
                    }

                    sb.Append(item);
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}