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
            this.txtBoxPremium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBoxNoOfDrivers = new System.Windows.Forms.TextBox();
            this.lblNoOfDrivers = new System.Windows.Forms.Label();
            this.txtBoxOcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDriverNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxClaim1 = new System.Windows.Forms.TextBox();
            this.txtBoxClaim2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxClaim3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxClaim5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxClaim4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(249, 252);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(61, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            this.txtBoxName.Leave += new System.EventHandler(this.txtBoxName_Leave);
            // 
            // txtBoxDOB
            // 
            this.txtBoxDOB.Location = new System.Drawing.Point(249, 304);
            this.txtBoxDOB.Name = "txtBoxDOB";
            this.txtBoxDOB.Size = new System.Drawing.Size(61, 20);
            this.txtBoxDOB.TabIndex = 2;
            this.txtBoxDOB.TextChanged += new System.EventHandler(this.txtBoxDOB_TextChanged);
            this.txtBoxDOB.Leave += new System.EventHandler(this.txtBoxDOB_Leave);
            // 
            // txtBoxPolicy
            // 
            this.txtBoxPolicy.Location = new System.Drawing.Point(249, 99);
            this.txtBoxPolicy.Name = "txtBoxPolicy";
            this.txtBoxPolicy.Size = new System.Drawing.Size(72, 20);
            this.txtBoxPolicy.TabIndex = 3;
            this.txtBoxPolicy.TextChanged += new System.EventHandler(this.txtBoxPolicy_TextChanged);
            this.txtBoxPolicy.Leave += new System.EventHandler(this.txtBoxPolicy_Leave);
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
            this.labelPolicy.Location = new System.Drawing.Point(22, 101);
            this.labelPolicy.Name = "labelPolicy";
            this.labelPolicy.Size = new System.Drawing.Size(171, 13);
            this.labelPolicy.TabIndex = 7;
            this.labelPolicy.Text = "Please Enter The Policy Start Date";
            // 
            // txtBoxPremium
            // 
            this.txtBoxPremium.Location = new System.Drawing.Point(339, 386);
            this.txtBoxPremium.Name = "txtBoxPremium";
            this.txtBoxPremium.Size = new System.Drawing.Size(54, 20);
            this.txtBoxPremium.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "£";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(411, 386);
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
            this.txtBoxNoOfDrivers.Size = new System.Drawing.Size(26, 20);
            this.txtBoxNoOfDrivers.TabIndex = 12;
            this.txtBoxNoOfDrivers.TextChanged += new System.EventHandler(this.txtBoxNoOfDrivers_TextChanged);
            this.txtBoxNoOfDrivers.Leave += new System.EventHandler(this.txtBoxNoOfDrivers_Leave);
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
            this.txtBoxOcc.Leave += new System.EventHandler(this.txtBoxOcc_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Driver No:";
            // 
            // txtBoxDriverNo
            // 
            this.txtBoxDriverNo.Location = new System.Drawing.Point(75, 227);
            this.txtBoxDriverNo.Name = "txtBoxDriverNo";
            this.txtBoxDriverNo.Size = new System.Drawing.Size(21, 20);
            this.txtBoxDriverNo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Insurance Premium Calculation";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(241, 345);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 35);
            this.btnEnter.TabIndex = 23;
            this.btnEnter.Text = "Add Next Driver";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date of Claim";
            // 
            // txtBoxClaim1
            // 
            this.txtBoxClaim1.Location = new System.Drawing.Point(507, 249);
            this.txtBoxClaim1.Name = "txtBoxClaim1";
            this.txtBoxClaim1.Size = new System.Drawing.Size(74, 20);
            this.txtBoxClaim1.TabIndex = 25;
            this.txtBoxClaim1.Leave += new System.EventHandler(this.txtBoxClaim1_Leave);
            // 
            // txtBoxClaim2
            // 
            this.txtBoxClaim2.Location = new System.Drawing.Point(507, 278);
            this.txtBoxClaim2.Name = "txtBoxClaim2";
            this.txtBoxClaim2.Size = new System.Drawing.Size(74, 20);
            this.txtBoxClaim2.TabIndex = 27;
            this.txtBoxClaim2.Leave += new System.EventHandler(this.txtBoxClaim2_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date of Claim";
            // 
            // txtBoxClaim3
            // 
            this.txtBoxClaim3.Location = new System.Drawing.Point(507, 304);
            this.txtBoxClaim3.Name = "txtBoxClaim3";
            this.txtBoxClaim3.Size = new System.Drawing.Size(74, 20);
            this.txtBoxClaim3.TabIndex = 29;
            this.txtBoxClaim3.Leave += new System.EventHandler(this.txtBoxClaim3_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date of Claim";
            // 
            // txtBoxClaim5
            // 
            this.txtBoxClaim5.Location = new System.Drawing.Point(693, 278);
            this.txtBoxClaim5.Name = "txtBoxClaim5";
            this.txtBoxClaim5.Size = new System.Drawing.Size(74, 20);
            this.txtBoxClaim5.TabIndex = 31;
            this.txtBoxClaim5.Leave += new System.EventHandler(this.txtBoxClaim5_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date of Claim";
            // 
            // txtBoxClaim4
            // 
            this.txtBoxClaim4.Location = new System.Drawing.Point(693, 252);
            this.txtBoxClaim4.Name = "txtBoxClaim4";
            this.txtBoxClaim4.Size = new System.Drawing.Size(74, 20);
            this.txtBoxClaim4.TabIndex = 33;
            this.txtBoxClaim4.Leave += new System.EventHandler(this.txtBoxClaim4_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Date of Claim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Premium";
            // 
            // TechAppForm
            // 
            this.ClientSize = new System.Drawing.Size(794, 435);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxClaim4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxClaim5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxClaim3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxClaim2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxClaim1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDriverNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxOcc);
            this.Controls.Add(this.lblNoOfDrivers);
            this.Controls.Add(this.txtBoxNoOfDrivers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPremium);
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
        private System.Windows.Forms.TextBox txtBoxPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBoxNoOfDrivers;
        private System.Windows.Forms.Label lblNoOfDrivers;
        private System.Windows.Forms.TextBox txtBoxOcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDriverNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxClaim1;
        private System.Windows.Forms.TextBox txtBoxClaim2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxClaim3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxClaim5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxClaim4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}