using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2c
{
    public partial class Exit : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        public Exit()
        {
            InitializeComponent();
        }

        private void btnSetMaximum_Click(object sender, EventArgs e)
        {
            
            byte2 = Byte.MaxValue;
            byteTB2.Text = byte2.ToString();

            
            sbyte2 = sbyte.MaxValue;
            sbyteTB2.Text = sbyte2.ToString();

            
            short2 = short.MaxValue;
            shortTB2.Text = short2.ToString();

            
            ushort2 = ushort.MaxValue;
            ushortTB2.Text = ushort2.ToString();

            
            int2 = int.MaxValue;
            intTB2.Text = int2.ToString();

            
            uint2 = uint.MaxValue;
            uintTB2.Text = uint2.ToString();

            
            long2 = long.MaxValue;
            longTB2.Text = long2.ToString();

            
            ulong2 = ulong.MaxValue;
            ulongTB2.Text = ulong2.ToString();

            
            float2 = float.MaxValue;
            floatTB2.Text = float2.ToString();

            
            double2 = double.MaxValue;
            doubleTB2.Text = double2.ToString();

            
            decimal2 = decimal.MaxValue;
            decimalTB2.Text = decimal2.ToString();
        }

        private void btnSetMinimum_Click(object sender, EventArgs e)
        {
            
            byte1 = Byte.MinValue;
            byteTB1.Text = byte1.ToString();

            
            sbyte1 = sbyte.MinValue;
            sbyteTB1.Text = sbyte1.ToString();

            
            short1 = short.MinValue;
            shortTB1.Text = short1.ToString();

            
            ushort1 = ushort.MinValue;
            ushortTB1.Text = ushort1.ToString();

            
            int1 = int.MinValue;
            intTB1.Text = int1.ToString();

            
            uint1 = uint.MinValue;
            uintTB1.Text = uint1.ToString();

            
            long1 = long.MinValue;
            longTB1.Text = long1.ToString();

            
            ulong1 = ulong.MinValue;
            ulongTB1.Text = ulong1.ToString();

            
            float1 = float.MinValue;
            floatTB1.Text = float1.ToString();

            
            double1 = double.MinValue;
            doubleTB1.Text = double1.ToString();

            
            decimal1 = decimal.MinValue;
            decimalTB1.Text = decimal1.ToString();
        }

        private void btnPlus_Click
            //why does this look like a subscription service
            (object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byteTB3.Text = byte3.ToString();
            }
            catch (Exception) { byteTB3.Text = "error"; byte1 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyteTB3.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyteTB3.Text = "error"; sbyte1 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                shortTB3.Text = short3.ToString();
            }
            catch (Exception) { shortTB3.Text = "error"; short1 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                ushortTB3.Text = ushort3.ToString();
            }
            catch (Exception) { ushortTB3.Text = "error"; ushort1 = 0; }

            try
            {
                this.int3 = checked(this.int1 + this.int2);
                intTB3.Text = int3.ToString();
            }
            catch (Exception) { intTB3.Text = "error"; int1 = 0; }
            
            try
            {
                this.uint3 = checked(this.uint1 + uint2);
                uintTB3.Text = uint3.ToString();
            }
            catch (Exception) { uintTB3.Text = "error"; uint1 = 0; }

            try
            {
                this.long3 = checked(this.long1 + this.long2);
                longTB3.Text = long3.ToString();
            }
            catch (Exception) { longTB3.Text = "error"; long1 = 0; }

            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                ulongTB3.Text = ulong3.ToString();
            }
            catch (Exception) { ulongTB3.Text = "error"; ulong1 = 0; }

            try
            {
                this.float3 = checked(this.float1 + this.float2);
                floatTB3.Text = float3.ToString();
            }
            catch (Exception) { floatTB3.Text = "error"; float1 = 0.0f; }

            try
            {
                this.double3 = checked(this.double1 + this.double2);
                doubleTB3.Text = double3.ToString();
            }
            catch (Exception) { doubleTB3.Text = "error"; double1 = 0.0; }

            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                decimalTB3.Text = decimal3.ToString();
            }
            catch (Exception) { decimalTB3.Text = "error"; decimal1 = 0m; }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                byteTB3.Text = byte3.ToString();
            }
            catch (Exception) { byteTB3.Text = "error"; byte1 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                sbyteTB3.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyteTB3.Text = "error"; sbyte1 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                shortTB3.Text = short3.ToString();
            }
            catch (Exception) { shortTB3.Text = "error"; short1 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                ushortTB3.Text = ushort3.ToString();
            }
            catch (Exception) { ushortTB3.Text = "error"; ushort1 = 0; }

            try
            {
                this.int3 = checked(this.int1 - this.int2);
                intTB3.Text = int3.ToString();
            }
            catch (Exception) { intTB3.Text = "error"; int1 = 0; }

            try
            {
                this.uint3 = checked(this.uint1 - uint2);
                uintTB3.Text = uint3.ToString();
            }
            catch (Exception) { uintTB3.Text = "error"; uint1 = 0; }

            try
            {
                this.long3 = checked(this.long1 - this.long2);
                longTB3.Text = long3.ToString();
            }
            catch (Exception) { longTB3.Text = "error"; long1 = 0; }

            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                ulongTB3.Text = ulong3.ToString();
            }
            catch (Exception) { ulongTB3.Text = "error"; ulong1 = 0; }

            try
            {
                this.float3 = checked(this.float1 - this.float2);
                floatTB3.Text = float3.ToString();
            }
            catch (Exception) { floatTB3.Text = "error"; float1 = 0.0f; }

            try
            {
                this.double3 = checked(this.double1 - this.double2);
                doubleTB3.Text = double3.ToString();
            }
            catch (Exception) { doubleTB3.Text = "error"; double1 = 0.0; }

            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                decimalTB3.Text = decimal3.ToString();
            }
            catch (Exception) { decimalTB3.Text = "error"; decimal1 = 0m; }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                byteTB3.Text = byte3.ToString();
            }
            catch (Exception) { byteTB3.Text = "error"; byte1 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                sbyteTB3.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyteTB3.Text = "error"; sbyte1 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                shortTB3.Text = short3.ToString();
            }
            catch (Exception) { shortTB3.Text = "error"; short1 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                ushortTB3.Text = ushort3.ToString();
            }
            catch (Exception) { ushortTB3.Text = "error"; ushort1 = 0; }

            try
            {
                this.int3 = checked(this.int1 * this.int2);
                intTB3.Text = int3.ToString();
            }
            catch (Exception) { intTB3.Text = "error"; int1 = 0; }

            try
            {
                this.uint3 = checked(this.uint1 * uint2);
                uintTB3.Text = uint3.ToString();
            }
            catch (Exception) { uintTB3.Text = "error"; uint1 = 0; }

            try
            {
                this.long3 = checked(this.long1 * this.long2);
                longTB3.Text = long3.ToString();
            }
            catch (Exception) { longTB3.Text = "error"; long1 = 0; }

            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                ulongTB3.Text = ulong3.ToString();
            }
            catch (Exception) { ulongTB3.Text = "error"; ulong1 = 0; }

            try
            {
                this.float3 = checked(this.float1 * this.float2);
                floatTB3.Text = float3.ToString();
            }
            catch (Exception) { floatTB3.Text = "error"; float1 = 0.0f; }

            try
            {
                this.double3 = checked(this.double1 * this.double2);
                doubleTB3.Text = double3.ToString();
            }
            catch (Exception) { doubleTB3.Text = "error"; double1 = 0.0; }

            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                decimalTB3.Text = decimal3.ToString();
            }
            catch (Exception) { decimalTB3.Text = "error"; decimal1 = 0m; }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                byteTB3.Text = byte3.ToString();
            }
            catch (Exception) { byteTB3.Text = "error"; byte1 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                sbyteTB3.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyteTB3.Text = "error"; sbyte1 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                shortTB3.Text = short3.ToString();
            }
            catch (Exception) { shortTB3.Text = "error"; short1 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                ushortTB3.Text = ushort3.ToString();
            }
            catch (Exception) { ushortTB3.Text = "error"; ushort1 = 0; }

            try
            {
                this.int3 = checked(this.int1 / this.int2);
                intTB3.Text = int3.ToString();
            }
            catch (Exception) { intTB3.Text = "error"; int1 = 0; }

            try
            {
                this.uint3 = checked(this.uint1 / uint2);
                uintTB3.Text = uint3.ToString();
            }
            catch (Exception) { uintTB3.Text = "error"; uint1 = 0; }

            try
            {
                this.long3 = checked(this.long1 / this.long2);
                longTB3.Text = long3.ToString();
            }
            catch (Exception) { longTB3.Text = "error"; long1 = 0; }

            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                ulongTB3.Text = ulong3.ToString();
            }
            catch (Exception) { ulongTB3.Text = "error"; ulong1 = 0; }

            try
            {
                this.float3 = checked(this.float1 / this.float2);
                floatTB3.Text = float3.ToString();
            }
            catch (Exception) { floatTB3.Text = "error"; float1 = 0.0f; }

            try
            {
                this.double3 = checked(this.double1 / this.double2);
                doubleTB3.Text = double3.ToString();
            }
            catch (Exception) { doubleTB3.Text = "error"; double1 = 0.0; }

            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                decimalTB3.Text = decimal3.ToString();
            }
            catch (Exception) { decimalTB3.Text = "error"; decimal1 = 0m; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {          
            try
            {
                byte1 = Convert.ToByte(input1TextBox.Text);
                byteTB1.Text = byte1.ToString();
            }

            catch (Exception) { byteTB1.Text = "error"; }

            try {
                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyteTB1.Text = sbyte1.ToString();
            }

            catch (Exception) { sbyteTB1.Text = "error"; }

            try {
                short1 = Convert.ToInt16(input1TextBox.Text);
                shortTB1.Text = short1.ToString();
            }

            catch (Exception) { shortTB1.Text = "error"; }

            try {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushortTB1.Text = ushort1.ToString();
            }

            catch (Exception) { ushortTB1.Text = "error"; }

            try {
                int1 = Convert.ToInt32(input1TextBox.Text);
                intTB1.Text = int1.ToString();
            }

            catch (Exception) { intTB1.Text = "error"; }

            try {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
                uintTB1.Text = uint1.ToString();
            }

            catch (Exception) { uintTB1.Text = "error"; }

            try {
                long1 = Convert.ToInt64(input1TextBox.Text);
                longTB1.Text = long1.ToString();
            }

            catch (Exception) { longTB1.Text = "error"; }

            try {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulongTB1.Text = ulong1.ToString();
            }

            catch (Exception) { ulongTB1.Text = "error"; }

            try {
                float1 = Convert.ToSingle(input1TextBox.Text);
                floatTB1.Text = float1.ToString();
            }

            catch (Exception) { floatTB1.Text = "error"; }

            try {
                double1 = Convert.ToDouble(input1TextBox.Text);
                doubleTB1.Text = double1.ToString();
            }

            catch (Exception) { doubleTB1.Text = "error"; }

            try {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimalTB1.Text = decimal1.ToString();
            }

            catch (Exception) { decimalTB1.Text = "error"; }
        }

        private void input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2TextBox.Text);
                byteTB2.Text = byte2.ToString();
            }

            catch (Exception) { byteTB2.Text = "error"; }

            try
            {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyteTB2.Text = sbyte2.ToString();
            }

            catch (Exception) { sbyteTB2.Text = "error"; }

            try
            {
                short2 = Convert.ToInt16(input2TextBox.Text);
                shortTB2.Text = short2.ToString();
            }

            catch (Exception) { shortTB2.Text = "error"; }

            try
            {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushortTB2.Text = ushort2.ToString();
            }

            catch (Exception) { ushortTB2.Text = "error"; }

            try
            {
                int2 = Convert.ToInt32(input2TextBox.Text);
                intTB2.Text = int2.ToString();
            }

            catch (Exception) { intTB2.Text = "error"; }

            try
            {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uintTB2.Text = uint2.ToString();
            }

            catch (Exception) { uintTB2.Text = "error"; }

            try
            {
                long2 = Convert.ToInt64(input2TextBox.Text);
                longTB2.Text = long2.ToString();
            }

            catch (Exception) { longTB2.Text = "error"; }

            try
            {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulongTB2.Text = ulong2.ToString();
            }

            catch (Exception) { ulongTB2.Text = "error"; }

            try
            {
                float2 = Convert.ToSingle(input2TextBox.Text);
                floatTB2.Text = float2.ToString();
            }

            catch (Exception) { floatTB2.Text = "error"; }

            try
            {
                double2 = Convert.ToDouble(input2TextBox.Text);
                doubleTB2.Text = double2.ToString();
            }

            catch (Exception) { doubleTB2.Text = "error"; }

            try
            {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimalTB2.Text = decimal2.ToString();
            }

            catch (Exception) { decimalTB2.Text = "error"; }
        }
    }
}
