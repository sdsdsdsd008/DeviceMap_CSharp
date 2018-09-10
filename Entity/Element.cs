using System;
using System.Collections.Generic;
using System.Text;

namespace SdcSoft.Devices.Entity
{
    public class Element
    {
        internal const string Prefix_Stove = "a";
        internal const string Prefix_Beng = "b";
        internal const string Prefix_Fan = "c";

        internal const int Index_A_Power = 0;
        internal const int Index_A_Media = 1;
        internal const int Index_A_Style = 2;
        internal const int Index_A_Status = 3;

        internal const int Index_Beng_Count = 0;
        internal const int Index_Beng_Status = 1;

        internal const int Index_Fan_Count = 0;
        internal const int Index_Fan_Status = 1;

        protected int[] values = { -1,-1,-1,-1,-1,-1,-1,-1,-1,-1};


        public string Title { get; internal set; }
        public string Prefix { get; internal set; }

        public List<int> Values
        {
            get
            {
                List<int> data = new List<int>(10);
                foreach (int i in values)
                {
                    if (i > -1)
                    {
                        data.Add(i);
                        continue;
                    }
                    break;
                }
                return data;
            }
        }

        internal void ClearValues()
        {
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = -1;
            }
        }

        internal void SetValues(int index,params int[] data)
        {
            Array.Copy(data,0, values,index, data.Length);
        }
        public string GetElementPrefixAndValuesString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Prefix);
            foreach(int i in values)
            {
               if(i > -1)
                {
                    sb.Append('-');
                    sb.Append(i);
                    continue;
                }
                break;
            }
            return sb.ToString();
        }
    }
}
