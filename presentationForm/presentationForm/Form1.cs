using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClicker_Click(object sender, EventArgs e)
        {
            UInt64 total = getTotal();
            total++;
            setTotal(total);
            enableButtons();
        }

        public UInt64 getTotal()
        {
            string strTotal = (this.txbxTotalClicks.Text);
            UInt64 total = Convert.ToUInt64(strTotal);
            return total;
        }

        public void setTotal(UInt64 newTotal)
        {
            string strTotal = (this.txbxTotalClicks.Text);
            UInt64 total = Convert.ToUInt64(strTotal);
            total = newTotal;
            this.txbxTotalClicks.Text = total.ToString();
        }

        public void enableButtons()
        {
            UInt64 total = getTotal();
            if (total >= 10)
            {
                btnCursor.Enabled = true;
            }
            else
            {
                btnCursor.Enabled = false;
            }

            if(total >= 100)
            {
                btnClickFarm.Enabled = true;
            }
            else
            {
                btnClickFarm.Enabled = false;
            }

            if(total >= 1000)
            {
                btnWOWPlayer.Enabled = true;
            }
            else
            {
                btnWOWPlayer.Enabled = false;
            }

            if (total >= 10000)
            {
                btnClickFactory.Enabled = true;
            }
            else
            {
                btnClickFactory.Enabled = false;
            }

            if (total >= 100000)
            {
                btnAlienGamer.Enabled = true;
            }
            else
            {
                btnAlienGamer.Enabled = false;
            }

            if(total >= 1000000)
            {
                btnClickingGod.Enabled = true;
            }
            else
            {
                btnClickingGod.Enabled = false;
            }
        }

        public bool buyUpgrade(UInt64 cost, Label label)
        {
            UInt64 total = getTotal();
            if(total >= cost)
            {
                setTotal(total - cost);
                string lblText = label.Text;
                int lblInt = Convert.ToInt32(lblText);
                lblInt++;
                label.Text = lblInt.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UInt64 total = getTotal();
            UInt64 totalFromUpgrades = 0;

            string LBCText = lblTotalButtonCursor.Text;
            UInt64 LBCInt = Convert.ToUInt64(LBCText);
            totalFromUpgrades += LBCInt;

            string LCFText = lblTotalClickFarm.Text;
            UInt64 LCFInt = Convert.ToUInt64(LCFText);
            totalFromUpgrades += LCFInt * 2;

            string LWPText = lblTotalWOWPlayer.Text;
            UInt64 LWPInt = Convert.ToUInt64(LWPText);
            totalFromUpgrades += LWPInt * 5;

            string LCFAText = lblTotalClickFactory.Text;
            UInt64 LCFAInt = Convert.ToUInt64(LCFAText);
            totalFromUpgrades += LWPInt * 10;

            string LAGText = lblTotalAlienGamer.Text;
            UInt64 LAGInt = Convert.ToUInt64(LAGText);
            totalFromUpgrades += LAGInt * 100;

            string LCGText = lblTotalClickingGod.Text;
            UInt64 LCGInt = Convert.ToUInt64(LCGText);
            totalFromUpgrades += LCGInt * 1000;

            setTotal(totalFromUpgrades + total);
            enableButtons();
        }

        private void btnCursor_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalButtonCursor.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(10, lblTotalButtonCursor);
                enableButtons();
            }            
        }

        private void btnClickFarm_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalClickFarm.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(100, lblTotalClickFarm);
                enableButtons();
            }
        }

        private void btnWOWPlayer_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalWOWPlayer.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(1000, lblTotalWOWPlayer);
                enableButtons();
            }
        }

        private void btnClickFactory_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalClickFactory.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(100000, lblTotalClickFactory);
                enableButtons();
            }
        }

        private void btnAlienGamer_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalAlienGamer.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(10000000, lblTotalAlienGamer);
                enableButtons();
            }
        }

        private void btnClickingGod_Click(object sender, EventArgs e)
        {
            string lblText = lblTotalClickingGod.Text;
            int lblInt = Convert.ToInt32(lblText);
            if (lblInt >= 10)
            {
                MessageBox.Show("You can\'t buy any more of those.");
            }
            else
            {
                buyUpgrade(1000000000, lblTotalClickingGod);
                enableButtons();
            }
        }
    }
}
