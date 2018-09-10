namespace SdcSoft.Devices.Meta.PLC
{
    internal class SettingField : MockField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_SETTING);
        }
    }
}
