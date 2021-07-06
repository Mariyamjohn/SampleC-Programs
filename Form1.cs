using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Hotel_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13;


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox14.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cheeseballs.Checked = false;
            textBox2.Text = "0";
            textBox2.Visible = false;
            chickenwings.Checked = false;
            textBox3.Text = "0";
            textBox3.Visible = false;
            crabcake.Checked = false;
            textBox4.Text = "0";
            textBox4.Visible = false;
            stuffedmushroom.Checked = false;
            textBox5.Text = "0";
            textBox5.Visible = false;
            calamarifries.Checked = false;
            textBox6.Text = "0";
            textBox6.Visible = false;
            frenchfries.Checked = false;
            textBox7.Text = "0";
            textBox7.Visible = false;
            chickenschnitzel.Checked = false;
            textBox8.Text = "0";
            textBox8.Visible = false;
            roastedpork.Checked = false;
            textBox9.Text = "0";
            textBox9.Visible = false;
            beefrouladen.Checked = false;
            textBox10.Text = "0";
            textBox10.Visible = false;
            pasta.Checked = false;
            textBox11.Text = "0";
            textBox11.Visible = false;
            dessert1.Checked = false;
            textBox12.Text = "0";
            textBox12.Visible = false;
            dessert2.Checked = false;
            textBox13.Text = "0";
            textBox13.Visible = false;
            dessert3.Checked = false;
            textBox14.Text = "0";
            textBox14.Visible = false;
            textBox1.Text = "0";

        }        
        private String checkForValidQuantity()
        {
            String getamt = Microsoft.VisualBasic.Interaction.InputBox("Quantity", "Enter the quantity");            
            bool chk = int.TryParse(getamt, out int result);
            if (getamt == "")
            {
                chk = true;                
            }
            while(!chk | result < 0)
                
            {
                MessageBox.Show("Please enter a valid amount");                
                getamt = Microsoft.VisualBasic.Interaction.InputBox("Quantity", "Enter the quantity");
                chk = int.TryParse(getamt, out result);
                if (getamt == "")
                {
                    chk = true;
                }
            }        

                        
            return getamt;
        }
        
        private void cheeseballs_CheckedChanged(object sender, EventArgs e)
        {
            if(cheeseballs.Checked)
            {

                cheeseballs.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox2.Visible = false;
                    cheeseballs.Checked = false;
                }
                else
                {
                    textBox2.Visible = true;
                    textBox2.Text = val.ToString();
                }             


            }                
            else
            {
                textBox2.Visible = false;
                cheeseballs.Checked = false;
            }           



        }

        private void chickenwings_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenwings.Checked)
            {
                chickenwings.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox3.Visible = false;
                    chickenwings.Checked = false;
                }
                else
                {
                    textBox3.Visible = true;
                    textBox3.Text = val.ToString();
                }              

            }
                
            else
            {
                chickenwings.Checked = false;
                textBox3.Visible = false;
            }
                
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (crabcake.Checked)
            {
                crabcake.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox4.Visible = false;
                    crabcake.Checked = false;
                }
                else
                {
                    textBox4.Visible = true;
                    textBox4.Text = val.ToString();
                }
            }

            else
            {
                crabcake.Checked = false;
                textBox4.Visible = false;
            }
        }

        private void stuffedmushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedmushroom.Checked)
            {
                stuffedmushroom.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox5.Visible = false;
                    stuffedmushroom.Checked = false;
                }
                else
                {
                    textBox5.Visible = true;
                    textBox5.Text = val.ToString();

                }
                

            }

            else
            {
                stuffedmushroom.Checked = false;
                textBox5.Visible = false;
            }

        }

        private void calamarifries_CheckedChanged(object sender, EventArgs e)
        {
            if (calamarifries.Checked)
            {
                calamarifries.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox6.Visible = false;
                    calamarifries.Checked = false;
                }
                else
                {
                    textBox6.Visible = true;
                    textBox6.Text = val.ToString();

                }                

            }

            else
            {
                calamarifries.Checked = false;
                textBox6.Visible = false;
            }
        }

        private void frenchfries_CheckedChanged(object sender, EventArgs e)
        {
            if (frenchfries.Checked)
            {
                frenchfries.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox7.Visible = false;
                    frenchfries.Checked = false;
                }
                else
                {
                    textBox7.Visible = true;
                    textBox7.Text = val.ToString();

                }
                

            }

            else
            {
                frenchfries.Checked = false;
                textBox7.Visible = false;
            }
        }

        private void chickenschnitzel_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenschnitzel.Checked)
            {
                chickenschnitzel.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox8.Visible = false;
                    chickenschnitzel.Checked = false;
                }
                else
                {
                    textBox8.Visible = true;
                    textBox8.Text = val.ToString();

                }               

            }

            else
            {
                chickenschnitzel.Checked = false;
                textBox8.Visible = false;
            }
        }

        private void roastedpork_CheckedChanged(object sender, EventArgs e)
        {
            if (roastedpork.Checked)
            {
                roastedpork.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox9.Visible = false;
                    roastedpork.Checked = false;
                }
                else
                {
                    textBox9.Visible = true;
                    textBox9.Text = val.ToString();

                }
                

            }

            else
            {
                roastedpork.Checked = false;
                textBox9.Visible = false;

            }
        }

        private void beefrouladen_CheckedChanged(object sender, EventArgs e)
        {
            if (beefrouladen.Checked)
            {
                beefrouladen.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox10.Visible = false;
                    beefrouladen.Checked = false;
                }
                else
                {
                    textBox10.Visible = true;
                    textBox10.Text = val.ToString();

                }
                

            }

            else
            {
                beefrouladen.Checked = false;
                textBox10.Visible = false;
            }
        }

        private void pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (pasta.Checked)
            {
                pasta.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox11.Visible = false;
                    pasta.Checked = false;
                }
                else
                {
                    textBox11.Visible = true;
                    textBox11.Text = val.ToString();
                }
            }

            else
            {
                pasta.Checked = false;
                textBox11.Visible = false;
            }

        }

        private void dessert1_CheckedChanged(object sender, EventArgs e)
        {
            if (dessert1.Checked)
            {
                dessert1.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox12.Visible = false;
                    dessert1.Checked = false;
                }
                else
                {
                    textBox12.Visible = true;
                    textBox12.Text = val.ToString();

                }
                

            }

            else
            {
                dessert1.Checked = false;
                textBox12.Visible = false;
            }
        }

        private void dessert2_CheckedChanged(object sender, EventArgs e)
        {
            if (dessert2.Checked)
            {
                dessert2.Checked = true;
                String val = checkForValidQuantity();
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox13.Visible = false;
                    dessert2.Checked = false;
                }
                else
                {
                    textBox13.Visible = true;
                    textBox13.Text = val.ToString();

                }               

            }

            else
            {
                dessert2.Checked = false;
                textBox13.Visible = false;
            }
        }

        private void dessert3_CheckedChanged(object sender, EventArgs e)
        {
            if (dessert3.Checked)
            {
                dessert3.Checked = true;
                String val = checkForValidQuantity();                
                int.TryParse(val, out int zeroval);
                if (val == "" | zeroval == 0)
                {
                    textBox14.Visible = false;
                    dessert3.Checked = false;
                }
                else
                {
                    textBox14.Visible = true;
                    textBox14.Text = val.ToString();

                }
                

            }

            else
            {
                dessert3.Checked = false;
                textBox14.Visible = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double total ;       
                   

            total = (num1 * 3) + (num2 * 4) + (num3 * 6) + (num4 * 4) + (num5 * 5) + (num6 * 2) + (num7 * 7) + (num8 * 9) + (num9 * 8) + (num10 * 7) + (num11 * 4) + (num12 * 3) + (num13 * 4);
            
            textBox1.Text = Convert.ToString(total);            
        }


        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox2.Text);
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox3.Text);

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            num3 = int.Parse(textBox4.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            num4 = int.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            num5 = int.Parse(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            num6 = int.Parse(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            num7 = int.Parse(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            num8 = int.Parse(textBox9.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            num9 = int.Parse(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            num10 = int.Parse(textBox11.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            num11 = int.Parse(textBox12.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            num12 = int.Parse(textBox13.Text);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            num13 = int.Parse(textBox14.Text);
        }

        
    }
}
