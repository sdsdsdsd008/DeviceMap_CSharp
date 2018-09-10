using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SdcSoft.Devices
{
    /// <summary>
    /// 常量、字段、属性定义
    /// </summary>
    [Serializable]
    public abstract partial class SdcSoftDevice
    {
        #region--------------------Map点位常量--------------------
        public const string KEY_POINT_SYSTEM_STATUS = "o_system_status";
        public const string KEY_POINT_POWER = "o_power";
        public const string KEY_POINT_MEDIA = "o_media";
        public const string KEY_POINT_RUN_LIFE = "ba_yunxingshijian";
        public const string KEY_POINT_RUN_DAYS = "ba_yunxingtianshu";
        public const string KEY_POINT_RUN_HOURS = "ba_yunxingxiaoshishu";
        #endregion

        #region--------------------字典Key常量--------------------
        public const string KEY_BASE = "BaseInfo";
        public const string KEY_EXCEPTION = "exceptionInfo";
        public const string KEY_MOCK = "mockInfo";
        public const string KEY_SETTING = "settingInfo";
        public const string KEY_START_STOP = "startStopInfo";
        public const string KEY_DEVICE = "deviceInfo";
        public const string KEY_OPENCLOSE = "openclose";
        /// <summary>
        /// 计算属性的KEY
        /// </summary>
        internal const string KEY_Count_Fields = "countfields";
        #endregion

        #region--------------------锅炉动画常量--------------------
        public const int Style_Horizontal = 0;
        public const int Style_Vertical = 1;
        #endregion

        public SdcSoftDevice()
        {
            fieldMap.Add(KEY_BASE, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_EXCEPTION, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_MOCK, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_SETTING, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_DEVICE, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_START_STOP, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_OPENCLOSE, new List<DeviceFieldForUI>());
            fieldMap.Add(KEY_Count_Fields, new List<DeviceFieldForUI>());
        }

        #region--------------------基本字段及属性--------------------
        protected Dictionary<string, List<DeviceFieldForUI>> fieldMap = new Dictionary<string, List<DeviceFieldForUI>>();
        private string deviceNo;
        private string nickName;
        private string deviceType;

        /// <summary>
        /// 设备子节长度
        /// </summary>
        protected int BYTE_ARRAY_LENGTH;

        public int getDeviceBytesLength()
        {
            return BYTE_ARRAY_LENGTH;
        }
        public string getDeviceNo()
        {
            return deviceNo;
        }
        public void setDeviceNo(string deviceNo)
        {
            this.deviceNo = deviceNo;
        }
        public string getNickName()
        {
            return nickName;
        }
        public void setNickName(string nickName)
        {
            this.nickName = nickName;
        }
        public string getDeviceType()
        {
            return deviceType;
        }
        public void setDeviceType(string deviceType)
        {
            this.deviceType = deviceType;
        }
        #endregion
    }

    /// <summary>
    /// 获取点位集合的方法
    /// </summary>
    public abstract partial class SdcSoftDevice
    {
        #region---------------------获取点位集合---------------------
        private Dictionary<string, DeviceFieldForUI> getFieldsMap(string fieldsGroupKey)
        {
            Dictionary<string, DeviceFieldForUI> map = new Dictionary<string, DeviceFieldForUI>();
            var list = fieldMap[fieldsGroupKey];
            foreach (DeviceFieldForUI deviceFieldForUI in list)
            {
                map.Add(deviceFieldForUI.getName(), deviceFieldForUI);
            }
            return map;
        }
        public List<DeviceFieldForUI> getFieldsByGroupKey(string key)
        {
            if (fieldMap.ContainsKey(key))
            {
                return fieldMap[key];
            }
            return null;
        }
        public Dictionary<string, DeviceFieldForUI> getBaseInfoFields()
        {
            return getFieldsMap((KEY_BASE));
        }
        public Dictionary<string, DeviceFieldForUI> getDeviceFields()
        {
            return getFieldsMap((KEY_DEVICE));
        }
        public Dictionary<string, DeviceFieldForUI> getExceptionFields()
        {
            return getFieldsMap((KEY_EXCEPTION));
        }
        public Dictionary<string, DeviceFieldForUI> getMockFields()
        {
            return getFieldsMap((KEY_MOCK));
        }
        public Dictionary<string, DeviceFieldForUI> getSettingFields()
        {
            return getFieldsMap((KEY_SETTING));
        }
        public Dictionary<string, DeviceFieldForUI> getStartStopFields()
        {
            return getFieldsMap((KEY_START_STOP));
        }
        public Dictionary<string, DeviceFieldForUI> getOpenCloseFields()
        {
            return getFieldsMap(KEY_OPENCLOSE);
        }
        internal Dictionary<string, DeviceFieldForUI> getCountFields()
        {
            return getFieldsMap(KEY_Count_Fields);
        }
        #endregion
        protected DeviceFieldForUI GetUiItem(Dictionary<string, DeviceFieldForUI> map, string key)
        {
            if (map.ContainsKey(key))
            {
                return map[key];
            }
            return null;
        }
    }

    /// <summary>
    /// 待实现的抽象方法
    /// </summary>
    public abstract partial class SdcSoftDevice
    {
        internal abstract void handleByteField(ByteField field, byte[] byteps);

        internal abstract string handleDeviceNo(byte[] bytes);

        public abstract List<DeviceFieldForUI> getDeviceFocusFields();

        internal abstract DeviceFieldForUI getPowerInfo();

        public abstract List<Element> getBeng();
        /// <summary>
        /// 获取风扇元素集合
        /// </summary>
        /// <returns></returns>
        public abstract List<Element> getFan();
        public abstract int getMode();
    }
    /// <summary>
    /// 基本信息及类型定义
    /// </summary>
    public abstract partial class SdcSoftDevice
    {
        protected void AddField(DeviceFieldForUI field)
        {
            if (fieldMap.ContainsKey(field.getKey()))
                fieldMap[field.getKey()].Add(field);
        }
        public int getExceptionCount()
        {
            return fieldMap[KEY_EXCEPTION].Count;
        }

        /// <summary>
        /// 获取设备系统状态
        /// </summary>
        /// <returns></returns>
        public DeviceFieldForUI getDeviceStatus()
        {
            return getBaseInfoFields()[KEY_POINT_SYSTEM_STATUS];
        }

        /// <summary>
        /// 获取设备燃料
        /// </summary>
        /// <returns></returns>
        public DeviceFieldForUI getPower()
        {
            return getBaseInfoFields()[KEY_POINT_POWER];
        }

        /// <summary>
        /// 获取设备介质
        /// </summary>
        /// <returns></returns>
        public DeviceFieldForUI getMedia()
        {
            return getBaseInfoFields()[KEY_POINT_MEDIA];
        }

        /// <summary>
        /// 获取炉子元素信息
        /// </summary>
        /// <returns></returns>
        public Element getStoveElement()
        {
            Element element = new Element
            {
                Prefix = Element.Prefix_Stove,
                Title = "锅炉"
            };
            element.SetValues(Element.Index_A_Power, getPower().getValue(), getMedia().getValue(), Style_Horizontal, (int)getPowerInfo().getValue());
            return element;
        }
        /// <summary>
        /// 获取泵元素集合
        /// </summary>
        /// <returns></returns>

        public bool validateFalse(int bytesLength)
        {
            return BYTE_ARRAY_LENGTH > bytesLength;
        }

        protected class MyArrayList<T> : List<T>
        {
            public new void Add(T e)
            {
                if (null == e)
                    return;
                base.Add(e);
            }
        }
        [Description("模式")]
        public class Media
        {
            [Description("热水")]
            public const int ReShui = 0;
            [Description("蒸汽")]
            public const int ZhengQi = 1;
            [Description("导热油")]
            public const int DaoReYou = 2;
            [Description("热风")]
            public const int ReFeng = 3;
            [Description("真空")]
            public const int ZhenKong = 4;
        }
        [Description("燃料")]
        public class Power
        {
            [Description("油气")]
            public const int YouQi = 0;
            [Description("电")]
            public const int Dian = 1;
            [Description("煤")]
            public const int Mei = 2;
            [Description("生物质")]
            public const int ShengWuZhi = 3;
        }
    }
}
