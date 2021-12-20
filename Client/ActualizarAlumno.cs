using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ActualizarAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private Int32 id_alumno;

        public int Id_alumno { get => id_alumno; set => id_alumno = value; }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            objAlumnoBE = objAlumno.GetAlumno(Id_alumno);
            txtTelf.Text = Convert.ToString(objAlumnoBE.Telefono_alumno);
            txtCorreo.Text = objAlumnoBE.Correo_alumno;
            txtDireccion.Text = objAlumnoBE.Dirección_alumno;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE.Telefono_alumno = Convert.ToInt32(txtTelf.Text.Trim());
                objAlumnoBE.Correo_alumno = txtCorreo.Text.Trim();
                objAlumnoBE.Dirección_alumno = txtDireccion.Text.Trim();

                if (objAlumno.UpdateAlumno(objAlumnoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error, no se actualizo el registro. Contactar con IT.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
