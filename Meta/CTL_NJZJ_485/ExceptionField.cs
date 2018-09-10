namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] | (bytes[1] << 8);
            return 0xAAAA == value;
        }
    }
}
