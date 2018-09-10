namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class MediaField : Meta.MediaField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0];
            return true;
        }
    }
}
