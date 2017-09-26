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
    public partial class frmLlamada : Form
    {
        protected Llamada _llamada;

        public Llamada ObtenerLlamada { get { return this._llamada; } }               

        public frmLlamada()
        {
            InitializeComponent();
            /*string numOrigen;
            float duracion;
            string numDestino;
            numOrigen = txtNumOrigen.Text;
            numDestino = this.txtNumDestino.Text;
            float.TryParse(this.txtDuracion.Text, out duracion);

            Llamada nuevaLlamada = new Llamada(numOrigen, numDestino, duracion);
            this._llamada = nuevaLlamada;*/
        }

        

        private void Llamada_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            string numOrigen;
            float duracion;
            string numDestino;
            numOrigen = txtNumOrigen.Text;
            numDestino = txtNumDestino.Text;
            float.TryParse(txtDuracion.Text, out duracion);

            Llamada nuevaLlamada = new Llamada(numOrigen,numDestino,duracion);
            this._llamada = nuevaLlamada;
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
