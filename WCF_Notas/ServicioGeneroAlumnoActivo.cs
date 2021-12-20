using System;
using System.Collections.Generic;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioGeneroAlumnoActivo" in both code and config file together.
    public class ServicioGeneroAlumnoActivo : IServicioGeneroAlumnoActivo
    {
        public List<GeneroAlumnoActivo> GetGeneroAlumnoActivos()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<GeneroAlumnoActivo> objListAlumnoGeneroActivo = new List<GeneroAlumnoActivo>();
                var query = Secundaria.usp_GeneroAlumnoActivo();
                foreach (var item in query)
                {
                    GeneroAlumnoActivo objAlumGenActive = new GeneroAlumnoActivo();
                    objAlumGenActive.Genero = Convert.ToString(item.Genero);
                    objAlumGenActive.Activo = Convert.ToInt32(item.Activo);
                    objListAlumnoGeneroActivo.Add(objAlumGenActive);
                }
                return objListAlumnoGeneroActivo;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
