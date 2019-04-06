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



        private void Timery_Tick(object sender, EventArgs e)
        {
            // Every 1 Seconds we will open the process and read for current money value and print it to a label.
            MemLib.OpenProcess("BorderlandsGOTY"); // Open Proccess
            int Money = MemLib.readInt("BorderlandsGOTY.exe+0x2544708,0x274,0x268,0x350"); // Read the Money value.
            CurrentMoneyLbl.Text = ("Current Money : " + Money.ToString()); // Print it to a label.
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            // On click, it will set the amount of $ you've set in the TextBox
            MemLib.writeMemory("BorderlandsGOTY.exe+0x2544708,0x274,0x268,0x350", "int", MoneyBoxTxt.Text); 

        }
    }
}
