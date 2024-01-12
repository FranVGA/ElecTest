namespace ElecTest
{
    partial class UIl
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
            this.combo_users = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RutUsEx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.LogOnBut = new System.Windows.Forms.PictureBox();
            this.btn_Mini = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOnBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_users
            // 
            this.combo_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_users.FormattingEnabled = true;
            this.combo_users.Location = new System.Drawing.Point(291, 196);
            this.combo_users.Name = "combo_users";
            this.combo_users.Size = new System.Drawing.Size(135, 21);
            this.combo_users.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "V0.0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RutUsEx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 254);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ElecTest";
            // 
            // RutUsEx
            // 
            this.RutUsEx.AutoSize = true;
            this.RutUsEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutUsEx.Location = new System.Drawing.Point(6, 30);
            this.RutUsEx.Name = "RutUsEx";
            this.RutUsEx.Size = new System.Drawing.Size(0, 13);
            this.RutUsEx.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(290, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(290, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(293, 246);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(133, 20);
            this.tbPass.TabIndex = 33;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // LogOnBut
            // 
            this.LogOnBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOnBut.Image = global::ElecTest.Properties.Resources.entrar;
            this.LogOnBut.Location = new System.Drawing.Point(401, 272);
            this.LogOnBut.Name = "LogOnBut";
            this.LogOnBut.Size = new System.Drawing.Size(25, 25);
            this.LogOnBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogOnBut.TabIndex = 34;
            this.LogOnBut.TabStop = false;
            this.LogOnBut.Click += new System.EventHandler(this.LogOnBut_Click);
            // 
            // btn_Mini
            // 
            this.btn_Mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mini.Image = global::ElecTest.Properties.Resources.minimizar;
            this.btn_Mini.Location = new System.Drawing.Point(390, 12);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(15, 15);
            this.btn_Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Mini.TabIndex = 31;
            this.btn_Mini.TabStop = false;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.Image = global::ElecTest.Properties.Resources.cerca;
            this.Btn_Close.Location = new System.Drawing.Point(411, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(15, 15);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 32;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ElecTest.Properties.Resources.nodos;
            this.pictureBox3.Location = new System.Drawing.Point(293, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // UIl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(457, 325);
            this.Controls.Add(this.combo_users);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOnBut);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btn_Mini);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UIl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UIl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UIl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UIl_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOnBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RutUsEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogOnBut;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.PictureBox btn_Mini;
        private System.Windows.Forms.PictureBox Btn_Close;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

