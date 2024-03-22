namespace FormPrac
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserN = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserM = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UserP = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.output2 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.output1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter Your Name Here";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserN
            // 
            this.UserN.AutoSize = true;
            this.UserN.BackColor = System.Drawing.Color.Transparent;
            this.UserN.ForeColor = System.Drawing.SystemColors.Info;
            this.UserN.Location = new System.Drawing.Point(422, 110);
            this.UserN.Name = "UserN";
            this.UserN.Size = new System.Drawing.Size(112, 16);
            this.UserN.TabIndex = 2;
            this.UserN.Text = "Enter Your Name:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Cursor = System.Windows.Forms.Cursors.No;
            this.label.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Info;
            this.label.Location = new System.Drawing.Point(194, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(990, 55);
            this.label.TabIndex = 3;
            this.label.Text = "MY FIRST WEBSITE DEMO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Enter Your Mail Here";
            // 
            // UserM
            // 
            this.UserM.AutoSize = true;
            this.UserM.BackColor = System.Drawing.Color.Transparent;
            this.UserM.ForeColor = System.Drawing.SystemColors.Info;
            this.UserM.Location = new System.Drawing.Point(422, 175);
            this.UserM.Name = "UserM";
            this.UserM.Size = new System.Drawing.Size(100, 16);
            this.UserM.TabIndex = 5;
            this.UserM.Text = "Enter Your mail:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(600, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Enter Your Password Here";
            // 
            // UserP
            // 
            this.UserP.AutoSize = true;
            this.UserP.BackColor = System.Drawing.Color.Transparent;
            this.UserP.ForeColor = System.Drawing.SystemColors.Info;
            this.UserP.Location = new System.Drawing.Point(422, 239);
            this.UserP.Name = "UserP";
            this.UserP.Size = new System.Drawing.Size(135, 16);
            this.UserP.TabIndex = 7;
            this.UserP.Text = "Enter Your Password:";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(425, 305);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(469, 34);
            this.button.TabIndex = 8;
            this.button.Text = "SUBMIT";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.BackColor = System.Drawing.Color.Transparent;
            this.output2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.output2.Location = new System.Drawing.Point(963, 172);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(0, 16);
            this.output2.TabIndex = 9;
            // 
            // output3
            // 
            this.output3.AutoSize = true;
            this.output3.BackColor = System.Drawing.Color.Transparent;
            this.output3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.output3.Location = new System.Drawing.Point(963, 245);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(0, 16);
            this.output3.TabIndex = 10;
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.BackColor = System.Drawing.Color.Transparent;
            this.output1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.output1.Location = new System.Drawing.Point(963, 107);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(0, 16);
            this.output1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1372, 485);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.UserP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.UserM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.UserN);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label UserN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label UserM;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label UserP;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.Label output1;
    }
}

