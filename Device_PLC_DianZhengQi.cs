using System.Collections.Generic;
using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    internal class Device_PLC_DianZhengQi : Device_PLC
    {
        internal const string KEY_POINT_JIA_RE_ZU = "mo_qidongjiarezushu";
        public Device_PLC_DianZhengQi()
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
            list.Add(GetUiItem(getBaseInfoFields(),"ba_shuiweizhuangtai"));
            if (getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
            {
                list.Add(getBaseInfoFields()["ba_guoluyalizhuangtai"]);
            }
            else
            {
                list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
            }

            return list;
        }

      
        internal override DeviceFieldForUI getPowerInfo()
        {
            return getMockFields()[KEY_POINT_JIA_RE_ZU];
        }
    }
}
