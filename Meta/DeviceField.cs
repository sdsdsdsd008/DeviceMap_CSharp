namespace SdcSoft.Devices.Meta
{
    internal abstract class DeviceField : ByteField
    {
        protected int value = 0;
        public override dynamic getValue()
        {
            return value;
        }
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_DEVICE);
        }
    }
}
