namespace SdcSoft.Devices.Meta.PLC
{
    internal class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[1] << 8 | bytes[0];
            int i = 1 << bit;
            if ((i & value) == i)
            {
                value = 1;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }
    }
}
