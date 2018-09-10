namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            if (0xFF == bytes[0])
                return false;
            value = bytes[0];
            return value > 0;
        }
    }
}
