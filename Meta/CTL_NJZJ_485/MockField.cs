using System;

namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class MockField : Meta.MockField
    {
        public override bool haveValue(params byte[] bytes)
        {
            var i  = BitConverter.ToInt16(bytes, 0);
            
            if (0x7FFF == i)
                return false;

            value = i;

            if (getBaseNumber() > 0)
            {
                value /= getBaseNumber();
            }
            return true;
        }
    }
}
