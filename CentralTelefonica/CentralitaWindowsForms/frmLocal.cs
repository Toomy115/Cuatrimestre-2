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
    public partial class frmLocal : frmLlamada
    {
        private Local _local;

        public Local ObtenerLocal { get { return this._local; } }

        public frmLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            /*float costo;

            Llamada llamada = base.ObtenerLlamada;  
            
            float.TryParse(this.txtCosto.Text, out costo);

            Local llamadaLocal = new Local(llamada, costo);

            //base._llamada = new Llamada()*/
            base._llamada = new Llamada(base.txtNumOrigen.Text, base.txtNumDestino.Text, float.Parse(base.txtDuracion.Text));
            this._local = new Local(base._llamada, float.Parse(this.txtCosto.Text));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
