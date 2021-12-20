using System;
using System.Collections.Generic;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioGrado" in both code and config file together.
    public class ServicioGrado : IServicioGrado
    {
        public List<GradoBE> GetAllGrado()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<GradoBE> objListaGradoBE = new List<GradoBE>();

                var query = (from objGrado in Secundaria.GRADO
                             select objGrado).ToList();

                foreach (var item in query)
                {
                    GradoBE objGradoBE = new GradoBE();
                    objGradoBE.Id_grado = item.id_grado;
                    objGradoBE.Nombre_grado = item.nombre_grado;
                    objListaGradoBE.Add(objGradoBE);
                }
                return objListaGradoBE;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
