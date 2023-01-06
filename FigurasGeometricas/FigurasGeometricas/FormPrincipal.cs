using System;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            AreaQuadrado area = new AreaQuadrado();
            area.ShowDialog();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            AreaCirculo area = new AreaCirculo();
            area.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            AreaTriangulo area = new AreaTriangulo();
            area.ShowDialog();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            AreaRetangulo area = new AreaRetangulo();
            area.ShowDialog();
        }
    }
}
