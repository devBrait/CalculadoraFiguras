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
    public partial class AreaQuadrado : Form
    {
        public AreaQuadrado()
        {
            InitializeComponent();
        }

        private void tbLado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Area do quadrado = lado ao quadrado
                lblArea.Text = (Math.Pow(Double.Parse(tbLado.Text.ToString()), 2)).ToString();
            }
            catch (Exception)
            {
                lblArea.Text = "Erro";
            }
        }
    }
}
