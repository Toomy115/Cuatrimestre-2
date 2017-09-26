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
    public partial class frmProvincial : frmLlamada
    {
        private Provincial _provincial;

        public Provincial ObtenerProvincial { get { return this._provincial; } }

        public frmProvincial()
        {
            InitializeComponent();
            foreach (Franja i in Enum.GetValues(typeof(Franja)))
            {
                cmbFranja.Items.Add(i);
            }
            cmbFranja.SelectedItem =Franja.Franja_1;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base._llamada = new Llamada(base.txtNumOrigen.Text, base.txtNumDestino.Text, float.Parse(base.txtDuracion.Text));
            this._provincial = new Provincial((Franja)this.cmbFranja.SelectedItem, base._llamada);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
