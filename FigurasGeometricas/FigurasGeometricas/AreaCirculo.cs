using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class AreaCirculo : Form
    {
        public AreaCirculo()
        {
            InitializeComponent();
        }

        private void tbRaio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Area do círculo = PI * raio ao quadrado
                lblArea.Text = (Math.PI * (Math.Pow(Double.Parse(tbRaio.Text.ToString()), 2))).ToString();
            }
            catch (Exception)
            {
                lblArea.Text = "Erro";
            }
        }
    }
}
