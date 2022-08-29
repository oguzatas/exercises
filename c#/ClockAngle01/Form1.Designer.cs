
namespace ClockAngle01
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.usevoicecheckbox = new System.Windows.Forms.CheckBox();
            this.textboxrealsec = new System.Windows.Forms.TextBox();
            this.realtimecheckbox = new System.Windows.Forms.CheckBox();
            this.textboxrealmin = new System.Windows.Forms.TextBox();
            this.txtboxrealhour = new System.Windows.Forms.TextBox();
            this.textboxhour = new System.Windows.Forms.TextBox();
            this.textboxmin = new System.Windows.Forms.TextBox();
            this.textboxsec = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(763, 38);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(154, 40);
            this.updatebutton.TabIndex = 1;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // usevoicecheckbox
            // 
            this.usevoicecheckbox.AutoSize = true;
            this.usevoicecheckbox.Location = new System.Drawing.Point(846, 497);
            this.usevoicecheckbox.Name = "usevoicecheckbox";
            this.usevoicecheckbox.Size = new System.Drawing.Size(94, 21);
            this.usevoicecheckbox.TabIndex = 6;
            this.usevoicecheckbox.Text = "Use Voice";
            this.usevoicecheckbox.UseVisualStyleBackColor = true;
            // 
            // textboxrealsec
            // 
            this.textboxrealsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxrealsec.Location = new System.Drawing.Point(157, 474);
            this.textboxrealsec.Multiline = true;
            this.textboxrealsec.Name = "textboxrealsec";
            this.textboxrealsec.ReadOnly = true;
            this.textboxrealsec.Size = new System.Drawing.Size(67, 44);
            this.textboxrealsec.TabIndex = 9;
            this.textboxrealsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxrealsec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // realtimecheckbox
            // 
            this.realtimecheckbox.AutoSize = true;
            this.realtimecheckbox.Location = new System.Drawing.Point(329, 456);
            this.realtimecheckbox.Name = "realtimecheckbox";
            this.realtimecheckbox.Size = new System.Drawing.Size(123, 21);
            this.realtimecheckbox.TabIndex = 10;
            this.realtimecheckbox.Text = "Use Real Time";
            this.realtimecheckbox.UseVisualStyleBackColor = true;
            this.realtimecheckbox.CheckedChanged += new System.EventHandler(this.realtimecheckbox_CheckedChanged);
            this.realtimecheckbox.CheckStateChanged += new System.EventHandler(this.realtimecheckbox_CheckStateChanged);
            this.realtimecheckbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.realtimecheckbox_MouseClick);
            // 
            // textboxrealmin
            // 
            this.textboxrealmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxrealmin.Location = new System.Drawing.Point(84, 474);
            this.textboxrealmin.Multiline = true;
            this.textboxrealmin.Name = "textboxrealmin";
            this.textboxrealmin.ReadOnly = true;
            this.textboxrealmin.Size = new System.Drawing.Size(67, 44);
            this.textboxrealmin.TabIndex = 12;
            this.textboxrealmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxrealmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txtboxrealhour
            // 
            this.txtboxrealhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxrealhour.Location = new System.Drawing.Point(11, 474);
            this.txtboxrealhour.Multiline = true;
            this.txtboxrealhour.Name = "txtboxrealhour";
            this.txtboxrealhour.ReadOnly = true;
            this.txtboxrealhour.Size = new System.Drawing.Size(67, 44);
            this.txtboxrealhour.TabIndex = 13;
            this.txtboxrealhour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxrealhour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textboxhour
            // 
            this.textboxhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxhour.Location = new System.Drawing.Point(527, 34);
            this.textboxhour.MaxLength = 2;
            this.textboxhour.Multiline = true;
            this.textboxhour.Name = "textboxhour";
            this.textboxhour.Size = new System.Drawing.Size(67, 44);
            this.textboxhour.TabIndex = 14;
            this.textboxhour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxhour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textboxmin
            // 
            this.textboxmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxmin.Location = new System.Drawing.Point(600, 34);
            this.textboxmin.MaxLength = 2;
            this.textboxmin.Multiline = true;
            this.textboxmin.Name = "textboxmin";
            this.textboxmin.Size = new System.Drawing.Size(67, 44);
            this.textboxmin.TabIndex = 15;
            this.textboxmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textboxsec
            // 
            this.textboxsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxsec.Location = new System.Drawing.Point(673, 34);
            this.textboxsec.MaxLength = 2;
            this.textboxsec.Multiline = true;
            this.textboxsec.Name = "textboxsec";
            this.textboxsec.Size = new System.Drawing.Size(67, 44);
            this.textboxsec.TabIndex = 16;
            this.textboxsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxsec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(611, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(235, 30);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(611, 176);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(235, 30);
            this.textBox8.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(495, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Angle 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(495, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Angle 2";
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(490, 250);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.ReadOnly = true;
            this.txtcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcontent.Size = new System.Drawing.Size(426, 224);
            this.txtcontent.TabIndex = 21;
            this.txtcontent.Text = "                                                       ---Event Log---";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(490, 486);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 40);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(673, 485);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(154, 40);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textboxsec);
            this.Controls.Add(this.textboxmin);
            this.Controls.Add(this.textboxhour);
            this.Controls.Add(this.txtboxrealhour);
            this.Controls.Add(this.textboxrealmin);
            this.Controls.Add(this.realtimecheckbox);
            this.Controls.Add(this.textboxrealsec);
            this.Controls.Add(this.usevoicecheckbox);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock Angle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.CheckBox usevoicecheckbox;
        private System.Windows.Forms.TextBox textboxrealsec;
        private System.Windows.Forms.CheckBox realtimecheckbox;
        private System.Windows.Forms.TextBox textboxrealmin;
        private System.Windows.Forms.TextBox txtboxrealhour;
        private System.Windows.Forms.TextBox textboxhour;
        private System.Windows.Forms.TextBox textboxmin;
        private System.Windows.Forms.TextBox textboxsec;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
    }
}

