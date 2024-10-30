using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsubTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double Monto = double.Parse(txtMonto.Text);
                double IVA = double.Parse(txtIva.Text);
                double Total = (Monto * IVA) + Monto;
                txtTotal.Text = Total.ToString();
            }
            catch {
                MessageBox.Show("Para hacer la operacion se necesitan digitar ambos datos");
            }
            
        }

        private void lblInst2_Click(object sender, EventArgs e)
        {

        }

        private void grpInstrucciones_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            txtIva.Clear();
            txtTotal.Clear();
            txtMonto.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando la Pantalla...");
            Close();
        }
    }
}
