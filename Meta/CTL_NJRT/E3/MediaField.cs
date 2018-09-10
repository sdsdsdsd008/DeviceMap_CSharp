namespace SdcSoft.Devices.Meta.CTL_NJRT.E3
{
    internal class MediaField : Meta.MediaField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = startIndex;
            return true;
        }
    }
}
