using System;
using System.Collections.Generic;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCurso" in both code and config file together.
    public class ServicioCurso : IServicioCurso
    {
        public List<CursoBE> GetAllCurso()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();

            try
            {
                List<CursoBE> objListaCursoBE = new List<CursoBE>();

                var query = (from objCurso in Secundaria.CURSO
                             select objCurso).ToList();

                foreach (var item in query)
                {
                    CursoBE objCursoBE = new CursoBE();
                    objCursoBE.Id_curso = item.id_curso;
                    objCursoBE.Nom_curso = item.nom_curso;
                    objCursoBE.Estado_curso = item.estado_curso;
                    objListaCursoBE.Add(objCursoBE);
                }

                return objListaCursoBE;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
