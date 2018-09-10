using System;

namespace SdcSoft.Devices.Meta.CTL_NJRT
{
    internal class MockField : Meta.MockField
    {
        public override bool haveValue(params byte[] bytes)
        {
            Int32 i = BitConverter.ToInt16(bytes, 0);

            if (0x7FFF == i)
                return false;

            if (getBaseNumber() > 0)
            {
                this.value = i / getBaseNumber();
            }
            else
                this.value = i;
            return true;
        }
    }
}
