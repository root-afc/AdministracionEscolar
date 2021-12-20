using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioGradoCurso" in both code and config file together.
    public class ServicioGradoCurso : IServicioGradoCurso
    {
        bool IServicioGradoCurso.DeleteGradoCurso(int id_grado, int id_curso)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                GRADO_CURSO objEliminar = (from objAlumn in Secundaria.GRADO_CURSO
                                           where objAlumn.id_grado == id_grado
                                           && objAlumn.id_curso == id_curso
                                           select objAlumn).FirstOrDefault();

                Secundaria.GRADO_CURSO.Remove(objEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }


        List<GradoCursoBE> IServicioGradoCurso.GetAllGradoCurso()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<GradoCursoBE> objLista = new List<GradoCursoBE>();
                var query = (from objGradoCurso in Secundaria.GRADO_CURSO
                             select objGradoCurso).Take(100);

                foreach (var objGrdiCursoConsultar in query)
                {

                    GradoCursoBE objGradoCursoBE = new GradoCursoBE();

                    objGradoCursoBE.Id_grado = objGrdiCursoConsultar.id_grado;
                    objGradoCursoBE.Id_curso = objGrdiCursoConsultar.id_curso;
                    objGradoCursoBE.Horas_dictadas = Convert.ToInt32(objGrdiCursoConsultar.horas_dictadas);
                    objGradoCursoBE.Estado_gra_cur = Convert.ToBoolean(objGrdiCursoConsultar.estado_gra_cur);

                    objLista.Add(objGradoCursoBE);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        GradoCursoBE IServicioGradoCurso.GetGradoCurso(int id_grado, int id_curso)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                GRADO_CURSO objGradoCursoConsultar = (from objGradoCurso in Secundaria.GRADO_CURSO
                                                      where objGradoCurso.id_grado == id_grado
                                                       && objGradoCurso.id_curso == id_curso
                                                      select objGradoCurso).FirstOrDefault();

                GradoCursoBE objGradoCursoBE = new GradoCursoBE();

                objGradoCursoBE.Id_grado = objGradoCursoConsultar.id_grado;
                objGradoCursoBE.Id_curso = objGradoCursoConsultar.id_curso;
                objGradoCursoBE.Horas_dictadas = Convert.ToInt32(objGradoCursoConsultar.horas_dictadas);
                objGradoCursoBE.Estado_gra_cur = Convert.ToBoolean(objGradoCursoConsultar.estado_gra_cur);

                return objGradoCursoBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        bool IServicioGradoCurso.InsertGradoCurso(GradoCursoBE objGradoCursoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                GRADO_CURSO objGradoCursoInsertar = new GRADO_CURSO();

                objGradoCursoInsertar.id_grado = objGradoCursoBE.Id_grado;
                objGradoCursoInsertar.id_curso = objGradoCursoBE.Id_curso;
                objGradoCursoInsertar.horas_dictadas = objGradoCursoBE.Horas_dictadas;
                objGradoCursoInsertar.estado_gra_cur = Convert.ToBoolean(objGradoCursoBE.Estado_gra_cur);

                Secundaria.GRADO_CURSO.Add(objGradoCursoInsertar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioGradoCurso.UpdateGradoCurso(GradoCursoBE objGradoCursoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                GRADO_CURSO objGradoCursoActualizar = (from objGradoCurso in Secundaria.GRADO_CURSO
                                                       where objGradoCurso.id_grado == objGradoCursoBE.Id_grado
                                                       && objGradoCurso.id_curso == objGradoCursoBE.Id_curso
                                                       select objGradoCurso).FirstOrDefault();

                objGradoCursoActualizar.id_grado = objGradoCursoBE.Id_grado;
                objGradoCursoActualizar.id_curso = objGradoCursoBE.Id_curso;
                objGradoCursoActualizar.horas_dictadas = objGradoCursoBE.Horas_dictadas;
                objGradoCursoActualizar.estado_gra_cur = Convert.ToBoolean(objGradoCursoBE.Estado_gra_cur);



                Secundaria.SaveChanges();
                return true;
            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
