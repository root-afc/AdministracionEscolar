using System;
using System.Collections.Generic;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioTopAlumno" in both code and config file together.
    public class ServicioTopAlumno : IServicioTopAlumno
    {
        public List<TopAlumnoBE> GetTopAlumno(int id_año, int id_grado, int id_curso)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<TopAlumnoBE> objListaTopAlumno = new List<TopAlumnoBE>();

                var query = Secundaria.Usp_TopAlumno(id_año, id_grado, id_curso);

                foreach (var item in query)
                {
                    TopAlumnoBE objTopAlumnoBE = new TopAlumnoBE();
                    objTopAlumnoBE.Documento_alumno = item.doc_alumno;
                    objTopAlumnoBE.Full_name_alumno = item.Full_Name;
                    objTopAlumnoBE.Curso_alumno = item.nom_curso;
                    objTopAlumnoBE.Telefono_alumno = Convert.ToInt32(item.telf_alumno);
                    objTopAlumnoBE.Correo_alumno = item.correo_alumno;
                    objListaTopAlumno.Add(objTopAlumnoBE);
                }
                return objListaTopAlumno;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
