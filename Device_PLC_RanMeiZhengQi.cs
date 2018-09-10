using SdcSoft.Devices.Meta;
using System.Collections.Generic;

namespace SdcSoft.Devices
{
    internal class Device_PLC_RanMeiZhengQi : Device_PLC
    {
        internal const string KEY_POINT_YIN_FENG_JI = "de_yinfeng_auto";
        public Device_PLC_RanMeiZhengQi()
        {
            BYTE_ARRAY_LENGTH = 490;
        }
        
        public override List<DeviceFieldForUI> getDeviceFocusFields()
        {
            Dictionary<string, DeviceFieldForUI> map = this.getBaseInfoFields();
            var list = new MyArrayList<DeviceFieldForUI>();

            list.Add(GetUiItem(getBaseInfoFields(),KEY_POINT_RUN_DAYS));
            list.Add(GetUiItem(getBaseInfoFields(),KEY_POINT_RUN_HOURS));



            if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
            {
                list.Add(this.getBaseInfoFields()["ba_guoluyalizhuangtai"]);
            }
            else
            {
                list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
            }
            list.Add(GetUiItem(getMockFields(),"mo_zuizhongpaiyanwendu"));
            list.Add(GetUiItem(getBaseInfoFields(),"ba_shuiweizhuangtai"));

            return list;
        }

        internal override DeviceFieldForUI getPowerInfo()
        {
            return getDeviceFields()[KEY_POINT_YIN_FENG_JI];
        }
    }
}
