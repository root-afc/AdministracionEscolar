using System;
using System.Windows.Forms;

namespace Client
{
    public partial class InsertarAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        public InsertarAlumno()
        {
            InitializeComponent();
        }

        private void InsertarAlumno_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDoc.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el # de documento.");
                }


                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el nombre.");
                }


                if (txtPaterno.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el apellido paterno.");
                }


                if (txtMaterno.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el apellido materno.");
                }



                if (txtTelf.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el teléfono.");
                }



                if (txtCorreo.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el correo.");
                }


                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el dirección.");
                }


                if (txtGenero.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar un género.");
                }



                if (txtFec.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar una fecha nacimiento.");
                }

                objAlumnoBE.Documento_alumno = Convert.ToInt32(txtDoc.Text.Trim());
                objAlumnoBE.Nombre_alumno = txtNombre.Text.Trim();
                objAlumnoBE.Paterno_alumno = txtPaterno.Text.Trim();
                objAlumnoBE.Materno_alumno = txtMaterno.Text.Trim();
                objAlumnoBE.Telefono_alumno = Convert.ToInt32(txtTelf.Text.Trim());
                objAlumnoBE.Correo_alumno = txtCorreo.Text.Trim();
                objAlumnoBE.Dirección_alumno = txtDireccion.Text.Trim();
                objAlumnoBE.Genero_alumno = Convert.ToChar(txtGenero.Text.Trim());
                objAlumnoBE.Fecha_nacimiento_alumno = Convert.ToDateTime(txtFec.Text.Trim());
                objAlumnoBE.Estado_alumno = false;
                if (objAlumno.InsertAlumno(objAlumnoBE) == true)
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
    }
}
