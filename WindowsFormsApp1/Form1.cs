using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string jonMoney = "Jon has ";
        public string tedMoney = "Ted has ";
        public string bankMoney = "Bank has ";
        public string selectionString = "";
        public int transferMoney;

        Guy Jon = new Guy(100);
        Guy Ted = new Guy(200);
        Guy Bank = new Guy(1000);

        private void button1_Click(object sender, EventArgs e)
        {
            selectionString = comboBox1.SelectedItem.ToString() + comboBox2.SelectedItem.ToString() + comboBox3.SelectedItem.ToString();
            transferMoney = Convert.ToInt32(textBox1.Text);

            switch (selectionString)
            {
                case "JonborrowsBank":
                    Jon.BorrowCash(transferMoney);
                    Bank.LendCash(transferMoney);
                    
                    //MessageBox.Show("Jon money is " + Jon.Money.ToString()+"\n" + "Bank money is " + Bank.Money.ToString());
                    //this.label1.Text = jonMoney + Jon.Money.ToString();
                    
                    break;
                case "TedborrowsBank":
                    Ted.BorrowCash(transferMoney);
                    Bank.LendCash(transferMoney);
                    break;


                default:
                    break;
            }
            
        }
    }
}
