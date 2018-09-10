﻿namespace SdcSoft.Devices.Meta
{
/**
 * 暂时不起作用，仅标识系统中应有设置参数区
 * 目前设置参数的解析过程与模拟量相同，但并不绝对，因此该类应该保留以备后续扩展
 * 当存在设置参数与模拟量不同的设备时，该类将参与到继承系统中
 */
    internal abstract class SettingField : MockField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
             fieldForUI.setKey(SdcSoftDevice.KEY_SETTING);
        }
    }
}
