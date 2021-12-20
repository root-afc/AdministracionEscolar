using System;
using System.Windows.Forms;

namespace Client
{
    public partial class TopAlumnoGradoCursoAño : Form
    {
        ProxyGrado.ServicioGradoClient objGrado = new ProxyGrado.ServicioGradoClient();
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyAñoLectivo.ServicioAnoLectivoClient objAñoLectivo = new ProxyAñoLectivo.ServicioAnoLectivoClient();
        ProxyTopAlumno.ServicioTopAlumnoClient objTopAlumno = new ProxyTopAlumno.ServicioTopAlumnoClient();
        public TopAlumnoGradoCursoAño()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = objTopAlumno.GetTopAlumno(
                    Convert.ToInt32(cboAñoLectivo.SelectedValue),
                    Convert.ToInt32(cboGrado.SelectedValue),
                    Convert.ToInt32(cboCurso.SelectedValue));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cboGrado.DataSource = objGrado.GetAllGrado();
                cboGrado.ValueMember = "id_grado";
                cboGrado.DisplayMember = "nombre_grado";

                cboCurso.DataSource = objCurso.GetAllCurso();
                cboCurso.ValueMember = "id_curso";
                cboCurso.DisplayMember = "nom_curso";

                cboAñoLectivo.DataSource = objAñoLectivo.GetAllAñoLectivo();
                cboAñoLectivo.ValueMember = "id_año";
                cboAñoLectivo.DisplayMember = "id_año";

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
