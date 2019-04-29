using System;
using System.Windows.Forms;
using Memory;



namespace BorderlandsGOTY_Money
{
    public partial class Form1 : Form
    {
        public Mem MemLib = new Mem(); //Define / Call / Name the library.

        public Form1()
        {
            InitializeComponent();
        }

        //GoldenKeysTotal   0x025C1D90,0x68,0x550,0x1B8,0x1070,0x64,0x300
        //GoldenKeysUsed    0x025C1D90,0x68,0x550,0x1B8,0x1070,0x64,0x31C

        private void Timery_Tick(object sender, EventArgs e)
        {
            // Every 1 Seconds we will open the process and read for current money value and print it to a label.
            MemLib.OpenProcess("BorderlandsGOTY"); // Open Proccess
            int Money = MemLib.readInt("BorderlandsGOTY.exe+0x025C1D90,0x68,0x550,0x1F8,0x350"); // Read the Money value.
            CurrentMoneyLbl.Text = ("Current Money : " + Money.ToString()); // Print it to a label.
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            // On click, it will set the amount of $ you've set in the TextBox
            MemLib.writeMemory("BorderlandsGOTY.exe+0x025C1D90,0x68,0x550,0x1F8,0x350", "int", MoneyBoxTxt.Text); 

        }

        private void ArmorCheckbox_Click(object sender, EventArgs e)
        {
            if (ArmorCheckbox.Checked == true)
            {
                ArmorTimer.Enabled = true;
            }
            else
            {
                ArmorTimer.Enabled = false;

            }
        }

        private void ArmorTimer_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("BorderlandsGOTY.exe+0x02559858,0x40,0x290,0x98", "float", "1000");

        }
    }
}
