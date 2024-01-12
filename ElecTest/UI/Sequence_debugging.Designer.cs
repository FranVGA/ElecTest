namespace ElecTest
{
    partial class Sequence_debugging
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Configuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comandos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisorForms = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_abrir = new System.Windows.Forms.PictureBox();
            this.Btn_Guardar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComandBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_abrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Metodos,
            this.Configuracion,
            this.Comandos});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.dataGridView1.Location = new System.Drawing.Point(268, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 319);
            this.dataGridView1.TabIndex = 30;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 175;
            // 
            // Metodos
            // 
            this.Metodos.HeaderText = "Metodo";
            this.Metodos.Name = "Metodos";
            // 
            // Configuracion
            // 
            this.Configuracion.HeaderText = "Configuracion";
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Width = 125;
            // 
            // Comandos
            // 
            this.Comandos.HeaderText = "Comando";
            this.Comandos.Name = "Comandos";
            // 
            // VisorForms
            // 
            this.VisorForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.VisorForms.Location = new System.Drawing.Point(817, 8);
            this.VisorForms.Name = "VisorForms";
            this.VisorForms.Size = new System.Drawing.Size(390, 319);
            this.VisorForms.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.BTN_abrir);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 500);
            this.panel2.TabIndex = 32;
            // 
            // BTN_abrir
            // 
            this.BTN_abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_abrir.Image = global::ElecTest.Properties.Resources.cargando;
            this.BTN_abrir.Location = new System.Drawing.Point(115, 444);
            this.BTN_abrir.Name = "BTN_abrir";
            this.BTN_abrir.Size = new System.Drawing.Size(59, 53);
            this.BTN_abrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_abrir.TabIndex = 6;
            this.BTN_abrir.TabStop = false;
            this.BTN_abrir.Click += new System.EventHandler(this.BTN_abrir_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.Image = global::ElecTest.Properties.Resources.verificado;
            this.Btn_Guardar.Location = new System.Drawing.Point(180, 444);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(59, 53);
            this.Btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.TabStop = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(3, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 62);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar";
            this.label1.Click += new System.EventHandler(this.panel4_Click);
            this.label1.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ElecTest.Properties.Resources.boton_eliminar;
            this.pictureBox2.Location = new System.Drawing.Point(164, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.panel4_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(3, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 62);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar";
            this.label2.Click += new System.EventHandler(this.pictureBox1_Click);
            this.label2.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ElecTest.Properties.Resources.adicional;
            this.pictureBox1.Location = new System.Drawing.Point(164, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(3, 127);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(239, 62);
            this.panel8.TabIndex = 4;
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Step";
            this.label5.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::ElecTest.Properties.Resources.planificacion1;
            this.pictureBox5.Location = new System.Drawing.Point(164, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(3, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(239, 62);
            this.panel7.TabIndex = 4;
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pausa";
            this.label4.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ElecTest.Properties.Resources.pausa;
            this.pictureBox4.Location = new System.Drawing.Point(164, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 62);
            this.panel6.TabIndex = 4;
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start";
            this.label3.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ElecTest.Properties.Resources.start_up;
            this.pictureBox3.Location = new System.Drawing.Point(164, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.ComandBox);
            this.panel1.Location = new System.Drawing.Point(268, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 175);
            this.panel1.TabIndex = 31;
            // 
            // ComandBox
            // 
            this.ComandBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ComandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComandBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.ComandBox.FormattingEnabled = true;
            this.ComandBox.Location = new System.Drawing.Point(3, 3);
            this.ComandBox.Name = "ComandBox";
            this.ComandBox.Size = new System.Drawing.Size(933, 169);
            this.ComandBox.TabIndex = 0;
            // 
            // Sequence_debugging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1219, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.VisorForms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sequence_debugging";
            this.Text = "Sequence_debugging";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sequence_debugging_FormClosed);
            this.Load += new System.EventHandler(this.Sequence_debugging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_abrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel VisorForms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox ComandBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Configuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comandos;
        private System.Windows.Forms.PictureBox Btn_Guardar;
        private System.Windows.Forms.PictureBox BTN_abrir;
    }
}