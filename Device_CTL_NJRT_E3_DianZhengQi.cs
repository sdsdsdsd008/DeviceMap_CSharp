using System.Collections.Generic;
using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    internal class Device_CTL_NJRT_E3_DianZhengQi:Device_CTL
    {
        internal const string KEY_POINT_RAN_SHAO_QI = "_jiarezu";
        internal const string KEY_POINT_Add_SHUI_BENG = "_addshuibeng";
        internal const string KEY_POINT_Add_SHUI_BENG_1 = "oc_1_addshuibeng_start_stop";
        internal const string KEY_POINT_Add_SHUI_BENG_2 = "oc_2_addshuibeng_start_stop";
        
        public Device_CTL_NJRT_E3_DianZhengQi()
        {
            BYTE_ARRAY_LENGTH = 57;
        }

        /// <summary>
        /// T2控制器 bytes数据传递方式为高位在前，低位在后的模式传输到服务器
        /// 在java程序中也按照高位在前低位在后的模式处理</summary>
        /// <param name="field"></param>
        /// <param name="bytes"></param>
        internal override void handleByteField(ByteField field, byte[] bytes)
        {
            if (field.haveValue(bytes[field.getStartIndex()], bytes[field.getStartIndex() + 1]))
            {
                this.AddField(field.getDeviceFieldForUI());
            }
        }
        
        internal override string handleDeviceNo(byte[] bytes)
        {
            return string.Empty;
        }

        public override List<DeviceFieldForUI> getDeviceFocusFields()
        {
            Dictionary<string, DeviceFieldForUI> map = getBaseInfoFields();
            var list = new MyArrayList<DeviceFieldForUI>();
            
            var field = getBaseInfoFields()[KEY_POINT_RUN_DAYS];
            var i = getBaseInfoFields()[KEY_POINT_RUN_LIFE].getValue();
            field.setValue(i / 24);
            list.Add(field);

            field = getBaseInfoFields()[KEY_POINT_RUN_HOURS];
            field.setValue(i % 24);
            list.Add(field);
            field = getPowerInfo();
            list.Add(field);
            list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
            return list;
        }

        public override int getMode()
        {
            return 0;
        }

        internal override DeviceFieldForUI getPowerInfo()
        {
            var deviceFieldForUI = getBaseInfoFields()[KEY_POINT_RAN_SHAO_QI];
            int count = GetJiaReZuCount();
            deviceFieldForUI.setValue(count);
            return deviceFieldForUI;
        }

        private int GetJiaReZuCount()
        {
            int count = 0;
            foreach (var key in getOpenCloseFields().Keys)
            {
                if (key.Contains("jiarezu"))
                {
                    count += getOpenCloseFields()[key].getValue();
                }
            }
            return count;
        }

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
            return list;
        }

        public override List<Element> getFan()
        {
            return new List<Element>();
        }
    }
}
