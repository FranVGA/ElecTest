using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecTest
{
    public partial class SCPICOMMAND : Form
    {
        Sequence_debugging[] openForms = Application.OpenForms.OfType<Sequence_debugging>().ToArray();

        public SCPICOMMAND()
        {
            InitializeComponent();
        }

        private void CB_TCom_SelectedIndexChanged(object sender, EventArgs e)
        {

            TXB_Par.Enabled = false;
            CB_Com.Items.Clear();
            switch (CB_TCom.SelectedIndex)
            {
                case 0:
                    CB_Com.Items.Add("*RST");
                    CB_Com.Items.Add("*CLS");
                    CB_Com.Items.Add("*IDN?");
                    break;
                case 1:
                    CB_Com.Items.Add("CONF:VOLT");
                    CB_Com.Items.Add("CONF:CURR");
                    CB_Com.Items.Add("CONF:RES");
                    CB_Com.Items.Add("CONF:FREQ");
                    CB_Com.Items.Add("CONF:TEMP");
                    break; 
                case 2:
                    CB_Com.Items.Add("CAL:DATA");
                    CB_Com.Items.Add("CAL:ALL[:IMM]");
                    CB_Com.Items.Add("CAL:ADC[:IMM]");
                    CB_Com.Items.Add("CAL:STATus?");
                    break;
                case 3:
                    CB_Com.Items.Add("SYST:ERR?");
                    CB_Com.Items.Add("DISP:TEXT");
                    CB_Com.Items.Add("SYST:LANG SCPI");
                    break;
            }
        }

        private void CB_Com_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Com.SelectedItem.ToString())
            {
                case "CONF:VOLT":
                    TXB_Par.Enabled = true;
                    break;
                case "CONF:CURR":
                    TXB_Par.Enabled = true;
                    break;
                case "CONF:RES":
                    TXB_Par.Enabled = true;
                    break;
                case "CONF:FREQ":
                    TXB_Par.Enabled = true;
                    break;
            }
        }

        private void SCPICOMMAND_Load(object sender, EventArgs e)
        {

            TXB_Par.Enabled = false;
            string[] puertos = SerialPort.GetPortNames();
            foreach (string s in puertos) 
            {
                CB_Port.Items.Add(s);
            }
        }

        private void BTN_SaveTX_Click(object sender, EventArgs e)
        {
            string buffer;
            string BufferCom;
            switch (CB_Com.SelectedItem.ToString())
            {
                case "CONF:VOLT":
                    buffer = TXB_Par.Text;
                    break;
                case "CONF:CURR":
                    buffer = TXB_Par.Text;
                    break;
                case "CONF:RES":
                    buffer = TXB_Par.Text;
                    break;
                case "CONF:FREQ":
                    buffer = TXB_Par.Text;
                    break;
                default:
                    buffer = CB_Com.Text;
                    break;
            }
            BufferCom = CB_Port.Text + @"/" + CB_BR.Text + @"/" + CB_DB.Text + @"/" + CB_par + @"/" + CB_SB.Text + @"/" + CB_HAND.Text;
            try 
            {
                openForms[0].SCPIRS232(TXB_Nombre.Text, "SCPI Rs232", BufferCom, buffer);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
