namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class SettingField : MockField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_SETTING);
        }
    }
}
