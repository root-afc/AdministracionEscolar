using System;
using System.Windows.Forms;

namespace Client
{
    public partial class EstadisticaCantidadAlumnoAño : Form
    {
        ServicioCantidadAlumnosAño.ServicioCantidadAlumnosAñoClient ListCantidadAlumnosAño = new ServicioCantidadAlumnosAño.ServicioCantidadAlumnosAñoClient();
        public EstadisticaCantidadAlumnoAño()
        {
            InitializeComponent();
        }

        private void EstadisticaCantidadAlumnoAño_Load(object sender, EventArgs e)
        {
            try
            {

                this.WindowState = FormWindowState.Maximized;
                dtgEstadistica.DataSource = ListCantidadAlumnosAño.GetCantidadAlumnoAño();
                chart1.Series.Add("Cantidades");
                chart1.Series["Cantidades"].Points.DataBindXY(
                    ListCantidadAlumnosAño.GetCantidadAlumnoAño(), "Año",
                    ListCantidadAlumnosAño.GetCantidadAlumnoAño(), "Cantidad");
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
