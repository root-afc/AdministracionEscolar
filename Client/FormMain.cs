using System;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void topAlumnoGradoCursoAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void crudAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topAlumnoGradoCursoAñoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void topAlumnoGradoCursoAñoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TopAlumnoGradoCursoAño obj = new TopAlumnoGradoCursoAño();
            obj.ShowDialog();
        }

        private void crudAlumnoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainAlumno obj = new MainAlumno();
            obj.ShowDialog();
        }

        private void estadísticaCantidadAlumnosAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaCantidadAlumnoAño obj = new EstadisticaCantidadAlumnoAño();
            obj.ShowDialog();
        }

        private void estadísticaGeneroAlumnosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaGeneroActivo obj = new EstadisticaGeneroActivo();
            obj.ShowDialog();
        }
    }
}
