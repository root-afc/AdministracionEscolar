using System;
using System.Collections.Generic;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCantidadAlumnosAño" in both code and config file together.
    public class ServicioCantidadAlumnosAño : IServicioCantidadAlumnosAño
    {
        public List<CantidadAlumnoAño> GetCantidadAlumnoAño()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {

                List<CantidadAlumnoAño> ListCantidadAlumnoAño = new List<CantidadAlumnoAño>();

                var query = Secundaria.USP_CantidadAlumnosPorAño();

                foreach (var item in query)
                {
                    CantidadAlumnoAño objCantidadAlumnoAño = new CantidadAlumnoAño();
                    objCantidadAlumnoAño.Año = item.Año;
                    objCantidadAlumnoAño.Cantidad = Convert.ToInt32(item.Cantidad);
                    ListCantidadAlumnoAño.Add(objCantidadAlumnoAño);
                }
                return ListCantidadAlumnoAño;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
