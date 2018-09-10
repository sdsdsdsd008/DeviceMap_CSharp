using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;
using System.Collections.Generic;

namespace SdcSoft.Devices
{
    internal class Device_PLC_RanYouDaoReYou : Device_PLC
    {
        internal const string KEY_POINT_RAN_SHAO_QI_STATUS = "ba_ranshaoqizhuangtai";

        internal override DeviceFieldForUI getPowerInfo()
        {
            return getBaseInfoFields()[KEY_POINT_RAN_SHAO_QI_STATUS];
        }
        public Device_PLC_RanYouDaoReYou()
        {
            this.BYTE_ARRAY_LENGTH = 245;
        }
        public override List<DeviceFieldForUI> getDeviceFocusFields()
        {
            Dictionary<string, DeviceFieldForUI> map = this.getBaseInfoFields();
            var list = new MyArrayList<DeviceFieldForUI>();
            list.Add(getBaseInfoFields()[KEY_POINT_RUN_DAYS]);
            list.Add(getBaseInfoFields()[KEY_POINT_RUN_HOURS]);
            return list;
        }

    }
}
