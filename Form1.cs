using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {

            // reset Groups
            gbCrustType.Enabled = true;
            gbPizzaSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            // reset Size
            rbSmall.Checked = true;

            // reset Toppings
            chkCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            // reset Crust Type
            rbThin.Checked = true;

            // reset Where To Eat
            rbEatIn.Checked = true;

            // reset Order Button
            btnOrderPizza.Enabled = true;
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblChoiceWhereToEat.Text = "Eat In";
            }
            else
            {
                lblChoiceWhereToEat.Text = "Take Out";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkCheese.Checked)
            {
                sToppings = "Cheese";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onions";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblChoiceToppings.Text = sToppings;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblChoiceCrustType.Text = "Thin";
                return;
            }

            if (rbThick.Checked)
            {
                lblChoiceCrustType.Text = "Thick";
                return;
            }
        }

        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }

        float CalclulateToppingsPrice()
        {
            float totalPrice = 0;

            if (chkCheese.Checked)
            {
                totalPrice += Convert.ToSingle(chkCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                totalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                totalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked)
            {
                totalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                totalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                totalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return totalPrice;
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalclulateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblChoiceTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblChoiceSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblChoiceSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblChoiceSize.Text = "Large";
                return;
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
                UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
                UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
                UpdateSize();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
                UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
                UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
                UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
                UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Odrer Placed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbCrustType.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
