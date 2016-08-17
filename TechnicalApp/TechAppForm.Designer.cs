namespace TechnicalApp
{
    partial class TechAppForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDOB = new System.Windows.Forms.TextBox();
            this.txtBoxPolicy = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOcc = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelPolicy = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.txtBoxPremium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBoxNoOfDrivers = new System.Windows.Forms.TextBox();
            this.lblNoOfDrivers = new System.Windows.Forms.Label();
            this.txtBoxOcc = new System.Windows.Forms.TextBox();
            this.btnCheckDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDriverNo = new System.Windows.Forms.TextBox();
            this.btnCheckDriver = new System.Windows.Forms.Button();
            this.lblClaim = new System.Windows.Forms.Label();
            this.txtBoxClaim = new System.Windows.Forms.TextBox();
            this.btnCheckNoOfDrivers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(249, 252);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(61, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxDOB
            // 
            this.txtBoxDOB.Location = new System.Drawing.Point(249, 304);
            this.txtBoxDOB.Name = "txtBoxDOB";
            this.txtBoxDOB.Size = new System.Drawing.Size(61, 20);
            this.txtBoxDOB.TabIndex = 2;
            this.txtBoxDOB.TextChanged += new System.EventHandler(this.txtBoxDOB_TextChanged);
            // 
            // txtBoxPolicy
            // 
            this.txtBoxPolicy.Location = new System.Drawing.Point(249, 87);
            this.txtBoxPolicy.Name = "txtBoxPolicy";
            this.txtBoxPolicy.Size = new System.Drawing.Size(72, 20);
            this.txtBoxPolicy.TabIndex = 3;
            this.txtBoxPolicy.TextChanged += new System.EventHandler(this.txtBoxPolicy_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 255);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Please Enter Driver Name";
            // 
            // labelOcc
            // 
            this.labelOcc.AutoSize = true;
            this.labelOcc.Location = new System.Drawing.Point(22, 281);
            this.labelOcc.Name = "labelOcc";
            this.labelOcc.Size = new System.Drawing.Size(178, 13);
            this.labelOcc.TabIndex = 5;
            this.labelOcc.Text = "Please Enter The Driver Occupation";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(22, 307);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(146, 13);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Please Enter The Driver DOB";
            // 
            // labelPolicy
            // 
            this.labelPolicy.AutoSize = true;
            this.labelPolicy.Location = new System.Drawing.Point(22, 89);
            this.labelPolicy.Name = "labelPolicy";
            this.labelPolicy.Size = new System.Drawing.Size(171, 13);
            this.labelPolicy.TabIndex = 7;
            this.labelPolicy.Text = "Please Enter The Policy Start Date";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(331, 373);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 8;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // txtBoxPremium
            // 
            this.txtBoxPremium.Location = new System.Drawing.Point(430, 373);
            this.txtBoxPremium.Name = "txtBoxPremium";
            this.txtBoxPremium.Size = new System.Drawing.Size(54, 20);
            this.txtBoxPremium.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "£";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(490, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBoxNoOfDrivers
            // 
            this.txtBoxNoOfDrivers.Location = new System.Drawing.Point(249, 125);
            this.txtBoxNoOfDrivers.Name = "txtBoxNoOfDrivers";
            this.txtBoxNoOfDrivers.Size = new System.Drawing.Size(61, 20);
            this.txtBoxNoOfDrivers.TabIndex = 12;
            this.txtBoxNoOfDrivers.TextChanged += new System.EventHandler(this.txtBoxNoOfDrivers_TextChanged);
            // 
            // lblNoOfDrivers
            // 
            this.lblNoOfDrivers.AutoSize = true;
            this.lblNoOfDrivers.Location = new System.Drawing.Point(22, 130);
            this.lblNoOfDrivers.Name = "lblNoOfDrivers";
            this.lblNoOfDrivers.Size = new System.Drawing.Size(201, 13);
            this.lblNoOfDrivers.TabIndex = 13;
            this.lblNoOfDrivers.Text = "Please Enter Number of Drivers on Policy";
            // 
            // txtBoxOcc
            // 
            this.txtBoxOcc.Location = new System.Drawing.Point(249, 278);
            this.txtBoxOcc.Name = "txtBoxOcc";
            this.txtBoxOcc.Size = new System.Drawing.Size(61, 20);
            this.txtBoxOcc.TabIndex = 14;
            // 
            // btnCheckDate
            // 
            this.btnCheckDate.Location = new System.Drawing.Point(354, 84);
            this.btnCheckDate.Name = "btnCheckDate";
            this.btnCheckDate.Size = new System.Drawing.Size(75, 23);
            this.btnCheckDate.TabIndex = 15;
            this.btnCheckDate.Text = "Check Date";
            this.btnCheckDate.UseVisualStyleBackColor = true;
            this.btnCheckDate.Click += new System.EventHandler(this.btnCheckDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Driver No:";
            // 
            // txtBoxDriverNo
            // 
            this.txtBoxDriverNo.Location = new System.Drawing.Point(233, 224);
            this.txtBoxDriverNo.Name = "txtBoxDriverNo";
            this.txtBoxDriverNo.Size = new System.Drawing.Size(21, 20);
            this.txtBoxDriverNo.TabIndex = 17;
            // 
            // btnCheckDriver
            // 
            this.btnCheckDriver.Location = new System.Drawing.Point(211, 371);
            this.btnCheckDriver.Name = "btnCheckDriver";
            this.btnCheckDriver.Size = new System.Drawing.Size(99, 23);
            this.btnCheckDriver.TabIndex = 18;
            this.btnCheckDriver.Text = "Check Driver";
            this.btnCheckDriver.UseVisualStyleBackColor = true;
            this.btnCheckDriver.Click += new System.EventHandler(this.btnCheckDriver_Click);
            // 
            // lblClaim
            // 
            this.lblClaim.AutoSize = true;
            this.lblClaim.Location = new System.Drawing.Point(22, 330);
            this.lblClaim.Name = "lblClaim";
            this.lblClaim.Size = new System.Drawing.Size(152, 13);
            this.lblClaim.TabIndex = 19;
            this.lblClaim.Text = "Please Enter Number of Cliams";
            // 
            // txtBoxClaim
            // 
            this.txtBoxClaim.Location = new System.Drawing.Point(249, 330);
            this.txtBoxClaim.Name = "txtBoxClaim";
            this.txtBoxClaim.Size = new System.Drawing.Size(61, 20);
            this.txtBoxClaim.TabIndex = 20;
            // 
            // btnCheckNoOfDrivers
            // 
            this.btnCheckNoOfDrivers.Location = new System.Drawing.Point(354, 125);
            this.btnCheckNoOfDrivers.Name = "btnCheckNoOfDrivers";
            this.btnCheckNoOfDrivers.Size = new System.Drawing.Size(119, 35);
            this.btnCheckNoOfDrivers.TabIndex = 21;
            this.btnCheckNoOfDrivers.Text = "Check Number Of Drivers";
            this.btnCheckNoOfDrivers.UseVisualStyleBackColor = true;
            this.btnCheckNoOfDrivers.Click += new System.EventHandler(this.btnCheckDrivers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Insurance Calculation";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 217);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(109, 23);
            this.btnEnter.TabIndex = 23;
            this.btnEnter.Text = "Enter Driver Details";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // TechAppForm
            // 
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckNoOfDrivers);
            this.Controls.Add(this.txtBoxClaim);
            this.Controls.Add(this.lblClaim);
            this.Controls.Add(this.btnCheckDriver);
            this.Controls.Add(this.txtBoxDriverNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckDate);
            this.Controls.Add(this.txtBoxOcc);
            this.Controls.Add(this.lblNoOfDrivers);
            this.Controls.Add(this.txtBoxNoOfDrivers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPremium);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelPolicy);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelOcc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtBoxPolicy);
            this.Controls.Add(this.txtBoxDOB);
            this.Controls.Add(this.txtBoxName);
            this.Name = "TechAppForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOcc;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPolicyDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDOB;
        private System.Windows.Forms.TextBox txtBoxPolicy;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOcc;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelPolicy;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox txtBoxPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBoxNoOfDrivers;
        private System.Windows.Forms.Label lblNoOfDrivers;
        private System.Windows.Forms.TextBox txtBoxOcc;
        private System.Windows.Forms.Button btnCheckDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDriverNo;
        private System.Windows.Forms.Button btnCheckDriver;
        private System.Windows.Forms.Label lblClaim;
        private System.Windows.Forms.TextBox txtBoxClaim;
        private System.Windows.Forms.Button btnCheckNoOfDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
    }
}