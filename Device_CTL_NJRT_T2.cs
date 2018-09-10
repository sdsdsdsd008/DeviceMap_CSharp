using System;
using System.Collections.Generic;
using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    internal class Device_CTL_NJRT_T2:Device_CTL
    {
        internal const string KEY_POINT_RAN_SHAO_QI = "_ranshaoqi";
        internal const string KEY_POINT_RAN_SHAO_QI_KONGZHI = "oc_ranshaoqiqitingkongzhi";
        internal const string KEY_POINT_RAN_SHAO_QI_STATUS = "oc_ranshaoqifuhetiaojie";

        internal const string KEY_POINT_Add_SHUI_BENG = "_addshuibeng";
        internal const string KEY_POINT_Add_SHUI_BENG_1 = "oc_1_addshuibeng_start_stop";
        internal const string KEY_POINT_Add_SHUI_BENG_2 = "oc_2_addshuibeng_start_stop";
        
        internal const string KEY_POINT_LENG_NING_BENG = "_lengningbeng";
        internal const string KEY_POINT_LENG_NING_BENG_1 = "oc_1_lengningxunhuanbeng_start_stop";

        public Device_CTL_NJRT_T2()
        {
            BYTE_ARRAY_LENGTH = 109;
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
            String deviceNo = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",
                bytes[68], bytes[70], bytes[72], bytes[74], bytes[76],
                bytes[78], bytes[80], bytes[82], bytes[84], bytes[86]);
            setDeviceNo(deviceNo);
            return deviceNo;
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
            list.Add(GetUiItem(getMockFields(),"mo_shuiweixinhao"));
            return list;
        } 
        public override int getMode()
        {
            return 0;
        }

        internal override DeviceFieldForUI getPowerInfo()
        {
            var deviceFieldForUI = getBaseInfoFields()[KEY_POINT_RAN_SHAO_QI];
            if (getOpenCloseFields()[KEY_POINT_RAN_SHAO_QI_KONGZHI].getValue() > 0)
                deviceFieldForUI.setValue(getOpenCloseFields()[KEY_POINT_RAN_SHAO_QI_STATUS].getValue());
            else
                deviceFieldForUI.setValue(0);
            return deviceFieldForUI;
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
            if (getCountFields().ContainsKey(KEY_POINT_LENG_NING_BENG))
            {
                var deviceFieldForUI = getCountFields()[KEY_POINT_LENG_NING_BENG];
                Element element = new Element
                {
                    Title = deviceFieldForUI.getTitle(),
                    Prefix = Element.Prefix_Beng
                };
                DeviceFieldForUI d1 = null;
                int count = 0;
                if (getDeviceFields().ContainsKey(KEY_POINT_LENG_NING_BENG_1))
                {
                    d1 = getDeviceFields()[KEY_POINT_LENG_NING_BENG_1];
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

        public override List<Element> getFan()
        {
            return new List<Element>();
        }
    }
}
