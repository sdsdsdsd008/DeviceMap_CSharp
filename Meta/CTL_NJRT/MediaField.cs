namespace SdcSoft.Devices.Meta.CTL_NJRT
{
    internal class MediaField : Meta.MediaField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[1];
            return true;
        }
    }
}
