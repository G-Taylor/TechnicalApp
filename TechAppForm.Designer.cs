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
            this.txtBoxOcc = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 53);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxOcc
            // 
            this.txtBoxOcc.Location = new System.Drawing.Point(12, 80);
            this.txtBoxOcc.Name = "txtBoxOcc";
            this.txtBoxOcc.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOcc.TabIndex = 1;
            this.txtBoxOcc.TextChanged += new System.EventHandler(this.txtBoxOcc_TextChanged);
            // 
            // txtBoxDOB
            // 
            this.txtBoxDOB.Location = new System.Drawing.Point(12, 106);
            this.txtBoxDOB.Name = "txtBoxDOB";
            this.txtBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDOB.TabIndex = 2;
            this.txtBoxDOB.TextChanged += new System.EventHandler(this.txtBoxDOB_TextChanged);
            // 
            // txtBoxPolicy
            // 
            this.txtBoxPolicy.Location = new System.Drawing.Point(12, 12);
            this.txtBoxPolicy.Name = "txtBoxPolicy";
            this.txtBoxPolicy.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPolicy.TabIndex = 3;
            this.txtBoxPolicy.TextChanged += new System.EventHandler(this.txtBoxPolicy_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(133, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Please Enter Driver Name";
            // 
            // labelOcc
            // 
            this.labelOcc.AutoSize = true;
            this.labelOcc.Location = new System.Drawing.Point(133, 83);
            this.labelOcc.Name = "labelOcc";
            this.labelOcc.Size = new System.Drawing.Size(178, 13);
            this.labelOcc.TabIndex = 5;
            this.labelOcc.Text = "Please Enter The Driver Occupation";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(133, 109);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(146, 13);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Please Enter The Driver DOB";
            // 
            // labelPolicy
            // 
            this.labelPolicy.AutoSize = true;
            this.labelPolicy.Location = new System.Drawing.Point(133, 15);
            this.labelPolicy.Name = "labelPolicy";
            this.labelPolicy.Size = new System.Drawing.Size(171, 13);
            this.labelPolicy.TabIndex = 7;
            this.labelPolicy.Text = "Please Enter The Policy Start Date";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(136, 156);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 8;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // txtBoxPremium
            // 
            this.txtBoxPremium.Location = new System.Drawing.Point(25, 156);
            this.txtBoxPremium.Name = "txtBoxPremium";
            this.txtBoxPremium.Size = new System.Drawing.Size(54, 20);
            this.txtBoxPremium.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "£";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(229, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TechAppForm
            // 
            this.ClientSize = new System.Drawing.Size(547, 221);
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
            this.Controls.Add(this.txtBoxOcc);
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
        private System.Windows.Forms.TextBox txtBoxOcc;
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
    }
}