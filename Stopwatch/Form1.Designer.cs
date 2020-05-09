namespace Stopwatch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblmiliseconds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblseconds = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblminutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblhours = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 146);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "TM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stopwatch.Properties.Resources.Stop_watch;
            this.pictureBox1.Location = new System.Drawing.Point(35, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Watch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.btnstop);
            this.panel2.Controls.Add(this.btnstart);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 278);
            this.panel2.TabIndex = 1;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(365, 191);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(122, 59);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnstop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnstop.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(196, 191);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(122, 59);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnstart.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(26, 191);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(122, 59);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.lblmiliseconds);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblseconds);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblminutes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblhours);
            this.panel3.Location = new System.Drawing.Point(26, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 93);
            this.panel3.TabIndex = 0;
            // 
            // lblmiliseconds
            // 
            this.lblmiliseconds.AutoSize = true;
            this.lblmiliseconds.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiliseconds.Location = new System.Drawing.Point(370, 20);
            this.lblmiliseconds.Name = "lblmiliseconds";
            this.lblmiliseconds.Size = new System.Drawing.Size(67, 54);
            this.lblmiliseconds.TabIndex = 6;
            this.lblmiliseconds.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 54);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            // 
            // lblseconds
            // 
            this.lblseconds.AutoSize = true;
            this.lblseconds.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseconds.Location = new System.Drawing.Point(258, 20);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(67, 54);
            this.lblseconds.TabIndex = 4;
            this.lblseconds.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 54);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutes.Location = new System.Drawing.Point(146, 20);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(67, 54);
            this.lblminutes.TabIndex = 2;
            this.lblminutes.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(34, 20);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(67, 54);
            this.lblhours.TabIndex = 0;
            this.lblhours.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblmiliseconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Timer timer1;
    }
}

