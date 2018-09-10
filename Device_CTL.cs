using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    internal abstract class Device_CTL : SdcSoftDevice
    {
        public Device_CTL()
        {
            BYTE_ARRAY_LENGTH = 1024;
        }
        internal override void handleByteField(ByteField field,byte[] bytes)
        {
            switch (field.getBytesLength())
            {
                case 0:
                    if (field.haveValue(bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        AddField(field.getDeviceFieldForUI());
                    }
                    break;
                case 2:
                    if (field.haveValue(bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
                default:
                    if (field.haveValue(bytes[field.getStartIndex() + 1], bytes[field.getStartIndex()]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
            }
        }
    }
}
