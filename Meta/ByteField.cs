using System.Collections.Generic;

namespace SdcSoft.Devices.Meta
{
    internal abstract class ByteField
    {
        protected string name;
        private string unit;
        private string title,showTitle;
        protected int startIndex;
        private int bytesLength, baseNumber;
        protected int bit;
        protected Dictionary<int, string> valueMap;

        /// <summary>
        /// 点位是否显示选项
        /// </summary>
        protected bool IsShow { get; set; } = true;
        
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }



        public string getShowTitle()
        {
            return showTitle;
        }
        public void setShowTitle(string title)
        {
            this.showTitle = title;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getUnit()
        {
            return null == unit ? "" : unit;
        }
        public void setUnit(string unit)
        {
            this.unit = unit;
        }
        public int getStartIndex()
        {
            return startIndex;
        }
        public void setStartIndex(int startIndex)
        {
            this.startIndex = startIndex;
        }
        public int getBytesLength()
        {
            return bytesLength;
        }
        public void setBytesLength(int bytesLength)
        {
            this.bytesLength = bytesLength;
        }
        public int getBaseNumber()
        {
            return baseNumber;
        }
        public void setBaseNumber(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
        public void setBit(int bit)
        {
            this.bit = bit;
        }
        public void setValueMap(Dictionary<int,string> valueMap)
        {
            this.valueMap = valueMap;
        }

        public abstract void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI);

        public abstract dynamic getValue();
        public virtual bool haveValue(params byte[] bytes)
        {
            if (bytesLength < 1)
                return true;
            return false;
        }
        public virtual string getValueString()
        {
            if (bytesLength > 0)
            {
                return string.Format("{0}{1}", getValue().ToString(), getUnit());
            }
            return string.Format("{{0}}{0}",  getUnit());
        }
        /// <summary>
        /// 获取点位对应的显示项目，如果IsShow为false则返回null
        /// </summary>
        /// <returns></returns>
        public DeviceFieldForUI getDeviceFieldForUI()
        {
            DeviceFieldForUI fieldForUI = new DeviceFieldForUI();
            if(bytesLength < 1)//如果是要计算的点位对象
            {
                if (IsShow)//如果要显示，则该点位对象为其类型所对应的key，该计算点位将包含在SdcsoftDevice对应的List集合中
                {
                    setDeviceFieldForUIKey(fieldForUI);
                }
                else //如果无需显示，则该点位对象的key设置为SdcSoftDevice.KEY_Count_Fields，该点位将包含在该key对应的SdcsoftDevice的List集合中
                {
                    fieldForUI.setKey(SdcSoftDevice.KEY_Count_Fields);
                }
            }
            else
            {
                setDeviceFieldForUIKey(fieldForUI);
            }
            fieldForUI.setName(getName());
            fieldForUI.setTitle(getTitle());
            fieldForUI.setValue(getValue());
            fieldForUI.setValueString(getValueString());
            return fieldForUI;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title)
        {
            field.setName(name);
            field.setStartIndex(startIndex);
            field.setBytesLength(bytesLength);
            field.setTitle(title);
            return field;
        }
        /// <summary>
        /// 添加计算点位，isShow确定点位是否用来显示，默认为true
        /// </summary>
        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title,bool isShow = true)
        {
            field.setName(name);
            field.setStartIndex(startIndex);
            field.setBytesLength(bytesLength);
            field.setTitle(title);
            field.IsShow = isShow;
            return field;
        }


        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, Dictionary<int, string> valueMap)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.setValueMap(valueMap);
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, Dictionary<int, string> valueMap, string showTitle)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.setValueMap(valueMap);
            field.setShowTitle(showTitle);
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, string unit)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.setUnit(unit);
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, int bit)
        {
            Init(field, name, startIndex, bytesLength, title);
            field.setBit(bit);
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, int bit, Dictionary<int, string> valueMap)
        {
            Init(field, name, startIndex, bytesLength, title, bit);
            field.setValueMap(valueMap);
            return field;
        }

        public static ByteField Init(ByteField field, string name, int startIndex, int bytesLength, string title, string unit, int baseNumber)
        {
            Init(field, name, startIndex, bytesLength, title, unit);
            field.setBaseNumber(baseNumber);
            return field;
        }
    }
}
