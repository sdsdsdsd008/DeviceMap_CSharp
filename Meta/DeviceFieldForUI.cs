using System;

namespace SdcSoft.Devices.Meta
{
    [Serializable]
    public class DeviceFieldForUI
    {
        private string name;
        private dynamic value;
        private string key;
        private string title;
        private string valuestring;

        public string getKey()
        {
            return key;
        }
        public void setKey(string key)
        {
            this.key = key;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public dynamic getValue()
        {
            return value;
        }
        public void setValue(dynamic value)
        {
            this.value = value;
        }
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getValueString()
        {
            return string.Format(valuestring,value);
        }
        public void setValueString(string valuestring)
        {
            this.valuestring = valuestring;
        }
    }
}
