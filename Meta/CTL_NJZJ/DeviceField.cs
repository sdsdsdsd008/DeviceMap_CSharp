using System.Text;

namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class DeviceField : Meta.DeviceField
    {
        protected StringBuilder sb = new StringBuilder();

        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] | bytes[1] << 8;

            if (this.getTitle().Equals("循环泵"))
            {

            }

            if (0x7FFF == value)
                return false;

            sb.Remove(0, sb.Length);
            int v = bytes[1] | 0x3F;
            if (0xC0 == (v & 0xC0))
            {
                sb.Append(valueMap[0xC0]);
                sb.Append('/');
            }
            else
            {
                sb.Append(valueMap[0x3F]);
                sb.Append('/');
            }
            v = bytes[1] | 0xCF;
            if (0x30 == (v & 0x30))
            {
                sb.Append(valueMap[0x30]);
                sb.Append('/');
            }
            else
            {
                sb.Append(valueMap[0xCF]);
                sb.Append('/');
            }
            v = bytes[1] | 0xF0;

            if (0x0F == (v & 0x0F))
            {
                sb.Append(valueMap[0x0F]);
                //value最高位置1表示运行 置0表示停止
                //所有设备的输出量均为0-100%因此不会占用最高位
                value = bytes[0] | 0x80;//最高位置1 表示运行状态
            }
            else
            {
                sb.Append(valueMap[0xF0]);
                value = bytes[0];
            }
            return true;
        }

        public override string getValueString()
        {
            return sb.ToString();
        }
    }
}
