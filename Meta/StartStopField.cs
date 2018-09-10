namespace SdcSoft.Devices.Meta
{

    internal abstract class StartStopField : ByteField
    {
        protected int value;
        public override object getValue()
        {
            return value;
        }
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_START_STOP);
        }
    }
}
