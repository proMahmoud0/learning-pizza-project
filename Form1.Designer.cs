namespace Pizza_Project
{
    partial class PizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblChoiceSize = new System.Windows.Forms.Label();
            this.lblChoiceToppings = new System.Windows.Forms.Label();
            this.lblChoiceCrustType = new System.Windows.Forms.Label();
            this.lblChoiceWhereToEat = new System.Windows.Forms.Label();
            this.lblChoiceTotalPrice = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbPizzaSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MineCrafter 3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1067, 122);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Make Your Pizza";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 542);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 437);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(39, 23);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(59, 20);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(39, 55);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(73, 20);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.Tag = "15";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(39, 87);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(60, 20);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.AutoSize = true;
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Location = new System.Drawing.Point(61, 148);
            this.gbPizzaSize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPizzaSize.Size = new System.Drawing.Size(151, 130);
            this.gbPizzaSize.TabIndex = 4;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(39, 23);
            this.rbThin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(51, 20);
            this.rbThin.TabIndex = 4;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(39, 55);
            this.rbThick.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(58, 20);
            this.rbThick.TabIndex = 5;
            this.rbThick.Tag = "5";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.AutoSize = true;
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Location = new System.Drawing.Point(61, 307);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbCrustType.Size = new System.Drawing.Size(151, 98);
            this.gbCrustType.TabIndex = 7;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(37, 23);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(73, 20);
            this.chkCheese.TabIndex = 8;
            this.chkCheese.Tag = "2";
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(37, 55);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(96, 20);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(37, 87);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(88, 20);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Tag = "2";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(194, 23);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(61, 20);
            this.chkOnion.TabIndex = 11;
            this.chkOnion.Tag = "2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(194, 55);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(64, 20);
            this.chkOlives.TabIndex = 12;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(194, 87);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.chkGreenPeppers.TabIndex = 13;
            this.chkGreenPeppers.Tag = "2";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.AutoSize = true;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkCheese);
            this.gbToppings.Location = new System.Drawing.Point(260, 148);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbToppings.Size = new System.Drawing.Size(347, 130);
            this.gbToppings.TabIndex = 7;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(39, 23);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(58, 20);
            this.rbEatIn.TabIndex = 4;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(194, 23);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(80, 20);
            this.rbTakeOut.TabIndex = 5;
            this.rbTakeOut.Tag = "";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.AutoSize = true;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(260, 307);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbWhereToEat.Size = new System.Drawing.Size(347, 66);
            this.gbWhereToEat.TabIndex = 8;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(37, 26);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(37, 57);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(63, 13);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(37, 128);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(72, 13);
            this.lblCrustType.TabIndex = 2;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(37, 158);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(90, 13);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "Where To Eat:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(37, 189);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(73, 13);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblChoiceSize
            // 
            this.lblChoiceSize.AutoSize = true;
            this.lblChoiceSize.Location = new System.Drawing.Point(82, 26);
            this.lblChoiceSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoiceSize.Name = "lblChoiceSize";
            this.lblChoiceSize.Size = new System.Drawing.Size(30, 16);
            this.lblChoiceSize.TabIndex = 5;
            this.lblChoiceSize.Text = "N/A";
            // 
            // lblChoiceToppings
            // 
            this.lblChoiceToppings.Location = new System.Drawing.Point(67, 78);
            this.lblChoiceToppings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoiceToppings.Name = "lblChoiceToppings";
            this.lblChoiceToppings.Size = new System.Drawing.Size(243, 44);
            this.lblChoiceToppings.TabIndex = 6;
            this.lblChoiceToppings.Text = "No Toppings";
            // 
            // lblChoiceCrustType
            // 
            this.lblChoiceCrustType.AutoSize = true;
            this.lblChoiceCrustType.Location = new System.Drawing.Point(131, 128);
            this.lblChoiceCrustType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoiceCrustType.Name = "lblChoiceCrustType";
            this.lblChoiceCrustType.Size = new System.Drawing.Size(30, 16);
            this.lblChoiceCrustType.TabIndex = 7;
            this.lblChoiceCrustType.Text = "N/A";
            // 
            // lblChoiceWhereToEat
            // 
            this.lblChoiceWhereToEat.AutoSize = true;
            this.lblChoiceWhereToEat.Location = new System.Drawing.Point(155, 158);
            this.lblChoiceWhereToEat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoiceWhereToEat.Name = "lblChoiceWhereToEat";
            this.lblChoiceWhereToEat.Size = new System.Drawing.Size(30, 16);
            this.lblChoiceWhereToEat.TabIndex = 8;
            this.lblChoiceWhereToEat.Text = "N/A";
            // 
            // lblChoiceTotalPrice
            // 
            this.lblChoiceTotalPrice.AutoSize = true;
            this.lblChoiceTotalPrice.Font = new System.Drawing.Font("Orbitron", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoiceTotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblChoiceTotalPrice.Location = new System.Drawing.Point(152, 214);
            this.lblChoiceTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoiceTotalPrice.Name = "lblChoiceTotalPrice";
            this.lblChoiceTotalPrice.Size = new System.Drawing.Size(41, 40);
            this.lblChoiceTotalPrice.TabIndex = 9;
            this.lblChoiceTotalPrice.Text = "$";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.AutoSize = true;
            this.gbOrderSummary.Controls.Add(this.lblChoiceTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblChoiceWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblChoiceCrustType);
            this.gbOrderSummary.Controls.Add(this.lblChoiceToppings);
            this.gbOrderSummary.Controls.Add(this.lblChoiceSize);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Location = new System.Drawing.Point(655, 148);
            this.gbOrderSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbOrderSummary.Size = new System.Drawing.Size(347, 285);
            this.gbOrderSummary.TabIndex = 14;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.AutoSize = true;
            this.btnOrderPizza.Location = new System.Drawing.Point(656, 463);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(141, 52);
            this.btnOrderPizza.TabIndex = 15;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.AutoSize = true;
            this.btnResetForm.Location = new System.Drawing.Point(862, 463);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(141, 52);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "PizzaOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblChoiceSize;
        private System.Windows.Forms.Label lblChoiceToppings;
        private System.Windows.Forms.Label lblChoiceCrustType;
        private System.Windows.Forms.Label lblChoiceWhereToEat;
        private System.Windows.Forms.Label lblChoiceTotalPrice;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
    }
}

