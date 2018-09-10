namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
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
