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
using NationalInstruments.DAQmx;

namespace ElecTest.FormsConfig
{
    public partial class NodeConfig : Form
    {
        //Declaraciones
        NationalInstruments.DAQmx.Task ControlN = new NationalInstruments.DAQmx.Task();
        bool DAQBL = false;
        bool TARBL = false;
        bool onoff = false;
        string Estado = null;
        Sequence_debugging[] openForms = Application.OpenForms.OfType<Sequence_debugging>().ToArray();

        public NodeConfig()
        {
            InitializeComponent();
        }

        private void CB_Tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_Tarjeta.Text == "Arduino/Pic")
                {
                    CB_baudios.Visible = true;
                    CB_Bits.Visible = true;
                    CB_Paridad.Visible = true;
                    CB_SB.Visible = true;
                    CB_Polarity.Visible = true;

                    LB_BAU.Visible = true;
                    LB_DB.Visible = true;
                    LB_PA.Visible = true;
                    LB_Pol.Visible = true;
                    LB_SB.Visible = true;
                    CB_Puertos.Items.Clear();
                    string[] Puertos = SerialPort.GetPortNames();
                    foreach (string s in Puertos)
                    {
                        CB_Puertos.Items.Add(s);
                    }
                }
                else if (CB_Tarjeta.Text == "DAQ")
                {
                    CB_Puertos.Items.Clear();
                    CB_Puertos.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.DOLine, PhysicalChannelAccess.External));
                    CB_baudios.Visible = false;
                    CB_Bits.Visible = false;
                    CB_Paridad.Visible = false;
                    CB_SB.Visible = false;
                    CB_Polarity.Visible = false;

                    LB_BAU.Visible = false;
                    LB_DB.Visible = false;
                    LB_PA.Visible = false;
                    LB_Pol.Visible = false;
                    LB_SB.Visible = false;
                }
                else if (CB_Tarjeta.Text == "Raspberry Pico")
                {

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void NodeConfig_Load(object sender, EventArgs e)
        {
            CB_baudios.Visible = false;
            CB_Bits.Visible = false;
            CB_Paridad.Visible = false;
            CB_SB.Visible = false;
            CB_Polarity.Visible = false;

            LB_BAU.Visible = false;
            LB_DB.Visible = false;
            LB_PA.Visible = false;
            LB_Pol.Visible = false;
            LB_SB.Visible = false;
        }

        private void BTN_conect_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_Tarjeta.Text == "DAQ")
                {
                    try
                    {
                        ControlN.DOChannels.CreateChannel(CB_Puertos.Text, "TestNode", ChannelLineGrouping.OneChannelForEachLine);
                        DAQBL = true;
                        TARBL = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (CB_Tarjeta.Text == "Arduino/Pic")
                {

                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DAQBL == true)
                {
                    if (onoff == false)
                    {
                        pictureBox2.Image = Properties.Resources.apagar;
                        onoff = true;
                        DigitalSingleChannelWriter Control = new DigitalSingleChannelWriter(ControlN.Stream);
                        Control.WriteSingleSampleSingleLine(true, false);
                    }
                    else if (onoff == true)
                    {
                        pictureBox2.Image = Properties.Resources.encender;
                        onoff = false;
                        DigitalSingleChannelWriter Control = new DigitalSingleChannelWriter(ControlN.Stream);
                        Control.WriteSingleSampleSingleLine(true, true);
                    }
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (CB_Tarjeta.Text == "DAQ")
            {
                if (TB_NOMBRE.Text != "" && CB_Puertos.Text != null && Estado != null)
                {
                    try
                    {
                        if (openForms.Length > 0)
                        {
                            openForms[0].NodeDaq(TB_NOMBRE.Text, "DAQ", CB_Puertos.Text, Estado);
                        }
                        else
                        {
                            MessageBox.Show("El formulario Sequence_debugging no está abierto.");
                        }
                        ControlN.Stop();
                        ControlN.Dispose();
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("Falta algun parametro"); }
            }
            else if (CB_Tarjeta.Text == "Arduino/Pic") 
            {
                if (TB_NOMBRE.Text != "" && CB_Puertos.Text != null && Estado != null && CB_baudios.Text != null && CB_Bits.Text != null && CB_Paridad.Text != null && CB_Polarity.Text != null && CB_Puertos.Text != null && CB_SB.Text != null)
                {
                    string Configuracion =  CB_Puertos.Text  + @"/" + CB_baudios.Text + @"/" + CB_Paridad.Text+ @"/" + CB_Polarity.Text+ @"/" + CB_SB.Text;
                    try
                    {
                        if (openForms.Length > 0)
                        {
                            openForms[0].NodeTar(TB_NOMBRE.Text, "Tar", Configuracion, Estado);
                        }
                        else
                        {
                            MessageBox.Show("El formulario Sequence_debugging no está abierto.");
                        }
                        ControlN.Stop();
                        ControlN.Dispose();
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("Falta algun parametro"); }
            }
        }

        private void ChB_ON_CheckedChanged(object sender, EventArgs e)
        {
            Estado = "On";
            ChB_Off.Checked = false;
        }

        private void ChB_Off_CheckedChanged(object sender, EventArgs e)
        {
            Estado = "Off";
            ChB_ON.Checked = false;
        }
    }
}
