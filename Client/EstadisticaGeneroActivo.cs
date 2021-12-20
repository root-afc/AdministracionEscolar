using System;
using System.Windows.Forms;

namespace Client
{
    public partial class EstadisticaGeneroActivo : Form
    {
        ServicioGeneroAlumnoActivos.ServicioGeneroAlumnoActivoClient objAlumnGenActivo = new ServicioGeneroAlumnoActivos.ServicioGeneroAlumnoActivoClient();

        public EstadisticaGeneroActivo()
        {
            InitializeComponent();
        }

        private void EstadisticaGeneroActivo_Load(object sender, System.EventArgs e)
        {
            try
            {
             

                //this.WindowState = FormWindowState.Maximized;
                dtg.DataSource = objAlumnGenActivo.GetGeneroAlumnoActivos();
                chart1.Series.Add("Cantidades");
                chart1.Series["Cantidades"].Points.DataBindXY(
                    objAlumnGenActivo.GetGeneroAlumnoActivos(), "Genero",
                    objAlumnGenActivo.GetGeneroAlumnoActivos(), "Activo");
                chart1.Series["Cantidades"].IsValueShownAsLabel = true;
                chart1.Series["Cantidades"].LabelFormat = "n";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
