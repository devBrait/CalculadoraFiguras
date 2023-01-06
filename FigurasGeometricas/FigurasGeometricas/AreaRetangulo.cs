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
    public partial class AreaRetangulo : Form
    {
        public AreaRetangulo()
        {
            InitializeComponent();
        }

        private void calcularAreaRetangulo()
        {
            try
            {
                //Area do retângulo = base * altura
                lblArea.Text = (Double.Parse(tbBase.Text.ToString()) * Double.Parse(tbAltura.Text.ToString())).ToString();
            }
            catch (Exception)
            {
                lblArea.Text = "Erro";
            }
        }

        private void tbBase_TextChanged(object sender, EventArgs e)
        {
            calcularAreaRetangulo();
        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {
            calcularAreaRetangulo();
        }
    }
}
