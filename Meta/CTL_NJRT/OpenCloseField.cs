namespace SdcSoft.Devices.Meta.CTL_NJRT
{
    internal class OpenCloseField : Meta.OpenCloseField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] << 8 | bytes[1];
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
