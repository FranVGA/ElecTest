namespace ElecTest
{
    partial class SCPICOMMAND
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
            this.com = new System.Windows.Forms.TabPage();
            this.CB_Port = new System.Windows.Forms.ComboBox();
            this.CB_BR = new System.Windows.Forms.ComboBox();
            this.CB_DB = new System.Windows.Forms.ComboBox();
            this.CB_par = new System.Windows.Forms.ComboBox();
            this.CB_SB = new System.Windows.Forms.ComboBox();
            this.CB_HAND = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Transmitir = new System.Windows.Forms.TabPage();
            this.CB_TCom = new System.Windows.Forms.ComboBox();
            this.CB_Com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Par = new System.Windows.Forms.TextBox();
            this.BTN_SaveTX = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TXB_Nombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.com.SuspendLayout();
            this.Transmitir.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // com
            // 
            this.com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.com.Controls.Add(this.label9);
            this.com.Controls.Add(this.label8);
            this.com.Controls.Add(this.label7);
            this.com.Controls.Add(this.label6);
            this.com.Controls.Add(this.label5);
            this.com.Controls.Add(this.label4);
            this.com.Controls.Add(this.CB_HAND);
            this.com.Controls.Add(this.CB_SB);
            this.com.Controls.Add(this.CB_par);
            this.com.Controls.Add(this.CB_DB);
            this.com.Controls.Add(this.CB_BR);
            this.com.Controls.Add(this.CB_Port);
            this.com.Location = new System.Drawing.Point(4, 22);
            this.com.Name = "com";
            this.com.Padding = new System.Windows.Forms.Padding(3);
            this.com.Size = new System.Drawing.Size(331, 191);
            this.com.TabIndex = 3;
            this.com.Text = "Comunicacion";
            // 
            // CB_Port
            // 
            this.CB_Port.FormattingEnabled = true;
            this.CB_Port.Location = new System.Drawing.Point(6, 29);
            this.CB_Port.Name = "CB_Port";
            this.CB_Port.Size = new System.Drawing.Size(100, 21);
            this.CB_Port.TabIndex = 0;
            // 
            // CB_BR
            // 
            this.CB_BR.FormattingEnabled = true;
            this.CB_BR.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CB_BR.Location = new System.Drawing.Point(6, 71);
            this.CB_BR.Name = "CB_BR";
            this.CB_BR.Size = new System.Drawing.Size(100, 21);
            this.CB_BR.TabIndex = 0;
            // 
            // CB_DB
            // 
            this.CB_DB.FormattingEnabled = true;
            this.CB_DB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CB_DB.Location = new System.Drawing.Point(6, 110);
            this.CB_DB.Name = "CB_DB";
            this.CB_DB.Size = new System.Drawing.Size(100, 21);
            this.CB_DB.TabIndex = 0;
            // 
            // CB_par
            // 
            this.CB_par.FormattingEnabled = true;
            this.CB_par.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.CB_par.Location = new System.Drawing.Point(6, 150);
            this.CB_par.Name = "CB_par";
            this.CB_par.Size = new System.Drawing.Size(100, 21);
            this.CB_par.TabIndex = 0;
            // 
            // CB_SB
            // 
            this.CB_SB.FormattingEnabled = true;
            this.CB_SB.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.CB_SB.Location = new System.Drawing.Point(112, 29);
            this.CB_SB.Name = "CB_SB";
            this.CB_SB.Size = new System.Drawing.Size(100, 21);
            this.CB_SB.TabIndex = 0;
            // 
            // CB_HAND
            // 
            this.CB_HAND.FormattingEnabled = true;
            this.CB_HAND.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSendXOnXOff (RTSXOnXOff)",
            "RequestToSend (RTS)"});
            this.CB_HAND.Location = new System.Drawing.Point(112, 71);
            this.CB_HAND.Name = "CB_HAND";
            this.CB_HAND.Size = new System.Drawing.Size(100, 21);
            this.CB_HAND.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Puerto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "BaudRate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DataBits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(112, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "StopBits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(112, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Handshake";
            // 
            // Transmitir
            // 
            this.Transmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Transmitir.Controls.Add(this.TXB_Nombre);
            this.Transmitir.Controls.Add(this.TXB_Par);
            this.Transmitir.Controls.Add(this.label10);
            this.Transmitir.Controls.Add(this.BTN_SaveTX);
            this.Transmitir.Controls.Add(this.label3);
            this.Transmitir.Controls.Add(this.label2);
            this.Transmitir.Controls.Add(this.label11);
            this.Transmitir.Controls.Add(this.label1);
            this.Transmitir.Controls.Add(this.CB_Com);
            this.Transmitir.Controls.Add(this.CB_TCom);
            this.Transmitir.Location = new System.Drawing.Point(4, 22);
            this.Transmitir.Name = "Transmitir";
            this.Transmitir.Padding = new System.Windows.Forms.Padding(3);
            this.Transmitir.Size = new System.Drawing.Size(331, 191);
            this.Transmitir.TabIndex = 0;
            this.Transmitir.Text = "Comandos";
            // 
            // CB_TCom
            // 
            this.CB_TCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TCom.FormattingEnabled = true;
            this.CB_TCom.Items.AddRange(new object[] {
            "Configuración básica",
            "Configuración de medida",
            "Calibracion",
            "Recibir",
            "Manual"});
            this.CB_TCom.Location = new System.Drawing.Point(6, 27);
            this.CB_TCom.Name = "CB_TCom";
            this.CB_TCom.Size = new System.Drawing.Size(121, 21);
            this.CB_TCom.TabIndex = 0;
            this.CB_TCom.SelectedIndexChanged += new System.EventHandler(this.CB_TCom_SelectedIndexChanged);
            // 
            // CB_Com
            // 
            this.CB_Com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Com.FormattingEnabled = true;
            this.CB_Com.Items.AddRange(new object[] {
            "Configuración de medida",
            "Control de salida",
            "Manejo de calibración",
            "Control de parámetros"});
            this.CB_Com.Location = new System.Drawing.Point(6, 68);
            this.CB_Com.Name = "CB_Com";
            this.CB_Com.Size = new System.Drawing.Size(121, 21);
            this.CB_Com.TabIndex = 0;
            this.CB_Com.SelectedIndexChanged += new System.EventHandler(this.CB_Com_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de comando";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(130, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parametro";
            // 
            // TXB_Par
            // 
            this.TXB_Par.Location = new System.Drawing.Point(6, 108);
            this.TXB_Par.Name = "TXB_Par";
            this.TXB_Par.Size = new System.Drawing.Size(121, 20);
            this.TXB_Par.TabIndex = 2;
            // 
            // BTN_SaveTX
            // 
            this.BTN_SaveTX.Location = new System.Drawing.Point(250, 162);
            this.BTN_SaveTX.Name = "BTN_SaveTX";
            this.BTN_SaveTX.Size = new System.Drawing.Size(75, 23);
            this.BTN_SaveTX.TabIndex = 3;
            this.BTN_SaveTX.Text = "Guardar";
            this.BTN_SaveTX.UseVisualStyleBackColor = true;
            this.BTN_SaveTX.Click += new System.EventHandler(this.BTN_SaveTX_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 4;
            // 
            // TXB_Nombre
            // 
            this.TXB_Nombre.Location = new System.Drawing.Point(133, 28);
            this.TXB_Nombre.Name = "TXB_Nombre";
            this.TXB_Nombre.Size = new System.Drawing.Size(114, 20);
            this.TXB_Nombre.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Transmitir);
            this.tabControl1.Controls.Add(this.com);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 217);
            this.tabControl1.TabIndex = 7;
            // 
            // SCPICOMMAND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(358, 241);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SCPICOMMAND";
            this.Text = "SCPICOMMAND";
            this.Load += new System.EventHandler(this.SCPICOMMAND_Load);
            this.com.ResumeLayout(false);
            this.com.PerformLayout();
            this.Transmitir.ResumeLayout(false);
            this.Transmitir.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage com;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_HAND;
        private System.Windows.Forms.ComboBox CB_SB;
        private System.Windows.Forms.ComboBox CB_par;
        private System.Windows.Forms.ComboBox CB_DB;
        private System.Windows.Forms.ComboBox CB_BR;
        private System.Windows.Forms.ComboBox CB_Port;
        private System.Windows.Forms.TabPage Transmitir;
        private System.Windows.Forms.TextBox TXB_Nombre;
        private System.Windows.Forms.TextBox TXB_Par;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTN_SaveTX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Com;
        private System.Windows.Forms.ComboBox CB_TCom;
        private System.Windows.Forms.TabControl tabControl1;
    }
}