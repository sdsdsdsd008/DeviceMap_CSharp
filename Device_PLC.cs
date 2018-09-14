using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;
using System;
using System.Collections.Generic;

namespace SdcSoft.Devices
{
    /// <summary>
    /// PLC基本数据处理
    /// </summary>
    internal abstract partial class Device_PLC : SdcSoftDevice
    {
        internal override void handleByteField(ByteField field, byte[] bytes)
        {
            switch (field.getBytesLength())
            {
                case 0:
                    if (field.haveValue(bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
                case 2:
                    if (field.haveValue(bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
                case 4:
                    if (field.haveValue(bytes[field.getStartIndex() + 3], bytes[field.getStartIndex() + 2], bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
            }
        }

        internal override string handleDeviceNo(byte[] bytes)
        {
            string deviceNo = string.Format("%1$010d", BitConverter.ToInt32(new byte[] { bytes[5], bytes[6], bytes[7], bytes[8] }, 0));
            setDeviceNo(deviceNo);
            return deviceNo;
        }

        public override int getMode()
        {
            return 0;
        }
    }
    /// <summary>
    /// PLC获取水泵的方法
    /// </summary>
    internal abstract partial class Device_PLC : SdcSoftDevice
    {
        internal const string KEY_POINT_Add_SHUI_BENG = "_addshuibeng";
        internal const string KEY_POINT_Add_SHUI_BENG_1 = "de_1_addshuibeng_start_stop";
        internal const string KEY_POINT_Add_SHUI_BENG_2 = "de_2_addshuibeng_start_stop";


        internal const string KEY_POINT_XUN_HUAN_BENG = "_xunhuanbeng";
        internal const string KEY_POINT_XUN_HUAN_BENG_1 = "de_1_xunhuanbeng_start_stop";
        internal const string KEY_POINT_XUN_HUAN_BENG_2 = "de_2_xunhuanbeng_start_stop";
        internal const string KEY_POINT_XUN_HUAN_BENG_3 = "de_3_xunhuanbeng_start_stop";

        internal const string KEY_POINT_CHU_YANG_BENG = "_chuanyangbeng";
        internal const string KEY_POINT_CHU_YANG_BENG_1 = "de_1_chuyangbeng_start_stop";
        internal const string KEY_POINT_CHU_YANG_BENG_2 = "de_2_chuyangbeng_start_stop";

        internal const string KEY_POINT_ZHU_YOU_BENG = "_zhuyoubeng";
        internal const string KEY_POINT_ZHU_YOU_BENG_1 = "de_zhuyoubeng_start_stop";

        internal const string KEY_POINT_ZHEN_KONG_BENG = "_zhenkongbeng";
        internal const string KEY_POINT_ZHEN_KONG_BENG_1 = "de_zhenkongbeng_start_stop";

        internal const string KEY_POINT_JIE_NENG_BENG = "_jienengbeng";
        internal const string KEY_POINT_JIE_NENG_BENG_1 = "de_1_jienengbeng_start_stop";
        internal const string KEY_POINT_JIE_NENG_BENG_2 = "de_2_jienengbeng_start_stop";
        public override List<Element> getBeng()
        {
            List<Element> list = new List<Element>();

            if (getCountFields().ContainsKey(KEY_POINT_Add_SHUI_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_Add_SHUI_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null, d2 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_Add_SHUI_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_Add_SHUI_BENG_1];
                    count = 1;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_Add_SHUI_BENG_2))
                {
                    d2 = getDeviceFields()[KEY_POINT_Add_SHUI_BENG_2];
                    count += 2;
                }
                int v1 = 0, v2 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                    case 2:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 3:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v1 + v2);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_XUN_HUAN_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_XUN_HUAN_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null, d2 = null, d3 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_XUN_HUAN_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_XUN_HUAN_BENG_1];
                    count = 1;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_XUN_HUAN_BENG_2))
                {
                    d2 = getDeviceFields()[KEY_POINT_XUN_HUAN_BENG_2];
                    count += 2;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_XUN_HUAN_BENG_3))
                {
                    d3 = getDeviceFields()[KEY_POINT_XUN_HUAN_BENG_3];
                    count += 4;
                }
                int v1 = 0, v2 = 0, v3 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                    case 2:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 3:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v1 + v2);
                        list.Add(element);
                        break;
                    case 4:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 5:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v3 = d3.getValue() > 0 ? 4 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v1 + v3);
                        list.Add(element);
                        break;
                    case 6:
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        v3 = d3.getValue() > 0 ? 4 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v2 + v3);
                        list.Add(element);
                        break;
                    case 7:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        v3 = d3.getValue() > 0 ? 4 : 0;
                        element.SetValues(Element.Index_Beng_Count, 3, v1 + v2 + v3);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_CHU_YANG_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_CHU_YANG_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null, d2 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_CHU_YANG_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_CHU_YANG_BENG_1];
                    count = 1;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_CHU_YANG_BENG_2))
                {
                    d2 = getDeviceFields()[KEY_POINT_CHU_YANG_BENG_2];
                    count += 2;
                }
                int v1 = 0, v2 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                    case 2:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 3:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v1 + v2);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_ZHU_YOU_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_ZHU_YOU_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_ZHU_YOU_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_ZHU_YOU_BENG_1];
                    count = 1;
                }

                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_JIE_NENG_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_JIE_NENG_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null, d2 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_JIE_NENG_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_JIE_NENG_BENG_1];
                    count = 1;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_JIE_NENG_BENG_2))
                {
                    d2 = getDeviceFields()[KEY_POINT_JIE_NENG_BENG_2];
                    count += 2;
                }
                int v1 = 0, v2 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                    case 2:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 3:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        element.SetValues(Element.Index_Beng_Count, 2, v1 + v2);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_ZHEN_KONG_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_ZHEN_KONG_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_ZHEN_KONG_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_ZHEN_KONG_BENG_1];
                    count = 1;
                }

                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Beng_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }


            return list;
        }
    }
    /// <summary>
    /// PLC获取风机的方法
    /// </summary>
    internal abstract partial class Device_PLC : SdcSoftDevice
    {
        internal const string KEY_POINT_ZHAO_QI_FAN = "_zhaoqifan";
        internal const string KEY_POINT_ZHAO_QI_FAN_1 = "de_1_zhaoqifengji_start_stop";
        internal const string KEY_POINT_ZHAO_QI_FAN_2 = "de_2_zhaoqifengji_start_stop";

        internal const string KEY_POINT_GU_FENG_FAN = "_gufengfan";
        internal const string KEY_POINT_GU_FENG_FAN_1 = "de_1_gufengji_start_stop";

        internal const string KEY_POINT_YIN_FENG_FAN = "_yinfengfan";
        internal const string KEY_POINT_YIN_FENG_FAN_1 = "de_1_yinfenji_start_stop";

        internal const string KEY_POINT_LU_PAI_FAN = "_lupaifan";
        internal const string KEY_POINT_LU_PAI_FAN_1 = "de_lupai_start_stop";

        internal const string KEY_POINT_CHU_ZHA_FAN = "_chuzhafan";
        internal const string KEY_POINT_CHU_ZHA_FAN_1 = "de_chuzha_start_stop";

        public override List<Element> getFan()
        {
            List<Element> list = new List<Element>();

            if (getCountFields().ContainsKey(KEY_POINT_GU_FENG_FAN))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_GU_FENG_FAN];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Fan
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_GU_FENG_FAN_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_GU_FENG_FAN_1];
                    count = 1;
                }
                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_YIN_FENG_FAN))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_YIN_FENG_FAN];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Fan
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_YIN_FENG_FAN_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_YIN_FENG_FAN_1];
                    count = 1;
                }
                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_ZHAO_QI_FAN))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_ZHAO_QI_FAN];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Fan
                };
                DeviceFieldForUI d1 = null, d2 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_ZHAO_QI_FAN_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_ZHAO_QI_FAN_1];
                    count = 1;
                }
                if (getDeviceFields().ContainsKey(KEY_POINT_ZHAO_QI_FAN_2))
                {
                    d2 = getDeviceFields()[KEY_POINT_ZHAO_QI_FAN_2];
                    count += 2;
                }
                int v1 = 0, v2 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v1);
                        list.Add(element);
                        break;
                    case 2:
                        v2 = d2.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v2);
                        list.Add(element);
                        break;
                    case 3:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        v2 = d2.getValue() > 0 ? 2 : 0;
                        element.SetValues(Element.Index_Fan_Count, 2, v1 + v2);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_LU_PAI_FAN))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_LU_PAI_FAN];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Fan
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_LU_PAI_FAN_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_LU_PAI_FAN_1];
                    count = 1;
                }
                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }

            if (getCountFields().ContainsKey(KEY_POINT_CHU_ZHA_FAN))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_CHU_ZHA_FAN];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Fan
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_CHU_ZHA_FAN_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_CHU_ZHA_FAN_1];
                    count = 1;
                }
                int v1 = 0;
                switch (count)
                {
                    case 1:
                        v1 = d1.getValue() > 0 ? 1 : 0;
                        element.SetValues(Element.Index_Fan_Count, 1, v1);
                        list.Add(element);
                        break;
                }
            }

            return list;
        }
    }
}
