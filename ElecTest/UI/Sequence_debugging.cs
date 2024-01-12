using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecTest
{
    public partial class Sequence_debugging : Form
    {
        public Sequence_debugging()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Funciones
        public void AbrirForm(Form f)
        {
            f.TopLevel = false;
            this.VisorForms.Controls.Clear();
            this.VisorForms.Controls.Add(f);
            f.Show();
        }
        public void NodeDaq(string Nombre, string tipo, string Puerto, string Estado) 
        {
            dataGridView1.Rows.Add(Nombre, tipo, Puerto, Estado);
        }
        public void NodeTar(string Nombre, string tipo, string Puerto, string Estado)
        {
            dataGridView1.Rows.Add(Nombre, tipo, Puerto, Estado);
        }
        public void SCPIRS232(string Nombre, string tipo, string Configuracion, string Comando)
        {
            dataGridView1.Rows.Add(Nombre, tipo, Configuracion, Comando);
        }

        //ccc
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void Sequence_debugging_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Menu = new MenuAdd();
            Menu.ShowDialog();
        }

        private void Sequence_debugging_Load(object sender, EventArgs e)
        {
            ComandBox.Items.Add("Consola");
            
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog GuardarDGV = new SaveFileDialog();
            GuardarDGV.Filter = "CSV|*.csv";
            GuardarDGV.ShowDialog();

            if (GuardarDGV.FileName != "")
            {
                try
                {
                    StreamWriter RutaT = new StreamWriter(GuardarDGV.FileName);
                    foreach (DataGridViewColumn Coulumna in dataGridView1.Columns)
                    {
                        RutaT.Write(Coulumna.HeaderText + ",");
                    }
                    RutaT.WriteLine();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            RutaT.Write(row.Cells[i].Value + ",");
                        }
                        RutaT.WriteLine();
                    }
                    RutaT.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else { MessageBox.Show("Archivo sin nombre"); }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else { MessageBox.Show("Seleccione una fila"); }
        }

        private void BTN_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirT = new OpenFileDialog();
            AbrirT.Filter = "CSV|*.csv";
            if (AbrirT.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    using (StreamReader Temp = new StreamReader(AbrirT.FileName))
                    {
                        string[] headers = Temp.ReadLine()?.Split(',') ?? new string[0];
                        foreach (string header in headers)
                        {
                            if (!string.IsNullOrWhiteSpace(header))
                            {
                                dataGridView1.Columns.Add(header, header);
                            }
                        }

                        while (!Temp.EndOfStream) 
                        {
                            string[] rows = Temp.ReadLine()?.Split(',') ?? new string[0];
                            rows = rows.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                            if (rows.Length > 0)
                            {
                                dataGridView1.Rows.Add(rows);
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);                
                }
            }
        }
    }
}
