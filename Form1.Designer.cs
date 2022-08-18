namespace CirclePerimeter
{
    partial class CirclePer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbperimeter = new System.Windows.Forms.TextBox();
            this.tbradius = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbradius);
            this.groupBox1.Controls.Add(this.tbperimeter);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perimeter of a circle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your radius?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "input answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbperimeter
            // 
            this.tbperimeter.Location = new System.Drawing.Point(234, 259);
            this.tbperimeter.Name = "tbperimeter";
            this.tbperimeter.Size = new System.Drawing.Size(100, 26);
            this.tbperimeter.TabIndex = 2;
            this.tbperimeter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbradius
            // 
            this.tbradius.Location = new System.Drawing.Point(234, 55);
            this.tbradius.Name = "tbradius";
            this.tbradius.Size = new System.Drawing.Size(100, 26);
            this.tbradius.TabIndex = 3;
            // 
            // CirclePer
            // 
            this.ClientSize = new System.Drawing.Size(554, 437);
            this.Controls.Add(this.groupBox1);
            this.Name = "CirclePer";
            this.Load += new System.EventHandler(this.CirclePer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbradius;
        private System.Windows.Forms.TextBox tbperimeter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

