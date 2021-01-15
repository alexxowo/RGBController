namespace Controlador_RGB
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.AlexxTitle = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StateLevel_lb = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Connection_btn = new System.Windows.Forms.Button();
            this.ComPorts = new System.Windows.Forms.ComboBox();
            this.ColorView = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Red_Controller = new System.Windows.Forms.TrackBar();
            this.Blue_Controller = new System.Windows.Forms.TrackBar();
            this.Green_Controller = new System.Windows.Forms.TrackBar();
            this.BackgroundIconNot = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PresetsColor = new System.Windows.Forms.ComboBox();
            this.SaveColorBtn = new System.Windows.Forms.Button();
            this.TitlePNG = new System.Windows.Forms.PictureBox();
            this.Shape = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.ComProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Red_Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape)).BeginInit();
            this.SuspendLayout();
            // 
            // AlexxTitle
            // 
            this.AlexxTitle.AutoSize = true;
            this.AlexxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.AlexxTitle.Font = new System.Drawing.Font("FROSTBITE Wide", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlexxTitle.ForeColor = System.Drawing.Color.White;
            this.AlexxTitle.Location = new System.Drawing.Point(595, 24);
            this.AlexxTitle.Name = "AlexxTitle";
            this.AlexxTitle.Size = new System.Drawing.Size(198, 30);
            this.AlexxTitle.TabIndex = 3;
            this.AlexxTitle.Text = "ALEXX";
            this.AlexxTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.ByLabel.Font = new System.Drawing.Font("FROSTBITE Wide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByLabel.ForeColor = System.Drawing.Color.White;
            this.ByLabel.Location = new System.Drawing.Point(550, 24);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(39, 13);
            this.ByLabel.TabIndex = 4;
            this.ByLabel.Text = "By:";
            this.ByLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "RED:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(55, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "GREEN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(127, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "BLUE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "STATE:";
            // 
            // StateLevel_lb
            // 
            this.StateLevel_lb.AutoSize = true;
            this.StateLevel_lb.ForeColor = System.Drawing.Color.Crimson;
            this.StateLevel_lb.Location = new System.Drawing.Point(65, 255);
            this.StateLevel_lb.Name = "StateLevel_lb";
            this.StateLevel_lb.Size = new System.Drawing.Size(116, 21);
            this.StateLevel_lb.TabIndex = 13;
            this.StateLevel_lb.Text = "DISCONNECT";
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(835, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(34, 31);
            this.Close_btn.TabIndex = 14;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Location = new System.Drawing.Point(795, 0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(34, 31);
            this.Minimize_btn.TabIndex = 15;
            this.Minimize_btn.Text = "_";
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Connection_btn
            // 
            this.Connection_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.Connection_btn.FlatAppearance.BorderSize = 0;
            this.Connection_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connection_btn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_btn.Location = new System.Drawing.Point(196, 279);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.Size = new System.Drawing.Size(121, 29);
            this.Connection_btn.TabIndex = 16;
            this.Connection_btn.Text = "OPEN";
            this.Connection_btn.UseVisualStyleBackColor = false;
            this.Connection_btn.Click += new System.EventHandler(this.Connection_Btn_Click);
            // 
            // ComPorts
            // 
            this.ComPorts.BackColor = System.Drawing.Color.White;
            this.ComPorts.FormattingEnabled = true;
            this.ComPorts.Location = new System.Drawing.Point(69, 279);
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(121, 29);
            this.ComPorts.TabIndex = 17;
            // 
            // ColorView
            // 
            this.ColorView.BackColor = System.Drawing.Color.Black;
            this.ColorView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorView.Location = new System.Drawing.Point(600, 112);
            this.ColorView.Name = "ColorView";
            this.ColorView.Size = new System.Drawing.Size(250, 224);
            this.ColorView.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "PORT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "PREVIEW";
            // 
            // Red_Controller
            // 
            this.Red_Controller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Red_Controller.Enabled = false;
            this.Red_Controller.Location = new System.Drawing.Point(16, 107);
            this.Red_Controller.Maximum = 255;
            this.Red_Controller.Name = "Red_Controller";
            this.Red_Controller.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Red_Controller.Size = new System.Drawing.Size(45, 104);
            this.Red_Controller.TabIndex = 21;
            this.Red_Controller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Red_Controller.ValueChanged += new System.EventHandler(this.getValues);
            // 
            // Blue_Controller
            // 
            this.Blue_Controller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blue_Controller.Enabled = false;
            this.Blue_Controller.Location = new System.Drawing.Point(151, 110);
            this.Blue_Controller.Maximum = 255;
            this.Blue_Controller.Name = "Blue_Controller";
            this.Blue_Controller.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Blue_Controller.Size = new System.Drawing.Size(45, 104);
            this.Blue_Controller.TabIndex = 23;
            this.Blue_Controller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Blue_Controller.ValueChanged += new System.EventHandler(this.getValues);
            // 
            // Green_Controller
            // 
            this.Green_Controller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Green_Controller.Enabled = false;
            this.Green_Controller.Location = new System.Drawing.Point(78, 107);
            this.Green_Controller.Maximum = 255;
            this.Green_Controller.Name = "Green_Controller";
            this.Green_Controller.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Green_Controller.Size = new System.Drawing.Size(45, 104);
            this.Green_Controller.TabIndex = 24;
            this.Green_Controller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Green_Controller.ValueChanged += new System.EventHandler(this.getValues);
            // 
            // BackgroundIconNot
            // 
            this.BackgroundIconNot.Icon = ((System.Drawing.Icon)(resources.GetObject("BackgroundIconNot.Icon")));
            this.BackgroundIconNot.Text = "Controlador RGB";
            this.BackgroundIconNot.Visible = true;
            this.BackgroundIconNot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackgroundIconNot_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 10);
            this.panel1.TabIndex = 29;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PresetsColor
            // 
            this.PresetsColor.FormattingEnabled = true;
            this.PresetsColor.Location = new System.Drawing.Point(216, 106);
            this.PresetsColor.Name = "PresetsColor";
            this.PresetsColor.Size = new System.Drawing.Size(148, 29);
            this.PresetsColor.TabIndex = 30;
            this.PresetsColor.SelectedIndexChanged += new System.EventHandler(this.PresetsColor_SelectedIndexChanged);
            // 
            // SaveColorBtn
            // 
            this.SaveColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(111)))));
            this.SaveColorBtn.FlatAppearance.BorderSize = 0;
            this.SaveColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveColorBtn.Location = new System.Drawing.Point(216, 145);
            this.SaveColorBtn.Name = "SaveColorBtn";
            this.SaveColorBtn.Size = new System.Drawing.Size(148, 37);
            this.SaveColorBtn.TabIndex = 31;
            this.SaveColorBtn.Text = "SAVE";
            this.SaveColorBtn.UseVisualStyleBackColor = false;
            this.SaveColorBtn.Click += new System.EventHandler(this.SaveColorBtn_Click);
            // 
            // TitlePNG
            // 
            this.TitlePNG.Image = global::Controlador_RGB.Properties.Resources.TITLE;
            this.TitlePNG.Location = new System.Drawing.Point(0, 4);
            this.TitlePNG.Name = "TitlePNG";
            this.TitlePNG.Size = new System.Drawing.Size(433, 62);
            this.TitlePNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePNG.TabIndex = 2;
            this.TitlePNG.TabStop = false;
            this.TitlePNG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // Shape
            // 
            this.Shape.Dock = System.Windows.Forms.DockStyle.Top;
            this.Shape.Image = global::Controlador_RGB.Properties.Resources.Shape2;
            this.Shape.Location = new System.Drawing.Point(0, 0);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(872, 66);
            this.Shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shape.TabIndex = 1;
            this.Shape.TabStop = false;
            this.Shape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "PRESET:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.Crimson;
            this.redLabel.Location = new System.Drawing.Point(12, 214);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(37, 21);
            this.redLabel.TabIndex = 34;
            this.redLabel.Text = "255";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.GreenLabel.Location = new System.Drawing.Point(74, 214);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(37, 21);
            this.GreenLabel.TabIndex = 35;
            this.GreenLabel.Text = "255";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BlueLabel.Location = new System.Drawing.Point(140, 214);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(37, 21);
            this.BlueLabel.TabIndex = 36;
            this.BlueLabel.Text = "255";
            // 
            // ComProgress
            // 
            this.ComProgress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ComProgress.Location = new System.Drawing.Point(11, 314);
            this.ComProgress.Name = "ComProgress";
            this.ComProgress.Size = new System.Drawing.Size(306, 22);
            this.ComProgress.TabIndex = 37;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(872, 375);
            this.Controls.Add(this.ComProgress);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveColorBtn);
            this.Controls.Add(this.PresetsColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Green_Controller);
            this.Controls.Add(this.Blue_Controller);
            this.Controls.Add(this.Red_Controller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ColorView);
            this.Controls.Add(this.ComPorts);
            this.Controls.Add(this.Connection_btn);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.StateLevel_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ByLabel);
            this.Controls.Add(this.AlexxTitle);
            this.Controls.Add(this.TitlePNG);
            this.Controls.Add(this.Shape);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Controlador By ALEXX";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            ((System.ComponentModel.ISupportInitialize)(this.Red_Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Shape;
        private System.Windows.Forms.PictureBox TitlePNG;
        private System.Windows.Forms.Label AlexxTitle;
        private System.Windows.Forms.Label ByLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StateLevel_lb;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Connection_btn;
        private System.Windows.Forms.ComboBox ComPorts;
        private System.Windows.Forms.Panel ColorView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Red_Controller;
        private System.Windows.Forms.TrackBar Blue_Controller;
        private System.Windows.Forms.TrackBar Green_Controller;
        private System.Windows.Forms.NotifyIcon BackgroundIconNot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox PresetsColor;
        private System.Windows.Forms.Button SaveColorBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.ProgressBar ComProgress;
    }
}

