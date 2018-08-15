using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp051401
{
    public partial class Form1 : Form
    {
        int Quality1 = 0, Quality2 = 0, Quality3 = 0, Quality4 = 0, Quality5 = 0;
        double Price1 = 0.0, Price2 = 0.0, Price3 = 0.0, Price4 = 0.0, Price5 = 0.0;
        double Product1_Price = 0.0, Product2_Price = 0.0, Product3_Price = 0.0,
            Product4_Price = 0.0, Product5_Price = 0.0;
        double Percent = 0.0;
        double Price = 0.0;
        double TotalPrice = 0.0;
        string btMessage = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblProduct1.Text = "Black Tea ";
            lblProduct2.Text = "Green Tea ";
            lblProduct3.Text = "Milk Tea ";
            lblProduct4.Text = "Flower Tea ";
            lblProduct5.Text = "Juice ";

            Price1 = 35.0;
            Price2 = 40.0;
            Price3 = 45.0;
            Price4 = 50.0;
            Price5 = 55.0;

            lblPrice1.Text = Price1.ToString();
            lblPrice2.Text = Price2.ToString();
            lblPrice3.Text = Price3.ToString();
            lblPrice4.Text = Price4.ToString();
            lblPrice5.Text = Price5.ToString();

            Percent = 10.0;
        }

        private void btnMin1_Click(object sender, EventArgs e)
        {
            Quality1 -= 1;
            if (Quality1 < 0)
            {
                Quality1 = 0;
                btnMin1.Enabled = false;
            }
            tbQuality1.Text = Quality1.ToString();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            Quality1 += 1;
            btnMin1.Enabled = true;
            tbQuality1.Text = Quality1.ToString();
        }

        private void tbQuality1_TextChanged(object sender, EventArgs e)
        {
            if (tbQuality1.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbQuality1.Text, out Quality1);

                if ((ifNum == true) && (Quality1 >= 0))
                {
                    btnMin1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong Quality");
                    Quality1 = 0;
                    tbQuality1.Text = "0";
                }
            }
            else
            {
                Quality1 = 0;
            }
            CountPrice();
        }

        private void btnMin2_Click(object sender, EventArgs e)
        {
            Quality2 -= 1;
            if (Quality2 < 0)
            {
                Quality2 = 0;
                btnMin2.Enabled = false;
            }
            tbQuality2.Text = Quality2.ToString();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            Quality2 += 1;
            btnMin2.Enabled = true;
            tbQuality2.Text = Quality2.ToString();
        }

        private void tbQuality2_TextChanged(object sender, EventArgs e)
        {
            if (tbQuality2.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbQuality2.Text, out Quality2);

                if ((ifNum == true) && (Quality2 >= 0))
                {
                    btnMin2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong Quality");
                    Quality2 = 0;
                    tbQuality2.Text = "0";
                }
            }
            else
            {
                Quality2 = 0;
            }
            CountPrice();
        }

        private void btnMin3_Click(object sender, EventArgs e)
        {
            Quality3 -= 1;
            if (Quality3 < 0)
            {
                Quality3 = 0;
                btnMin3.Enabled = false;
            }
            tbQuality3.Text = Quality3.ToString();
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            Quality3 += 1;
            btnMin3.Enabled = true;
            tbQuality3.Text = Quality3.ToString();
        }

        private void tbQuality3_TextChanged(object sender, EventArgs e)
        {
            if (tbQuality3.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbQuality3.Text, out Quality3);

                if ((ifNum == true) && (Quality3 >= 0))
                {
                    btnMin3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong Quality");
                    Quality3 = 0;
                    tbQuality3.Text = "0";
                }
            }
            else
            {
                Quality3 = 0;
            }
            CountPrice();
        }

        

        private void btnMin4_Click(object sender, EventArgs e)
        {
            Quality4 -= 1;
            if (Quality4 < 0)
            {
                Quality4 = 0;
                btnMin4.Enabled = false;
            }
            tbQuality4.Text = Quality4.ToString();
        }

        private void btnPlus4_Click(object sender, EventArgs e)
        {
            Quality4 += 1;
            btnMin4.Enabled = true;
            tbQuality4.Text = Quality4.ToString();
        }

        private void tbQuality4_TextChanged(object sender, EventArgs e)
        {
            if (tbQuality4.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbQuality4.Text, out Quality4);

                if ((ifNum == true) && (Quality4 >= 0))
                {
                    btnMin4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong Quality");
                    Quality4 = 0;
                    tbQuality4.Text = "0";
                }
            }
            else
            {
                Quality4 = 0;
            }
            CountPrice();
        }

        private void btnMin5_Click(object sender, EventArgs e)
        {
            Quality5 -= 1;
            if (Quality5 < 0)
            {
                Quality5 = 0;
                btnMin5.Enabled = false;
            }
            tbQuality5.Text = Quality5.ToString();
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            Quality5 += 1;
            btnMin5.Enabled = true;
            tbQuality5.Text = Quality5.ToString();
        }

        private void tbQuality5_TextChanged(object sender, EventArgs e)
        {
            if (tbQuality5.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbQuality5.Text, out Quality5);

                if ((ifNum == true) && (Quality5 >= 0))
                {
                    btnMin5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong Quality");
                    Quality5 = 0;
                    tbQuality5.Text = "0";
                }
            }
            else
            {
                Quality5 = 0;
            }
            CountPrice();
        }

        private void tbPersent_TextChanged(object sender, EventArgs e)
        {
            if (tbPersent.Text != "")
            {
                bool ifNum = Double.TryParse(tbPersent.Text, out Percent);
                if (ifNum == true)
                {
                    if ((Percent >= 0.0) && (Percent <= 10.0))
                    {

                    }
                    else
                    {
                        MessageBox.Show("From 0.0-10.0 Percent");
                        tbPersent.Text = "";
                        Percent = 10.0;
                    }
                }
                else
                {
                    MessageBox.Show("From 0.0-10.0 Percent");
                    tbPersent.Text = "";
                    Percent = 10.0;
                }
            }
            else
            {
                Percent = 10.0;
            }
            CountPrice();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("Print Receive", "Receive Ok", MessageBoxButtons.OKCancel);
            
            if (drResult == DialogResult.Cancel)
            {
                //Cancel
            }
            else
            {
                //Ok
                string strOrder = "***III Drink Receive***\n";
                strOrder += "---------------\n";
                if (Quality1 > 0)
                {
                    strOrder += lblProduct1.Text + "." + lblPrice1.Text + "x" + tbQuality1.Text +
                        "=" + Product1_Price.ToString() + "\n";
                }
                if (Quality2 > 0)
                {
                    strOrder += lblProduct2.Text + "." + lblPrice2.Text + "x" + tbQuality2.Text +
                        "=" + Product2_Price.ToString() + "\n";
                }
                if (Quality3 > 0)
                {
                    strOrder += lblProduct3.Text + "." + lblPrice3.Text + "x" + tbQuality3.Text +
                        "=" + Product3_Price.ToString() + "\n";
                }
                if (Quality4 > 0)
                {
                    strOrder += lblProduct4.Text + "." + lblPrice4.Text + "x" + tbQuality4.Text +
                        "=" + Product4_Price.ToString() + "\n";
                }
                if (Quality5 > 0)
                {
                    strOrder += lblProduct5.Text + "." + lblPrice5.Text + "x" + tbQuality5.Text +
                        "=" + Product5_Price.ToString() + "\n";
                }
                strOrder += "Total : ";
                strOrder += Quality1 * Price1 + Quality2 * Price2 +
                            Quality3 * Price3 + Quality4 * Price4 +
                            Quality5 * Price5 + "\n";
                strOrder += "---------------\n";
                if (btMessage.Equals("two"))
                {
                    strOrder += "第二件6折\n";
                }
                if (btMessage.Equals("three"))
                {
                    strOrder += "買三送一\n";
                }
                strOrder += "Benefit Price : " + lblPrice.Text + "\n";
                if (Percent < 10.0)
                {
                    strOrder += "Benefit Discount : " + String.Format("{0:F2}", Percent)+"折" + "\n";
                }
                strOrder += "Total Price : " + lblTotalPrice.Text + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "Total Receive", MessageBoxButtons.OK);
            }
        }

        private void btnTwoforBenefit_Click(object sender, EventArgs e)
        {
            TwoforBenefit();
            DialogResult drResult;
            drResult = MessageBox.Show("Print Receive", "Receive Ok", MessageBoxButtons.OKCancel);
            btMessage = "two";
            if (drResult == DialogResult.Cancel)
            {
                //Cancel
            }
            else
            {
                //Ok
                string strOrder = "***III Drink Receive***\n";
                strOrder += "---------------\n";
                if (Quality1 > 0)
                {
                    strOrder += lblProduct1.Text + "." + lblPrice1.Text + "x" + tbQuality1.Text +
                        "=" + Product1_Price.ToString() + "\n";
                }
                if (Quality2 > 0)
                {
                    strOrder += lblProduct2.Text + "." + lblPrice2.Text + "x" + tbQuality2.Text +
                        "=" + Product2_Price.ToString() + "\n";
                }
                if (Quality3 > 0)
                {
                    strOrder += lblProduct3.Text + "." + lblPrice3.Text + "x" + tbQuality3.Text +
                        "=" + Product3_Price.ToString() + "\n";
                }
                if (Quality4 > 0)
                {
                    strOrder += lblProduct4.Text + "." + lblPrice4.Text + "x" + tbQuality4.Text +
                        "=" + Product4_Price.ToString() + "\n";
                }
                if (Quality5 > 0)
                {
                    strOrder += lblProduct5.Text + "." + lblPrice5.Text + "x" + tbQuality5.Text +
                        "=" + Product5_Price.ToString() + "\n";
                }
                strOrder += "Total : ";
                strOrder += Quality1 * Price1 + Quality2 * Price2 +
                            Quality3 * Price3 + Quality4 * Price4 +
                            Quality5 * Price5 + "\n";
                strOrder += "---------------\n";
                if (btMessage.Equals("two"))
                {
                    strOrder += "第二件6折\n";
                }
                strOrder += "Benefit Price : " + lblPrice.Text + "\n";
                if (Percent < 10.0)
                {
                    strOrder += "Benefit Discount : " + String.Format("{0:F2}", Percent) + "折" + "\n";
                }
                strOrder += "Total Price : " + lblTotalPrice.Text + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "Total Receive", MessageBoxButtons.OK);
            }
        }

        void TwoforBenefit()
        {
            double BenefitPrice1 = 0, BenefitPrice2 = 0, BenefitPrice3 = 0,
                   BenefitPrice4 = 0, BenefitPrice5 = 0;
            int    BenefitQuality = 2;

            if (Quality1 % BenefitQuality == 0)
            {
                BenefitPrice1 = Quality1 * Price1 * 0.8;
            }
            else
            {
                BenefitPrice1 = (Quality1 - 1) * Price1 * 0.8 + (Quality1 - (Quality1 - 1)) * Price1;
            }

            if (Quality2 % BenefitQuality == 0)
            {
                BenefitPrice2 = Quality2 * Price2 * 0.8;
            }
            else
            {
                BenefitPrice2 = (Quality2 - 1) * Price2 * 0.8 + (Quality2 - (Quality2 - 1)) * Price2;
            }

            if (Quality3 % BenefitQuality == 0)
            {
                BenefitPrice3 = Quality3 * Price3 * 0.8;
            }
            else
            {
                BenefitPrice3 = (Quality3 - 1) * Price3 * 0.8 + (Quality3 - (Quality3 - 1)) * Price3;
            }

            if (Quality4 % BenefitQuality == 0)
            {
                BenefitPrice4 = Quality4 * Price4 * 0.8;
            }
            else
            {
                BenefitPrice4 = (Quality4 - 1) * Price4 * 0.8 + (Quality4 - (Quality4 - 1)) * Price4;
            }

            if (Quality5 % BenefitQuality == 0)
            {
                BenefitPrice5 = Quality5 * Price5 * 0.8;
            }
            else
            {
                BenefitPrice5 = (Quality5 - 1) * Price5 * 0.8 + (Quality5 - (Quality5 - 1)) * Price5;
            }
            Price = BenefitPrice1 + BenefitPrice2 + BenefitPrice3 + BenefitPrice4 + BenefitPrice5;
            TotalPrice = Price * Percent / 10.0;
            lblPrice.Text = String.Format("{0:c}", Price);
            lblTotalPrice.Text = String.Format("{0:c}", TotalPrice);
            
        }

        private void btnThreeforBenefit_Click(object sender, EventArgs e)
        {
            ThreeforBenefit();
            DialogResult drResult;
            btMessage = "three";
            drResult = MessageBox.Show("Print Receive", "Receive Ok", MessageBoxButtons.OKCancel);

            if (drResult == DialogResult.Cancel)
            {
                //Cancel
            }
            else
            {
                //Ok
                string strOrder = "***III Drink Receive***\n";
                strOrder += "---------------\n";
                if (Quality1 > 0)
                {
                    strOrder += lblProduct1.Text + "." + lblPrice1.Text + "x" + tbQuality1.Text +
                        "=" + Product1_Price.ToString() + "\n";
                }
                if (Quality2 > 0)
                {
                    strOrder += lblProduct2.Text + "." + lblPrice2.Text + "x" + tbQuality2.Text +
                        "=" + Product2_Price.ToString() + "\n";
                }
                if (Quality3 > 0)
                {
                    strOrder += lblProduct3.Text + "." + lblPrice3.Text + "x" + tbQuality3.Text +
                        "=" + Product3_Price.ToString() + "\n";
                }
                if (Quality4 > 0)
                {
                    strOrder += lblProduct4.Text + "." + lblPrice4.Text + "x" + tbQuality4.Text +
                        "=" + Product4_Price.ToString() + "\n";
                }
                if (Quality5 > 0)
                {
                    strOrder += lblProduct5.Text + "." + lblPrice5.Text + "x" + tbQuality5.Text +
                        "=" + Product5_Price.ToString() + "\n";
                }
                strOrder += "Total : ";
                strOrder += Quality1 * Price1 + Quality2 * Price2 +
                            Quality3 * Price3 + Quality4 * Price4 +
                            Quality5 * Price5 + "\n";
                strOrder += "---------------\n";
                if (btMessage.Equals("three"))
                {
                    strOrder += "買三送一\n";
                }
                strOrder += "Benefit Price : " + lblPrice.Text + "\n";
                if (Percent < 10.0)
                {
                    strOrder += "Benefit Discount : " + String.Format("{0:F2}", Percent) + "折" + "\n";
                }
                strOrder += "Total Price : " + lblTotalPrice.Text + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "Total Receive", MessageBoxButtons.OK);
            }
        }

        void ThreeforBenefit()
        {
            List<double> array1 = new List<double>();
            int TotalQuality = 0;
            double[] ProductPrice = { Price1, Price2, Price3, Price4, Price5 };
            TotalQuality = Quality1+Quality2+Quality3+Quality4+Quality5;
            double sum = 0;
            int BenefitQuality = 4;

            if (TotalQuality% BenefitQuality == 0)
            {
                 for (int q1 = 0; q1 < Quality1; q1++)
                 {
                    array1.Add(Price1);
                 }
                for (int q2 = 0; q2 < Quality2; q2++)
                {
                    array1.Add(Price2);
                }
                for (int q3 = 0; q3 < Quality3; q3++)
                {
                    array1.Add(Price3);
                }
                for (int q4 = 0; q4 < Quality4; q4++)
                {
                    array1.Add(Price4);
                }
                for (int q5 = 0; q5 < Quality5; q5++)
                {
                    array1.Add(Price5);
                }
                for (int i = 0; i < TotalQuality; i++)
                {
                    sum = array1[i] + sum;
                }
                for (int i = 0; i < TotalQuality/4; i++)
                {
                    sum = sum - array1[i];
                }
                //Console.WriteLine(sum);
                /*
                foreach (double item in array1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----");
                */
                Price = sum;
                TotalPrice = Price * Percent / 10.0;
                lblPrice.Text = String.Format("{0:c}", Price);
                lblTotalPrice.Text = String.Format("{0:c}", TotalPrice);
            }
            else
            {
                if ((TotalQuality- BenefitQuality) > 0)
                {
                    for (int q1 = 0; q1 < Quality1; q1++)
                    {
                        array1.Add(Price1);
                    }
                    for (int q2 = 0; q2 < Quality2; q2++)
                    {
                        array1.Add(Price2);
                    }
                    for (int q3 = 0; q3 < Quality3; q3++)
                    {
                        array1.Add(Price3);
                    }
                    for (int q4 = 0; q4 < Quality4; q4++)
                    {
                        array1.Add(Price4);
                    }
                    for (int q5 = 0; q5 < Quality5; q5++)
                    {
                        array1.Add(Price5);
                    }
                    for (int i = 0; i < TotalQuality; i++)
                    {
                        sum = array1[i] + sum;
                    }
                    for (int i = 0; i < (TotalQuality-(TotalQuality% BenefitQuality)) / BenefitQuality; i++)
                    {
                        sum = sum - array1[i];
                    }
                    //Console.WriteLine(sum);
                    Price = sum;
                    TotalPrice = Price * Percent / 10.0;
                    lblPrice.Text = String.Format("{0:c}", Price);
                    lblTotalPrice.Text = String.Format("{0:c}", TotalPrice);
                }
                else
                {
                    MessageBox.Show("You can't do this!!");
                    Quality1 = 0;
                    Quality2 = 0;
                    Quality3 = 0;
                    Quality4 = 0;
                    Quality5 = 0;
                }
            }
        }

        void CountPrice()
        {
            Product1_Price = Quality1 * Price1;
            Product2_Price = Quality2 * Price2;
            Product3_Price = Quality3 * Price3;
            Product4_Price = Quality4 * Price4;
            Product5_Price = Quality5 * Price5;

            Price = Product1_Price + Product2_Price + Product3_Price + Product4_Price + Product5_Price;
            TotalPrice = Price * Percent / 10.0;
            lblPrice.Text = String.Format("{0:c}", Price);
            lblTotalPrice.Text = String.Format("{0:c}", TotalPrice);
        }
    }
}
