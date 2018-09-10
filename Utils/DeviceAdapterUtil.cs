using SdcSoft.Devices.map;
using SdcSoft.Devices.Meta;
using System;
using System.Collections.Generic;

namespace SdcSoft.Devices.Utils
{
    public class DeviceAdapterUtil
    {
        private const string STRING_FORMAT_DEVICE_MAP_PATH = "SdcSoft.Devices.map.DevicePointMap_{0}";
        private const string STRING_FORMAT_DEVICE_PATH = "SdcSoft.Devices.Device_{0}";
        private static List<SdcSoftDevice> devices = new List<SdcSoftDevice>(10);
        private static Dictionary<string, DevicePointMap> maps = new Dictionary<string, DevicePointMap>(5);


        public static void putDeviceType(string typeName)
        {
            if (!maps.ContainsKey(typeName))
            {
                var map = Activator.CreateInstance(null, string.Format(STRING_FORMAT_DEVICE_MAP_PATH, typeName)).Unwrap() as DevicePointMap;
                maps.Add(typeName, map);
                var device = Activator.CreateInstance(null, string.Format(STRING_FORMAT_DEVICE_PATH, typeName)).Unwrap() as SdcSoftDevice;
                device.setDeviceType(typeName);
                devices.Add(device);
            }
        }

        public static void clearDevicesType()
        {
            devices.Clear();
            maps.Clear();
        }

        /// <summary>
        /// 获得设备列表的所有设备数据信息
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static List<SdcSoftDevice> getDevicesByByte(byte[] bytes)
        {
            if (devices.Count < 1)
            {
                throw new Exception("请先执行DeviceAdapterUtil.putDeviceType方法，放入准备用于解析的设备的类型。");
            }
            int byteStartIndex = 0;
            foreach (SdcSoftDevice device in devices)
            {
                initDevice(device, bytes, byteStartIndex);
                byteStartIndex += device.getDeviceBytesLength();
            }
            return devices;
        }

        /// <summary>
        /// 获得设备数据信息
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static SdcSoftDevice getDeviceByByte(byte[] bytes, String typeName)
        {
            SdcSoftDevice device = Activator.CreateInstance(null, string.Format(STRING_FORMAT_DEVICE_PATH, typeName)).Unwrap() as SdcSoftDevice;

            if (device.validateFalse(bytes.Length))
            {
                return null;
            }
            device.handleDeviceNo(bytes);
            var map = Activator.CreateInstance(null, string.Format(STRING_FORMAT_DEVICE_MAP_PATH, typeName)).Unwrap() as DevicePointMap;

            if (map == null)
                return null;
            var pointMap = map.getPointMap();
            foreach (string key in pointMap.Keys)
            {
                ByteField f = pointMap[key];
                device.handleByteField(f, bytes);
            }
            return device;
        }

        public static void initDevice(SdcSoftDevice device, byte[] bytes, int byteStartIndex)
        {
            int endIndex = byteStartIndex + device.getDeviceBytesLength();
            /**
             * 校验数据长度有效性
             */
            if (bytes.Length < endIndex)
                return;
            /**
             * byte 数组裁剪
             */
            byte[] current = new byte[device.getDeviceBytesLength()];

            for (int i = 0, j = byteStartIndex; j < endIndex; i++, j++)
            {
                current[i] = bytes[j];
            }

            /**
             * 填充设备信息
             */
            DevicePointMap devicePointMap = maps[device.getDeviceType()];
            device.handleDeviceNo(current);
            foreach (string key in devicePointMap.getPointMap().Keys)
            {
                ByteField f = devicePointMap.getPointMap()[key];
                device.handleByteField(f, current);
            }
        }
    }
}
