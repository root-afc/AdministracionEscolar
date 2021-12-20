using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioNotaCurso" in both code and config file together.
    public class ServicioNotaCurso : IServicioNotaCurso
    {
        bool IServicioNotaCurso.DeleteNotaCurso(int id_alumno, int id_curso)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                NOTA_CURSO objEliminar = (from objAlumn in Secundaria.NOTA_CURSO
                                          where objAlumn.id_alumno == id_alumno
                                          && objAlumn.id_curso == id_curso
                                          select objAlumn).FirstOrDefault();

                Secundaria.NOTA_CURSO.Remove(objEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }


        List<NotaCursoBE> IServicioNotaCurso.GetAllNotaCurso()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<NotaCursoBE> objLista = new List<NotaCursoBE>();
                var query = (from objNotacurso in Secundaria.NOTA_CURSO
                             select objNotacurso).Take(100);

                foreach (var objNotacursoConsultar in query)
                {
                    NotaCursoBE objNotaCursoBE = new NotaCursoBE();

                    objNotaCursoBE.Id_alumno = objNotacursoConsultar.id_alumno;
                    objNotaCursoBE.Id_año = objNotacursoConsultar.id_año;
                    objNotaCursoBE.Id_grado = objNotacursoConsultar.id_grado;
                    objNotaCursoBE.Id_curso = objNotacursoConsultar.id_curso;
                    objNotaCursoBE.Trimestre_uno = Convert.ToInt32(objNotacursoConsultar.trimestre_uno);
                    objNotaCursoBE.Trimestre_dos = Convert.ToInt32(objNotacursoConsultar.trimestre_dos);
                    objNotaCursoBE.Trimestre_tres = Convert.ToInt32(objNotacursoConsultar.trimestre_tres);
                    objNotaCursoBE.Promedio = Convert.ToInt32(objNotacursoConsultar.promedio);
                    objNotaCursoBE.Aprobo_curso = Convert.ToBoolean(objNotacursoConsultar.aprobo_curso);

                    objLista.Add(objNotaCursoBE);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        NotaCursoBE IServicioNotaCurso.GetNotaCurso(int id_alumno, int id_curso)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                NOTA_CURSO objNotacursoConsultar = (from objNotacurso in Secundaria.NOTA_CURSO
                                                    where objNotacurso.id_alumno == id_alumno
                                                     && objNotacurso.id_curso == id_curso
                                                    select objNotacurso).FirstOrDefault();

                NotaCursoBE objNotaCursoBE = new NotaCursoBE();

                objNotaCursoBE.Id_alumno = objNotacursoConsultar.id_alumno;
                objNotaCursoBE.Id_año = objNotacursoConsultar.id_año;
                objNotaCursoBE.Id_grado = objNotacursoConsultar.id_grado;
                objNotaCursoBE.Id_curso = objNotacursoConsultar.id_curso;
                objNotaCursoBE.Trimestre_uno = Convert.ToInt32(objNotacursoConsultar.trimestre_uno);
                objNotaCursoBE.Trimestre_dos = Convert.ToInt32(objNotacursoConsultar.trimestre_dos);
                objNotaCursoBE.Trimestre_tres = Convert.ToInt32(objNotacursoConsultar.trimestre_tres);
                objNotaCursoBE.Promedio = Convert.ToInt32(objNotacursoConsultar.promedio);
                objNotaCursoBE.Aprobo_curso = Convert.ToBoolean(objNotacursoConsultar.aprobo_curso);

                return objNotaCursoBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        bool IServicioNotaCurso.InsertNotaCurso(NotaCursoBE objNotaCursoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                NOTA_CURSO objNotacursoActualizar = new NOTA_CURSO();

                objNotacursoActualizar.id_alumno = objNotaCursoBE.Id_alumno;
                objNotacursoActualizar.id_año = objNotaCursoBE.Id_año;
                objNotacursoActualizar.id_grado = objNotaCursoBE.Id_grado;
                objNotacursoActualizar.id_curso = objNotaCursoBE.Id_curso;
                objNotacursoActualizar.trimestre_uno = objNotaCursoBE.Trimestre_uno;
                objNotacursoActualizar.trimestre_dos = objNotaCursoBE.Trimestre_dos;
                objNotacursoActualizar.trimestre_tres = objNotaCursoBE.Trimestre_tres;
                objNotacursoActualizar.promedio = objNotaCursoBE.Promedio;
                objNotacursoActualizar.aprobo_curso = Convert.ToBoolean(objNotaCursoBE.Aprobo_curso);

                Secundaria.NOTA_CURSO.Add(objNotacursoActualizar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioNotaCurso.UpdateNotaCurso(NotaCursoBE objNotaCursoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                NOTA_CURSO ObjNotaCursoActualizar = (from objNotacurso in Secundaria.NOTA_CURSO
                                                     where objNotacurso.id_alumno == objNotaCursoBE.Id_alumno
                                                     && objNotacurso.id_curso == objNotaCursoBE.Id_curso
                                                     select objNotacurso).FirstOrDefault();

                ObjNotaCursoActualizar.id_alumno = objNotaCursoBE.Id_alumno;
                ObjNotaCursoActualizar.id_año = objNotaCursoBE.Id_año;
                ObjNotaCursoActualizar.id_grado = objNotaCursoBE.Id_grado;
                ObjNotaCursoActualizar.id_curso = objNotaCursoBE.Id_curso;
                ObjNotaCursoActualizar.trimestre_uno = objNotaCursoBE.Trimestre_uno;
                ObjNotaCursoActualizar.trimestre_dos = objNotaCursoBE.Trimestre_dos;
                ObjNotaCursoActualizar.trimestre_tres = objNotaCursoBE.Trimestre_tres;
                ObjNotaCursoActualizar.promedio = objNotaCursoBE.Promedio;
                ObjNotaCursoActualizar.aprobo_curso = Convert.ToBoolean(objNotaCursoBE.Aprobo_curso);


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
