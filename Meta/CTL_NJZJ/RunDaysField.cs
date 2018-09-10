using System;

namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class RunDaysField : BaseInfoField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = BitConverter.ToInt16(bytes,0);
            return true;
        }
    }
}
