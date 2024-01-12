using ElecTest.FormsConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecTest
{
    public partial class MenuAdd : Form
    {

        //Forms
        NodeConfig nodeConfig = new NodeConfig();
        SCPICOMMAND SCPI = new SCPICOMMAND();

        public MenuAdd()
        {
            InitializeComponent();
        }

        private void New_Stepbtm_MouseMove(object sender, MouseEventArgs e)
        {
            New_Stepbtm.BackColor = Color.DimGray;
        }

        private void New_Stepbtm_MouseLeave(object sender, EventArgs e)
        {
            New_Stepbtm.BackColor = Color.FromArgb(7, 30, 38);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.DimGray;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(7, 30, 38);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.DimGray;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(7, 30, 38);
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.DimGray;
        }

        private void panel1_MouseLeave_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(7, 30, 38);
        }

        private void New_Stepbtm_Click(object sender, EventArgs e)
        {
            Sequence_debugging[] openForms = Application.OpenForms.OfType<Sequence_debugging>().ToArray();

            if (openForms.Length > 0)
            {
                openForms[0].AbrirForm(nodeConfig);
            }
            else
            {
                MessageBox.Show("El formulario Sequence_debugging no está abierto.");
            }
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuAdd_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Sequence_debugging[] openForms = Application.OpenForms.OfType<Sequence_debugging>().ToArray();

            if (openForms.Length > 0)
            {
                openForms[0].AbrirForm(SCPI);
            }
            else
            {
                MessageBox.Show("El formulario Sequence_debugging no está abierto.");
            }
            this.Hide();
        }
    }
}
