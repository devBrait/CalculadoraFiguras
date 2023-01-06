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
    public partial class AreaTriangulo : Form
    {
        public AreaTriangulo()
        {
            InitializeComponent();
        }

        private void calcularAreaTrianguloEscaleno()
        {
            try
            {
                //Área do triângulo escaleno = (base * altura) / 2
                lblAreaEscaleno.Text = ((Double.Parse(tbBase.Text.ToString()) * Double.Parse(tbAltura.Text.ToString())) / 2).ToString();
            }
            catch (Exception)
            {
                lblAreaEscaleno.Text = "Erro";
            }
        }

        private void tbBase_TextChanged(object sender, EventArgs e)
        {
            calcularAreaTrianguloEscaleno();
        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {
            calcularAreaTrianguloEscaleno();
        }

        private void tbLado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Área do triângulo equilátero = (lado ao quadrado/4 ) * raiz de 3
                lblAreaEquilatero.Text = ((Math.Pow(Double.Parse(tbLado.Text.ToString()),2) / 4) * Math.Sqrt(3)).ToString();
            }
            catch (Exception)
            {
                lblAreaEquilatero.Text = "Erro";
            }
        }
    }
}
