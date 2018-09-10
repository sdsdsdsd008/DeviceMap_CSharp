using System;

namespace SdcSoft.Devices.Meta.PLC
{
    internal class MockField : Meta.MockField
    {
        public override bool haveValue(params byte[] bytes)
        {
            UInt32 x = (UInt32)((bytes[3] << 24) | (bytes[2]<<16) |(bytes[1] << 8) | bytes[0]);
            if (0x7FFFFFFF == x)
                return false;

            value = BitConverter.ToSingle(bytes, 0);
            return true;
        }
    }
}
