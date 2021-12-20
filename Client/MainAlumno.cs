using System;
using System.Windows.Forms;

namespace Client
{
    public partial class MainAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        public MainAlumno()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgDatos.DataSource = objAlumno.GetAllAlumno();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            ActualizarAlumno obj = new ActualizarAlumno();
            obj.Id_alumno = Convert.ToInt32(dtgDatos.CurrentRow.Cells[0].Value);
            obj.ShowDialog();
            CargarDatos();
        }

        private void CrudAlumno_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            InsertarAlumno objInsert = new InsertarAlumno();
            objInsert.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult vrpta;
                vrpta = MessageBox.Show("Seguro de eliminar registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes)
                {
                    if (objAlumno.DeleteAlumno(Convert.ToInt32(dtgDatos.CurrentRow.Cells[0].Value)) == true)
                    {
                        CargarDatos();
                    }
                }
                else
                {
                    throw new Exception("No se pudo eliminar el proveedor. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
