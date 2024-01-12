namespace ElecTest.FormsConfig
{
    partial class NodeConfig
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
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Tarjeta = new System.Windows.Forms.ComboBox();
            this.CB_Puertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChB_Off = new System.Windows.Forms.CheckBox();
            this.ChB_ON = new System.Windows.Forms.CheckBox();
            this.CB_Paridad = new System.Windows.Forms.ComboBox();
            this.LB_PA = new System.Windows.Forms.Label();
            this.CB_Bits = new System.Windows.Forms.ComboBox();
            this.LB_DB = new System.Windows.Forms.Label();
            this.CB_SB = new System.Windows.Forms.ComboBox();
            this.LB_SB = new System.Windows.Forms.Label();
            this.CB_Polarity = new System.Windows.Forms.ComboBox();
            this.LB_Pol = new System.Windows.Forms.Label();
            this.CB_baudios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_BAU = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_conect = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Guardar = new System.Windows.Forms.PictureBox();
            this.TB_NOMBRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarjeta";
            // 
            // CB_Tarjeta
            // 
            this.CB_Tarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tarjeta.FormattingEnabled = true;
            this.CB_Tarjeta.Items.AddRange(new object[] {
            "Arduino/Pic",
            "Raspberry Pico",
            "DAQ"});
            this.CB_Tarjeta.Location = new System.Drawing.Point(92, 11);
            this.CB_Tarjeta.Name = "CB_Tarjeta";
            this.CB_Tarjeta.Size = new System.Drawing.Size(123, 28);
            this.CB_Tarjeta.TabIndex = 5;
            this.CB_Tarjeta.SelectedIndexChanged += new System.EventHandler(this.CB_Tarjeta_SelectedIndexChanged);
            // 
            // CB_Puertos
            // 
            this.CB_Puertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Puertos.FormattingEnabled = true;
            this.CB_Puertos.Location = new System.Drawing.Point(80, 21);
            this.CB_Puertos.Name = "CB_Puertos";
            this.CB_Puertos.Size = new System.Drawing.Size(143, 24);
            this.CB_Puertos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puerto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChB_Off);
            this.groupBox1.Controls.Add(this.ChB_ON);
            this.groupBox1.Controls.Add(this.CB_Paridad);
            this.groupBox1.Controls.Add(this.LB_PA);
            this.groupBox1.Controls.Add(this.CB_Bits);
            this.groupBox1.Controls.Add(this.LB_DB);
            this.groupBox1.Controls.Add(this.CB_SB);
            this.groupBox1.Controls.Add(this.LB_SB);
            this.groupBox1.Controls.Add(this.CB_Polarity);
            this.groupBox1.Controls.Add(this.LB_Pol);
            this.groupBox1.Controls.Add(this.CB_baudios);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LB_BAU);
            this.groupBox1.Controls.Add(this.CB_Puertos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de nodo";
            // 
            // ChB_Off
            // 
            this.ChB_Off.AutoSize = true;
            this.ChB_Off.Location = new System.Drawing.Point(180, 46);
            this.ChB_Off.Name = "ChB_Off";
            this.ChB_Off.Size = new System.Drawing.Size(42, 20);
            this.ChB_Off.TabIndex = 18;
            this.ChB_Off.Text = "Off";
            this.ChB_Off.UseVisualStyleBackColor = true;
            this.ChB_Off.CheckedChanged += new System.EventHandler(this.ChB_Off_CheckedChanged);
            // 
            // ChB_ON
            // 
            this.ChB_ON.AutoSize = true;
            this.ChB_ON.Location = new System.Drawing.Point(131, 46);
            this.ChB_ON.Name = "ChB_ON";
            this.ChB_ON.Size = new System.Drawing.Size(43, 20);
            this.ChB_ON.TabIndex = 18;
            this.ChB_ON.Text = "On";
            this.ChB_ON.UseVisualStyleBackColor = true;
            this.ChB_ON.CheckedChanged += new System.EventHandler(this.ChB_ON_CheckedChanged);
            // 
            // CB_Paridad
            // 
            this.CB_Paridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Paridad.FormattingEnabled = true;
            this.CB_Paridad.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Mark",
            "Even",
            "Space"});
            this.CB_Paridad.Location = new System.Drawing.Point(108, 194);
            this.CB_Paridad.Name = "CB_Paridad";
            this.CB_Paridad.Size = new System.Drawing.Size(114, 24);
            this.CB_Paridad.TabIndex = 17;
            // 
            // LB_PA
            // 
            this.LB_PA.AutoSize = true;
            this.LB_PA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_PA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PA.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_PA.Location = new System.Drawing.Point(8, 201);
            this.LB_PA.Name = "LB_PA";
            this.LB_PA.Size = new System.Drawing.Size(53, 17);
            this.LB_PA.TabIndex = 16;
            this.LB_PA.Text = "Paridad";
            // 
            // CB_Bits
            // 
            this.CB_Bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Bits.FormattingEnabled = true;
            this.CB_Bits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CB_Bits.Location = new System.Drawing.Point(108, 164);
            this.CB_Bits.Name = "CB_Bits";
            this.CB_Bits.Size = new System.Drawing.Size(114, 24);
            this.CB_Bits.TabIndex = 15;
            // 
            // LB_DB
            // 
            this.LB_DB.AutoSize = true;
            this.LB_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_DB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DB.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_DB.Location = new System.Drawing.Point(8, 171);
            this.LB_DB.Name = "LB_DB";
            this.LB_DB.Size = new System.Drawing.Size(60, 17);
            this.LB_DB.TabIndex = 14;
            this.LB_DB.Text = "Data bits";
            // 
            // CB_SB
            // 
            this.CB_SB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SB.FormattingEnabled = true;
            this.CB_SB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.CB_SB.Location = new System.Drawing.Point(108, 134);
            this.CB_SB.Name = "CB_SB";
            this.CB_SB.Size = new System.Drawing.Size(114, 24);
            this.CB_SB.TabIndex = 13;
            // 
            // LB_SB
            // 
            this.LB_SB.AutoSize = true;
            this.LB_SB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_SB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SB.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_SB.Location = new System.Drawing.Point(8, 141);
            this.LB_SB.Name = "LB_SB";
            this.LB_SB.Size = new System.Drawing.Size(60, 17);
            this.LB_SB.TabIndex = 12;
            this.LB_SB.Text = "Stop bits";
            // 
            // CB_Polarity
            // 
            this.CB_Polarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Polarity.FormattingEnabled = true;
            this.CB_Polarity.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.CB_Polarity.Location = new System.Drawing.Point(108, 104);
            this.CB_Polarity.Name = "CB_Polarity";
            this.CB_Polarity.Size = new System.Drawing.Size(114, 24);
            this.CB_Polarity.TabIndex = 10;
            // 
            // LB_Pol
            // 
            this.LB_Pol.AutoSize = true;
            this.LB_Pol.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_Pol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Pol.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_Pol.Location = new System.Drawing.Point(8, 111);
            this.LB_Pol.Name = "LB_Pol";
            this.LB_Pol.Size = new System.Drawing.Size(64, 17);
            this.LB_Pol.TabIndex = 8;
            this.LB_Pol.Text = "Polaridad";
            // 
            // CB_baudios
            // 
            this.CB_baudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_baudios.FormattingEnabled = true;
            this.CB_baudios.Items.AddRange(new object[] {
            "50",
            "110",
            "150",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            ""});
            this.CB_baudios.Location = new System.Drawing.Point(108, 74);
            this.CB_baudios.Name = "CB_baudios";
            this.CB_baudios.Size = new System.Drawing.Size(114, 24);
            this.CB_baudios.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estado";
            // 
            // LB_BAU
            // 
            this.LB_BAU.AutoSize = true;
            this.LB_BAU.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LB_BAU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BAU.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_BAU.Location = new System.Drawing.Point(8, 81);
            this.LB_BAU.Name = "LB_BAU";
            this.LB_BAU.Size = new System.Drawing.Size(54, 17);
            this.LB_BAU.TabIndex = 9;
            this.LB_BAU.Text = "Baudios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_conect);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(252, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nodo";
            // 
            // BTN_conect
            // 
            this.BTN_conect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_conect.Location = new System.Drawing.Point(6, 16);
            this.BTN_conect.Name = "BTN_conect";
            this.BTN_conect.Size = new System.Drawing.Size(75, 23);
            this.BTN_conect.TabIndex = 6;
            this.BTN_conect.Text = "Conectar";
            this.BTN_conect.UseVisualStyleBackColor = true;
            this.BTN_conect.Click += new System.EventHandler(this.BTN_conect_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ElecTest.Properties.Resources.apagar;
            this.pictureBox2.Location = new System.Drawing.Point(15, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.Image = global::ElecTest.Properties.Resources.verificado;
            this.Btn_Guardar.Location = new System.Drawing.Point(291, 230);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(48, 43);
            this.Btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Guardar.TabIndex = 10;
            this.Btn_Guardar.TabStop = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // TB_NOMBRE
            // 
            this.TB_NOMBRE.Location = new System.Drawing.Point(252, 176);
            this.TB_NOMBRE.Name = "TB_NOMBRE";
            this.TB_NOMBRE.Size = new System.Drawing.Size(87, 20);
            this.TB_NOMBRE.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(249, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // NodeConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(374, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_NOMBRE);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CB_Tarjeta);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NodeConfig";
            this.Text = "NodeConfig";
            this.Load += new System.EventHandler(this.NodeConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Tarjeta;
        private System.Windows.Forms.ComboBox CB_Puertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_BAU;
        private System.Windows.Forms.Label LB_PA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_conect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Btn_Guardar;
        private System.Windows.Forms.CheckBox ChB_Off;
        private System.Windows.Forms.CheckBox ChB_ON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Paridad;
        private System.Windows.Forms.ComboBox CB_Bits;
        private System.Windows.Forms.Label LB_DB;
        private System.Windows.Forms.ComboBox CB_SB;
        private System.Windows.Forms.Label LB_SB;
        private System.Windows.Forms.ComboBox CB_Polarity;
        private System.Windows.Forms.Label LB_Pol;
        private System.Windows.Forms.ComboBox CB_baudios;
        private System.Windows.Forms.TextBox TB_NOMBRE;
        private System.Windows.Forms.Label label4;
    }
}