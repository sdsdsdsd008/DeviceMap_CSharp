using SdcSoft.Devices.Meta;
using System.Collections.Generic;

namespace SdcSoft.Devices
{
    internal class Device_PLC_DianReShui : Device_PLC
    {
        internal const string KEY_POINT_JIA_RE_ZU = "mo_qidongjiarezushu";
        
        public Device_PLC_DianReShui()
        {
            this.BYTE_ARRAY_LENGTH = 490;
        }

        
        public override List<DeviceFieldForUI> getDeviceFocusFields()
        {
            Dictionary<string, DeviceFieldForUI> map = this.getBaseInfoFields();
            var list = new MyArrayList<DeviceFieldForUI>();
            list.Add(GetUiItem(getBaseInfoFields(),KEY_POINT_RUN_DAYS));
            list.Add(GetUiItem(getBaseInfoFields(),KEY_POINT_RUN_HOURS));

            
            list.Add(GetUiItem(getMockFields(),"mo_qidongjiarezushu"));
            list.Add(GetUiItem(getMockFields(),"mo_chushuiwendu"));
            list.Add(GetUiItem(getMockFields(),"mo_huishuiwendu"));
            list.Add(GetUiItem(getBaseInfoFields(),"ba_shuiweizhuangtai"));

            return list;
        }

        internal override DeviceFieldForUI getPowerInfo()
        {
            return getMockFields()[KEY_POINT_JIA_RE_ZU];
        }
    }
}
