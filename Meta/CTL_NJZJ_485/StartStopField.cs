using System;

namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class StartStopField : Meta.StartStopField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] | (bytes[1] << 8);
            return 0x7FFF != value;
        }
        public override string getValueString()
        {
            return string.Format("{0:D2}:{1:D2}", value / 60, value % 60);
        }
    }
}
