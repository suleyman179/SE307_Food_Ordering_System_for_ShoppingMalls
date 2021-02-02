using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class KFC : UserControl
    {
        double price_food1 = 26;
        double price_food2 = 16;
        double price_food3 = 21;
        double price_food4 = 25.5;
        double price_food5 = 22.99;
        double price_drink1 = 4;
        double price_drink2 = 6;
        double price_drink3 = 5;
        double price_drink4 = 3;
        double price_drink5 = 4.99;
        double price_extra1 = 7.99;
        double price_extra2 = 5.5;
        double price_extra3 = 3;
        double price_extra4 = 5;
        double price_extra5 = 4;

        public KFC()
        {
            InitializeComponent();

            foodPrice1.Text = Convert.ToString(price_food1);
            foodPrice2.Text = Convert.ToString(price_food2);
            foodPrice3.Text = Convert.ToString(price_food3);
            foodPrice4.Text = Convert.ToString(price_food4);
            foodPrice5.Text = Convert.ToString(price_food5);

            drinkPrice1.Text = Convert.ToString(price_drink1);
            drinkPrice2.Text = Convert.ToString(price_drink2);
            drinkPrice3.Text = Convert.ToString(price_drink3);
            drinkPrice4.Text = Convert.ToString(price_drink4);
            drinkPrice5.Text = Convert.ToString(price_drink5);

            extraPrice1.Text = Convert.ToString(price_extra1);
            extraPrice2.Text = Convert.ToString(price_extra2);
            extraPrice3.Text = Convert.ToString(price_extra3);
            extraPrice4.Text = Convert.ToString(price_extra4);
            extraPrice5.Text = Convert.ToString(price_extra5);

            changePrice1.Text = foodPrice1.Text;
            changePrice2.Text = foodPrice2.Text;
            changePrice3.Text = foodPrice3.Text;
            changePrice4.Text = foodPrice4.Text;
            changePrice5.Text = foodPrice5.Text;
            changePrice6.Text = drinkPrice1.Text;
            changePrice7.Text = drinkPrice2.Text;
            changePrice8.Text = drinkPrice3.Text;
            changePrice9.Text = drinkPrice4.Text;
            changePrice10.Text = drinkPrice5.Text;
            changePrice11.Text = extraPrice1.Text;
            changePrice12.Text = extraPrice2.Text;
            changePrice13.Text = extraPrice3.Text;
            changePrice14.Text = extraPrice4.Text;
            changePrice15.Text = extraPrice5.Text;

            adminPassword.PasswordChar = '*';

        }


        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;

                    else
                        func(control.Controls);
            };
        }


        private void foodBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBox1.Checked == true)
            {
                txtFood1.Enabled = true;
                txtFood1.Text = "";
                txtFood1.Focus();
            }
            else
            {
                txtFood1.Enabled = false;
                txtFood1.Text = "0";
            }
        }

        private void foodBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBox1.Checked == true)
            {
                txtFood1.Enabled = true;
                txtFood1.Text = "";
                txtFood1.Focus();
            }
            else
            {
                txtFood1.Enabled = false;
                txtFood1.Text = "0";
            }
        }

        private void foodBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBox1.Checked == true)
            {
                txtFood1.Enabled = true;
                txtFood1.Text = "";
                txtFood1.Focus();
            }
            else
            {
                txtFood1.Enabled = false;
                txtFood1.Text = "0";
            }
        }

        private void foodBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBox1.Checked == true)
            {
                txtFood1.Enabled = true;
                txtFood1.Text = "";
                txtFood1.Focus();
            }
            else
            {
                txtFood1.Enabled = false;
                txtFood1.Text = "0";
            }
        }

        private void foodBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBox1.Checked == true)
            {
                txtFood1.Enabled = true;
                txtFood1.Text = "";
                txtFood1.Focus();
            }
            else
            {
                txtFood1.Enabled = false;
                txtFood1.Text = "0";
            }
        }

        private void drinkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkBox1.Checked == true)
            {
                txtDrink1.Enabled = true;
                txtDrink1.Text = "";
                txtDrink1.Focus();
            }
            else
            {
                txtDrink1.Enabled = false;
                txtDrink1.Text = "0";
            }
        }

        private void drinkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkBox2.Checked == true)
            {
                txtDrink2.Enabled = true;
                txtDrink2.Text = "";
                txtDrink2.Focus();
            }
            else
            {
                txtDrink2.Enabled = false;
                txtDrink2.Text = "0";
            }
        }

        private void drinkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkBox3.Checked == true)
            {
                txtDrink3.Enabled = true;
                txtDrink3.Text = "";
                txtDrink3.Focus();
            }
            else
            {
                txtDrink3.Enabled = false;
                txtDrink3.Text = "0";
            }
        }

        private void drinkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkBox4.Checked == true)
            {
                txtDrink4.Enabled = true;
                txtDrink4.Text = "";
                txtDrink4.Focus();
            }
            else
            {
                txtDrink4.Enabled = false;
                txtDrink4.Text = "0";
            }
        }

        private void drinkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkBox5.Checked == true)
            {
                txtDrink5.Enabled = true;
                txtDrink5.Text = "";
                txtDrink5.Focus();
            }
            else
            {
                txtDrink5.Enabled = false;
                txtDrink5.Text = "0";
            }
        }

        private void extraBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (extraBox1.Checked == true)
            {
                txtExtra1.Enabled = true;
                txtExtra1.Text = "";
                txtExtra1.Focus();
            }
            else
            {
                txtExtra1.Enabled = false;
                txtExtra1.Text = "0";
            }
        }

        private void extraBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (extraBox2.Checked == true)
            {
                txtExtra2.Enabled = true;
                txtExtra2.Text = "";
                txtExtra2.Focus();
            }
            else
            {
                txtExtra2.Enabled = false;
                txtExtra2.Text = "0";
            }
        }

        private void extraBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (extraBox3.Checked == true)
            {
                txtExtra3.Enabled = true;
                txtExtra3.Text = "";
                txtExtra3.Focus();
            }
            else
            {
                txtExtra3.Enabled = false;
                txtExtra3.Text = "0";
            }
        }

        private void extraBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (extraBox4.Checked == true)
            {
                txtExtra4.Enabled = true;
                txtExtra4.Text = "";
                txtExtra4.Focus();
            }
            else
            {
                txtExtra4.Enabled = false;
                txtExtra4.Text = "0";
            }
        }

        private void extraBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (extraBox5.Checked == true)
            {
                txtExtra5.Enabled = true;
                txtExtra5.Text = "";
                txtExtra5.Focus();
            }
            else
            {
                txtExtra5.Enabled = false;
                txtExtra5.Text = "0";
            }
        }

        private void txtFood1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFood2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFood3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFood4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFood5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDrink1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDrink2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDrink3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDrink4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDrink5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExtra1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExtra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExtra3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExtra4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExtra5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void changePrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void changePrice15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (txtFood1.Text != "" && txtFood2.Text != "" && txtFood3.Text != "" && txtFood4.Text != "" && txtFood5.Text != "" && txtDrink1.Text != "" && txtDrink2.Text != ""
                 && txtDrink3.Text != "" && txtDrink4.Text != "" && txtDrink5.Text != "" && txtExtra1.Text != "" && txtExtra2.Text != "" && txtExtra3.Text != "" && txtExtra4.Text != ""
                  && txtExtra5.Text != "")
            {
                double[] itemcost = new double[100];
                itemcost[0] = Convert.ToDouble(txtFood1.Text) * price_food1;
                itemcost[2] = Convert.ToDouble(txtFood2.Text) * price_food2;
                itemcost[3] = Convert.ToDouble(txtFood3.Text) * price_food3;
                itemcost[4] = Convert.ToDouble(txtFood4.Text) * price_food4;
                itemcost[5] = Convert.ToDouble(txtFood5.Text) * price_food5;
                itemcost[6] = Convert.ToDouble(txtDrink1.Text) * price_drink1;
                itemcost[7] = Convert.ToDouble(txtDrink2.Text) * price_drink2;
                itemcost[8] = Convert.ToDouble(txtDrink3.Text) * price_drink3;
                itemcost[9] = Convert.ToDouble(txtDrink4.Text) * price_drink4;
                itemcost[10] = Convert.ToDouble(txtDrink5.Text) * price_drink5;
                itemcost[11] = Convert.ToDouble(txtExtra1.Text) * price_extra1;
                itemcost[12] = Convert.ToDouble(txtExtra2.Text) * price_extra2;
                itemcost[13] = Convert.ToDouble(txtExtra3.Text) * price_extra3;
                itemcost[14] = Convert.ToDouble(txtExtra4.Text) * price_extra4;
                itemcost[15] = Convert.ToDouble(txtExtra5.Text) * price_extra5;

                double total;
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11]
                        + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15];

                totalPrice.Text = Convert.ToString(total);
            }

            else
            {
                MessageBox.Show("Please do not empty 'Quantity' values");
            }
        }

        private void openLoginScreen_Click(object sender, EventArgs e)
        {
            admin.Visible = true;
            password.Visible = true;
            adminLogin.Visible = true;
            adminPassword.Visible = true;
            loginButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void closeLoginScreen_Click(object sender, EventArgs e)
        {
            closeLoginScreen.Visible = false;
            openLoginScreen.Visible = true;
            savePrice.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            adminLogin.Clear();
            adminPassword.Clear();
            changePrice1.Visible = false;
            changePrice2.Visible = false;
            changePrice3.Visible = false;
            changePrice4.Visible = false;
            changePrice5.Visible = false;
            changePrice6.Visible = false;
            changePrice7.Visible = false;
            changePrice8.Visible = false;
            changePrice9.Visible = false;
            changePrice10.Visible = false;
            changePrice11.Visible = false;
            changePrice12.Visible = false;
            changePrice13.Visible = false;
            changePrice14.Visible = false;
            changePrice15.Visible = false;

            MessageBox.Show("Succesfully Logout.");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminLogin.Text == "admin" && adminPassword.Text == "admin")
            {
                MessageBox.Show("Succesfully Login!");

                savePrice.Visible = true;
                admin.Visible = false;
                password.Visible = false;
                adminLogin.Visible = false;
                adminPassword.Visible = false;
                loginButton.Visible = false;
                cancelButton.Visible = false;
                openLoginScreen.Visible = false;
                closeLoginScreen.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                changePrice1.Visible = true;
                changePrice2.Visible = true;
                changePrice3.Visible = true;
                changePrice4.Visible = true;
                changePrice5.Visible = true;
                changePrice6.Visible = true;
                changePrice7.Visible = true;
                changePrice8.Visible = true;
                changePrice9.Visible = true;
                changePrice10.Visible = true;
                changePrice11.Visible = true;
                changePrice12.Visible = true;
                changePrice13.Visible = true;
                changePrice14.Visible = true;
                changePrice15.Visible = true;


            }

            else
            {
                MessageBox.Show("Wrong Username or Password.\nPlease try again.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            admin.Visible = false;
            password.Visible = false;
            adminLogin.Visible = false;
            adminPassword.Visible = false;
            loginButton.Visible = false;
            cancelButton.Visible = false;
            adminLogin.Clear();
            adminPassword.Clear();
        }

        private void savePrice_Click(object sender, EventArgs e)
        {
            if (changePrice1.Text != "" && changePrice2.Text != "" && changePrice3.Text != "" && changePrice4.Text != "" && changePrice5.Text != "" && changePrice6.Text != ""
                 && changePrice7.Text != "" && changePrice8.Text != "" && changePrice9.Text != "" && changePrice10.Text != "" && changePrice11.Text != "" && changePrice12.Text != ""
                  && changePrice13.Text != "" && changePrice14.Text != "" && changePrice15.Text != "")
            {
                foodPrice1.Text = changePrice1.Text;
                price_food1 = Convert.ToDouble(changePrice1.Text);
                foodPrice2.Text = changePrice2.Text;
                price_food2 = Convert.ToDouble(changePrice2.Text);
                foodPrice3.Text = changePrice3.Text;
                price_food3 = Convert.ToDouble(changePrice3.Text);
                foodPrice4.Text = changePrice4.Text;
                price_food4 = Convert.ToDouble(changePrice4.Text);
                foodPrice5.Text = changePrice5.Text;
                price_food5 = Convert.ToDouble(changePrice5.Text);

                drinkPrice1.Text = changePrice6.Text;
                price_drink1 = Convert.ToDouble(changePrice6.Text);
                drinkPrice2.Text = changePrice7.Text;
                price_drink2 = Convert.ToDouble(changePrice7.Text);
                drinkPrice3.Text = changePrice8.Text;
                price_drink3 = Convert.ToDouble(changePrice8.Text);
                drinkPrice4.Text = changePrice9.Text;
                price_drink4 = Convert.ToDouble(changePrice9.Text);
                drinkPrice5.Text = changePrice10.Text;
                price_drink5 = Convert.ToDouble(changePrice10.Text);

                extraPrice1.Text = changePrice11.Text;
                price_extra1 = Convert.ToDouble(changePrice11.Text);
                extraPrice2.Text = changePrice12.Text;
                price_extra2 = Convert.ToDouble(changePrice12.Text);
                extraPrice3.Text = changePrice13.Text;
                price_extra3 = Convert.ToDouble(changePrice13.Text);
                extraPrice4.Text = changePrice14.Text;
                price_extra4 = Convert.ToDouble(changePrice14.Text);
                extraPrice5.Text = changePrice15.Text;
                price_extra5 = Convert.ToDouble(changePrice15.Text);

                MessageBox.Show("Prices Saved !");
            }

            else
            {
                MessageBox.Show("Please fill the price values. (EMPTY VALUES)");
            }
        }

        
    }
}
