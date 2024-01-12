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
    public partial class UIl : Form
    {
        //Variables
        int m, mX, mY;
        string RutaUsers = @"C:\PaCam\Config files\Users\Users.txt";
        string user;
        string perm;
        string password;

        List<string> ListUsers = new List<string>();
        List<string> ListPermi = new List<string>();
        List<string> ListPassw = new List<string>();

        public UIl()
        {
            InitializeComponent();
        }


        //Interfaz
        private void UIl_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void UIl_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void UIl_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    RutUsEx.Text = RutaUsers;
                    RutUsEx.ForeColor = Color.Green;
                    int i = combo_users.SelectedIndex;
                    string per = ListPermi[i];
                    string passw = ListPassw[i];
                    if (tbPass.Text == passw)
                    {
                        if (per == "1")
                        {
                            Form Sequence = new Sequence_debugging();
                            Sequence.Show();
                            this.Hide();
                        }
                        else if (per == "2")
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un usuario" + "\n" + "Error: " + ex); ;
                }
            }
        }

        private void UIl_Load(object sender, EventArgs e)
        {
            StreamReader Users = new StreamReader(RutaUsers);
            string items;
            while ((items = Users.ReadLine()) != null)
            {
                ListUsers.Add(items.Substring(0, 5));
                ListPermi.Add(items.Substring(6, 1));
                ListPassw.Add(items.Substring(8));
            }
            combo_users.Items.AddRange(ListUsers.ToArray());
            Users.Close();
        }

        private void LogOnBut_Click(object sender, EventArgs e)
        {
            try
            {
                RutUsEx.Text = RutaUsers;
                RutUsEx.ForeColor = Color.Green;
                int i = combo_users.SelectedIndex;
                string per = ListPermi[i];
                string passw = ListPassw[i];
                if (tbPass.Text == passw)
                {
                    if (per == "1")
                    {
                        Form Sequence = new Sequence_debugging();
                        Sequence.Show();
                        this.Hide();
                    }
                    else if (per == "2")
                    {

                    }
                }
                else
                {
                MessageBox.Show("Contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un usuario" + "\n" + "Error: " + ex); ;
            }
        }

    }
}
