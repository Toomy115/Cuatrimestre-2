using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FrmCentralita : Form
    {
        //private List<Llamada> llamadas = new List<Llamada>();
        private Centralita miCentral = new Centralita("Central");
        
        public FrmCentralita()
        {
            InitializeComponent();
            this.cboOrdenamiento.SelectedItem = this.cboOrdenamiento.
        }

        private void btnLlamadaLocal_Click(object sender, EventArgs e)
        {
            frmLocal frm = new frmLocal();
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                miCentral += frm.ObtenerLocal;
                lstVisor.Items.Clear();
                foreach (Llamada i in this.miCentral.Llamadas)
                {
                    this.lstVisor.Items.Add(i);
                }
            }

        }

        private void btnLlamadaProvincial_Click(object sender, EventArgs e)
        {
            frmProvincial frm = new frmProvincial();
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                miCentral += frm.ObtenerProvincial;
            }
            lstVisor.Items.Clear();
            foreach (Llamada i in this.miCentral.Llamadas)
            {
                this.lstVisor.Items.Add(i);
            }
        }

    }
}
