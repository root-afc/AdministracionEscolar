using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioDetalleAlumno" in both code and config file together.
    public class ServicioDetalleAlumno : IServicioDetalleAlumno
    {
        bool IServicioDetalleAlumno.DeleteDetalleAlumno(int id_alumno)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                DETALLE_ALUMNO objDetalleAlumnoEliminar = (from objDetailAlumn in Secundaria.DETALLE_ALUMNO
                                                           where objDetailAlumn.id_alumno == id_alumno
                                                           select objDetailAlumn).FirstOrDefault();

                Secundaria.DETALLE_ALUMNO.Remove(objDetalleAlumnoEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        List<DetalleAlumnoBE> IServicioDetalleAlumno.GetAllDetalleAlumno()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<DetalleAlumnoBE> objListaDetalleAlumno = new List<DetalleAlumnoBE>();
                var query = (from objDetailAlumn in Secundaria.DETALLE_ALUMNO
                             select objDetailAlumn).Take(100);

                foreach (var objDetalleAlumnoConsultar in query)
                {
                    DetalleAlumnoBE objDetalleAlumnoBE = new DetalleAlumnoBE();

                    objDetalleAlumnoBE.Id_alumno = objDetalleAlumnoConsultar.id_alumno;
                    objDetalleAlumnoBE.Id_ano = objDetalleAlumnoConsultar.id_año;
                    objDetalleAlumnoBE.Comportamiento_alumno = objDetalleAlumnoConsultar.comportamiento;
                    objDetalleAlumnoBE.Aprobo_grado = Convert.ToBoolean(objDetalleAlumnoConsultar.aprobo_grado);
                    objDetalleAlumnoBE.Id_grado = Convert.ToInt32(objDetalleAlumnoConsultar.id_grado);
                    objDetalleAlumnoBE.Id_seccion = Convert.ToInt32(objDetalleAlumnoConsultar.id_seccion);

                    objListaDetalleAlumno.Add(objDetalleAlumnoBE);
                }

                return objListaDetalleAlumno;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        DetalleAlumnoBE IServicioDetalleAlumno.GetDetalleAlumno(int id_alumno)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                DETALLE_ALUMNO objDetalleAlumnoConsultar = (from objDetailAlumn in Secundaria.DETALLE_ALUMNO
                                                            where objDetailAlumn.id_alumno == id_alumno
                                                            select objDetailAlumn).FirstOrDefault();

                DetalleAlumnoBE objDetalleAlumnoBE = new DetalleAlumnoBE();

                objDetalleAlumnoBE.Id_alumno = objDetalleAlumnoConsultar.id_alumno;
                objDetalleAlumnoBE.Id_ano = objDetalleAlumnoConsultar.id_año;
                objDetalleAlumnoBE.Comportamiento_alumno = objDetalleAlumnoConsultar.comportamiento;
                objDetalleAlumnoBE.Aprobo_grado = Convert.ToBoolean(objDetalleAlumnoConsultar.aprobo_grado);
                objDetalleAlumnoBE.Id_grado = Convert.ToInt32(objDetalleAlumnoConsultar.id_grado);
                objDetalleAlumnoBE.Id_seccion = Convert.ToInt32(objDetalleAlumnoConsultar.id_seccion);

                return objDetalleAlumnoBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        bool IServicioDetalleAlumno.InsertDetalleAlumno(DetalleAlumnoBE objDetalleAlumnoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                DETALLE_ALUMNO objDetalleAlumnoInsertar = new DETALLE_ALUMNO();

                objDetalleAlumnoInsertar.id_alumno = objDetalleAlumnoBE.Id_alumno;
                objDetalleAlumnoInsertar.id_año = objDetalleAlumnoBE.Id_ano;
                objDetalleAlumnoInsertar.comportamiento = objDetalleAlumnoBE.Comportamiento_alumno;
                objDetalleAlumnoInsertar.aprobo_grado = objDetalleAlumnoBE.Aprobo_grado;
                objDetalleAlumnoInsertar.id_grado = objDetalleAlumnoBE.Id_grado;
                objDetalleAlumnoInsertar.id_seccion = objDetalleAlumnoBE.Id_seccion;

                Secundaria.DETALLE_ALUMNO.Add(objDetalleAlumnoInsertar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioDetalleAlumno.UpdateDetalleAlumno(DetalleAlumnoBE objDetalleAlumnoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                DETALLE_ALUMNO objDetalleAlumnoActualizar = (from objDetailAlumn in Secundaria.DETALLE_ALUMNO
                                                             where objDetailAlumn.id_alumno == objDetalleAlumnoBE.Id_alumno
                                                             select objDetailAlumn).FirstOrDefault();

                objDetalleAlumnoActualizar.id_alumno = objDetalleAlumnoBE.Id_alumno;
                objDetalleAlumnoActualizar.id_año = objDetalleAlumnoBE.Id_ano;
                objDetalleAlumnoActualizar.comportamiento = objDetalleAlumnoBE.Comportamiento_alumno;
                objDetalleAlumnoActualizar.aprobo_grado = Convert.ToBoolean(objDetalleAlumnoBE.Aprobo_grado);
                objDetalleAlumnoActualizar.id_grado = Convert.ToInt32(objDetalleAlumnoBE.Id_grado);
                objDetalleAlumnoActualizar.id_seccion = Convert.ToInt32(objDetalleAlumnoBE.Id_seccion);

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
