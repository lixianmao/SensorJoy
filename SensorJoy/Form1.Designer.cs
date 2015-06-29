namespace SensorJoy
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
            //关闭串口
            portHelper.close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.body1 = new System.Windows.Forms.Label();
            this.head1 = new System.Windows.Forms.Label();
            this.arrow1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.body2 = new System.Windows.Forms.Label();
            this.head2 = new System.Windows.Forms.Label();
            this.arrow2 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.bluetooth = new System.Windows.Forms.Button();
            this.myname = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.Parity = System.IO.Ports.Parity.Odd;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SensorJoy.Properties.Resources.whitepanel2;
            this.panel1.Controls.Add(this.body1);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.arrow1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 92);
            this.panel1.TabIndex = 14;
            // 
            // body1
            // 
            this.body1.BackColor = System.Drawing.Color.Transparent;
            this.body1.Font = new System.Drawing.Font("FZYaoTi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.body1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.body1.Location = new System.Drawing.Point(3, 39);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(243, 41);
            this.body1.TabIndex = 7;
            this.body1.Text = "游戏操作：左右转动控制方向，前推进行喷气";
            // 
            // head1
            // 
            this.head1.AutoSize = true;
            this.head1.BackColor = System.Drawing.Color.Transparent;
            this.head1.Font = new System.Drawing.Font("STXingkai", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.head1.ForeColor = System.Drawing.Color.Teal;
            this.head1.Location = new System.Drawing.Point(8, 10);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(94, 21);
            this.head1.TabIndex = 6;
            this.head1.Text = "极品赛车";
            // 
            // arrow1
            // 
            this.arrow1.BackColor = System.Drawing.Color.Transparent;
            this.arrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arrow1.FlatAppearance.BorderSize = 0;
            this.arrow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.arrow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrow1.ForeColor = System.Drawing.Color.Transparent;
            this.arrow1.Image = global::SensorJoy.Properties.Resources.arrow;
            this.arrow1.Location = new System.Drawing.Point(258, 20);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(50, 50);
            this.arrow1.TabIndex = 5;
            this.arrow1.UseVisualStyleBackColor = false;
            this.arrow1.Click += new System.EventHandler(this.arrow1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SensorJoy.Properties.Resources.whitepanel2;
            this.panel2.Controls.Add(this.body2);
            this.panel2.Controls.Add(this.head2);
            this.panel2.Controls.Add(this.arrow2);
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 92);
            this.panel2.TabIndex = 15;
            // 
            // body2
            // 
            this.body2.BackColor = System.Drawing.Color.Transparent;
            this.body2.Font = new System.Drawing.Font("FZYaoTi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.body2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.body2.Location = new System.Drawing.Point(3, 41);
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(243, 36);
            this.body2.TabIndex = 8;
            this.body2.Text = "游戏操作：左右转动控制方向，前推进行换挡，上拉进行刹车或松开刹车";
            // 
            // head2
            // 
            this.head2.AutoSize = true;
            this.head2.BackColor = System.Drawing.Color.Transparent;
            this.head2.Font = new System.Drawing.Font("STXingkai", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.head2.ForeColor = System.Drawing.Color.Teal;
            this.head2.Location = new System.Drawing.Point(10, 10);
            this.head2.Name = "head2";
            this.head2.Size = new System.Drawing.Size(94, 21);
            this.head2.TabIndex = 7;
            this.head2.Text = "速度生活";
            // 
            // arrow2
            // 
            this.arrow2.BackColor = System.Drawing.Color.Transparent;
            this.arrow2.FlatAppearance.BorderSize = 0;
            this.arrow2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.arrow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrow2.ForeColor = System.Drawing.Color.Transparent;
            this.arrow2.Image = global::SensorJoy.Properties.Resources.arrow;
            this.arrow2.Location = new System.Drawing.Point(258, 23);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(50, 50);
            this.arrow2.TabIndex = 4;
            this.arrow2.UseVisualStyleBackColor = false;
            this.arrow2.Click += new System.EventHandler(this.arrow2_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::SensorJoy.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(277, 20);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 31);
            this.minimize.TabIndex = 16;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::SensorJoy.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(304, 20);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 31);
            this.exit.TabIndex = 17;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bluetooth
            // 
            this.bluetooth.BackColor = System.Drawing.Color.Transparent;
            this.bluetooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluetooth.FlatAppearance.BorderSize = 0;
            this.bluetooth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bluetooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluetooth.ForeColor = System.Drawing.Color.Transparent;
            this.bluetooth.Image = global::SensorJoy.Properties.Resources.bluetooth2;
            this.bluetooth.Location = new System.Drawing.Point(248, 20);
            this.bluetooth.Name = "bluetooth";
            this.bluetooth.Size = new System.Drawing.Size(25, 31);
            this.bluetooth.TabIndex = 18;
            this.bluetooth.UseVisualStyleBackColor = false;
            this.bluetooth.Visible = false;
            this.bluetooth.Click += new System.EventHandler(this.bluetooth_Click);
            // 
            // myname
            // 
            this.myname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myname.Image = global::SensorJoy.Properties.Resources.myname;
            this.myname.Location = new System.Drawing.Point(10, 12);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(150, 36);
            this.myname.TabIndex = 19;
            this.myname.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SensorJoy.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(340, 470);
            this.Controls.Add(this.myname);
            this.Controls.Add(this.bluetooth);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SensorJoy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button arrow2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button bluetooth;
        private System.Windows.Forms.Button arrow1;
        private System.Windows.Forms.Button myname;
        private System.Windows.Forms.Label head1;
        private System.Windows.Forms.Label body1;
        private System.Windows.Forms.Label body2;
        private System.Windows.Forms.Label head2;
        
    }
}

