namespace trekanter
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
            this.storeA = new System.Windows.Forms.TextBox();
            this.storeB = new System.Windows.Forms.TextBox();
            this.storeC = new System.Windows.Forms.TextBox();
            this.lilleA = new System.Windows.Forms.TextBox();
            this.lilleB = new System.Windows.Forms.TextBox();
            this.lilleC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.consoleOut = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.storeAudregn = new System.Windows.Forms.TextBox();
            this.storeBudregn = new System.Windows.Forms.TextBox();
            this.storeCudregn = new System.Windows.Forms.TextBox();
            this.lilleAudregn = new System.Windows.Forms.TextBox();
            this.lilleBudregn = new System.Windows.Forms.TextBox();
            this.lilleCudregn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // storeA
            // 
            this.storeA.Location = new System.Drawing.Point(30, 12);
            this.storeA.Name = "storeA";
            this.storeA.Size = new System.Drawing.Size(100, 20);
            this.storeA.TabIndex = 0;
            this.storeA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // storeB
            // 
            this.storeB.Location = new System.Drawing.Point(30, 38);
            this.storeB.Name = "storeB";
            this.storeB.Size = new System.Drawing.Size(100, 20);
            this.storeB.TabIndex = 1;
            this.storeB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // storeC
            // 
            this.storeC.Location = new System.Drawing.Point(30, 64);
            this.storeC.Name = "storeC";
            this.storeC.Size = new System.Drawing.Size(100, 20);
            this.storeC.TabIndex = 2;
            this.storeC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lilleA
            // 
            this.lilleA.Location = new System.Drawing.Point(30, 90);
            this.lilleA.Name = "lilleA";
            this.lilleA.Size = new System.Drawing.Size(100, 20);
            this.lilleA.TabIndex = 3;
            this.lilleA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lilleB
            // 
            this.lilleB.Location = new System.Drawing.Point(30, 116);
            this.lilleB.Name = "lilleB";
            this.lilleB.Size = new System.Drawing.Size(100, 20);
            this.lilleB.TabIndex = 4;
            this.lilleB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lilleC
            // 
            this.lilleC.Location = new System.Drawing.Point(30, 142);
            this.lilleC.Name = "lilleC";
            this.lilleC.Size = new System.Drawing.Size(100, 20);
            this.lilleC.TabIndex = 5;
            this.lilleC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "b:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "c:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Udregn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consoleOut
            // 
            this.consoleOut.Location = new System.Drawing.Point(439, 38);
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.Size = new System.Drawing.Size(100, 20);
            this.consoleOut.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(439, 171);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Nulstil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // storeAudregn
            // 
            this.storeAudregn.Location = new System.Drawing.Point(136, 12);
            this.storeAudregn.Name = "storeAudregn";
            this.storeAudregn.Size = new System.Drawing.Size(239, 20);
            this.storeAudregn.TabIndex = 16;
            // 
            // storeBudregn
            // 
            this.storeBudregn.Location = new System.Drawing.Point(136, 38);
            this.storeBudregn.Name = "storeBudregn";
            this.storeBudregn.Size = new System.Drawing.Size(239, 20);
            this.storeBudregn.TabIndex = 17;
            // 
            // storeCudregn
            // 
            this.storeCudregn.Location = new System.Drawing.Point(136, 64);
            this.storeCudregn.Name = "storeCudregn";
            this.storeCudregn.Size = new System.Drawing.Size(239, 20);
            this.storeCudregn.TabIndex = 18;
            // 
            // lilleAudregn
            // 
            this.lilleAudregn.Location = new System.Drawing.Point(136, 90);
            this.lilleAudregn.Name = "lilleAudregn";
            this.lilleAudregn.Size = new System.Drawing.Size(239, 20);
            this.lilleAudregn.TabIndex = 19;
            // 
            // lilleBudregn
            // 
            this.lilleBudregn.Location = new System.Drawing.Point(136, 116);
            this.lilleBudregn.Name = "lilleBudregn";
            this.lilleBudregn.Size = new System.Drawing.Size(239, 20);
            this.lilleBudregn.TabIndex = 20;
            // 
            // lilleCudregn
            // 
            this.lilleCudregn.Location = new System.Drawing.Point(136, 142);
            this.lilleCudregn.Name = "lilleCudregn";
            this.lilleCudregn.Size = new System.Drawing.Size(239, 20);
            this.lilleCudregn.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.lilleCudregn);
            this.Controls.Add(this.lilleBudregn);
            this.Controls.Add(this.lilleAudregn);
            this.Controls.Add(this.storeCudregn);
            this.Controls.Add(this.storeBudregn);
            this.Controls.Add(this.storeAudregn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.consoleOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lilleC);
            this.Controls.Add(this.lilleB);
            this.Controls.Add(this.lilleA);
            this.Controls.Add(this.storeC);
            this.Controls.Add(this.storeB);
            this.Controls.Add(this.storeA);
            this.Name = "Form1";
            this.Text = "Trekantudregner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storeA;
        private System.Windows.Forms.TextBox storeB;
        private System.Windows.Forms.TextBox storeC;
        private System.Windows.Forms.TextBox lilleA;
        private System.Windows.Forms.TextBox lilleB;
        private System.Windows.Forms.TextBox lilleC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox consoleOut;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox storeAudregn;
        private System.Windows.Forms.TextBox storeBudregn;
        private System.Windows.Forms.TextBox storeCudregn;
        private System.Windows.Forms.TextBox lilleAudregn;
        private System.Windows.Forms.TextBox lilleBudregn;
        private System.Windows.Forms.TextBox lilleCudregn;

    }
}

