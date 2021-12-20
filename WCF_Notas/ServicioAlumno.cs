using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    public class ServicioAlumno : IServicioAlumno
    {
        bool IServicioAlumno.DeleteAlumno(int id_alumno)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                ALUMNO objAlumnoEliminar = (from objAlumn in Secundaria.ALUMNO
                                            where objAlumn.id_alumno == id_alumno
                                            select objAlumn).FirstOrDefault();

                Secundaria.ALUMNO.Remove(objAlumnoEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        List<AlumnoBE> IServicioAlumno.GetAllAlumno()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();
                var query = (from objAlumn in Secundaria.ALUMNO
                             select objAlumn);

                foreach (var objAlumnoConsultar in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();

                    objAlumnoBE.Id_alumno = objAlumnoConsultar.id_alumno;
                    objAlumnoBE.Nombre_alumno = objAlumnoConsultar.nom_alumno;
                    objAlumnoBE.Paterno_alumno = objAlumnoConsultar.ape_paterno;
                    objAlumnoBE.Materno_alumno = objAlumnoConsultar.ape_materno;
                    objAlumnoBE.Documento_alumno = objAlumnoConsultar.doc_alumno;
                    objAlumnoBE.Fecha_nacimiento_alumno = Convert.ToDateTime(objAlumnoConsultar.fech_nac_alumno);
                    objAlumnoBE.Telefono_alumno = Convert.ToInt32(objAlumnoConsultar.telf_alumno);
                    objAlumnoBE.Dirección_alumno = objAlumnoConsultar.dir_alumno;
                    objAlumnoBE.Correo_alumno = objAlumnoConsultar.correo_alumno;
                    objAlumnoBE.Genero_alumno = Convert.ToChar(objAlumnoConsultar.genero);
                    objAlumnoBE.Estado_alumno = Convert.ToBoolean(objAlumnoConsultar.estado_alumno);

                    objListaAlumno.Add(objAlumnoBE);
                }

                return objListaAlumno;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        AlumnoBE IServicioAlumno.GetAlumno(int id_alumno)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                ALUMNO objAlumnoConsultar = (from objAlumn in Secundaria.ALUMNO
                                             where objAlumn.id_alumno == id_alumno
                                             select objAlumn).FirstOrDefault();

                AlumnoBE objAlumnoBE = new AlumnoBE();

                objAlumnoBE.Id_alumno = objAlumnoConsultar.id_alumno;
                objAlumnoBE.Nombre_alumno = objAlumnoConsultar.nom_alumno;
                objAlumnoBE.Paterno_alumno = objAlumnoConsultar.ape_paterno;
                objAlumnoBE.Materno_alumno = objAlumnoConsultar.ape_materno;
                objAlumnoBE.Documento_alumno = objAlumnoConsultar.doc_alumno;
                objAlumnoBE.Fecha_nacimiento_alumno = Convert.ToDateTime(objAlumnoConsultar.fech_nac_alumno);
                objAlumnoBE.Telefono_alumno = Convert.ToInt32(objAlumnoConsultar.telf_alumno);
                objAlumnoBE.Dirección_alumno = objAlumnoConsultar.dir_alumno;
                objAlumnoBE.Correo_alumno = objAlumnoConsultar.correo_alumno;
                objAlumnoBE.Genero_alumno = Convert.ToChar(objAlumnoConsultar.genero);
                objAlumnoBE.Estado_alumno = Convert.ToBoolean(objAlumnoConsultar.estado_alumno);

                return objAlumnoBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        bool IServicioAlumno.InsertAlumno(AlumnoBE objAlumnoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                ALUMNO objAlumnoInsertar = new ALUMNO();

                objAlumnoInsertar.id_alumno = objAlumnoBE.Id_alumno;
                objAlumnoInsertar.nom_alumno = objAlumnoBE.Nombre_alumno;
                objAlumnoInsertar.ape_paterno = objAlumnoBE.Paterno_alumno;
                objAlumnoInsertar.ape_materno = objAlumnoBE.Materno_alumno;
                objAlumnoInsertar.doc_alumno = objAlumnoBE.Documento_alumno;
                objAlumnoInsertar.fech_nac_alumno = Convert.ToDateTime(objAlumnoBE.Fecha_nacimiento_alumno);
                objAlumnoInsertar.telf_alumno = Convert.ToInt32(objAlumnoBE.Telefono_alumno);
                objAlumnoInsertar.dir_alumno = objAlumnoBE.Dirección_alumno;
                objAlumnoInsertar.correo_alumno = objAlumnoBE.Correo_alumno;
                objAlumnoInsertar.genero = Convert.ToString(objAlumnoBE.Genero_alumno);
                objAlumnoInsertar.estado_alumno = Convert.ToBoolean(objAlumnoBE.Estado_alumno);

                Secundaria.ALUMNO.Add(objAlumnoInsertar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioAlumno.UpdateAlumno(AlumnoBE objAlumnoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                ALUMNO objAlumnoActualizar = (from objAlumn in Secundaria.ALUMNO
                                              where objAlumn.id_alumno == objAlumnoBE.Id_alumno
                                              select objAlumn).FirstOrDefault();

                objAlumnoActualizar.id_alumno = objAlumnoBE.Id_alumno;
                objAlumnoActualizar.nom_alumno = objAlumnoBE.Nombre_alumno;
                objAlumnoActualizar.ape_paterno = objAlumnoBE.Paterno_alumno;
                objAlumnoActualizar.ape_materno = objAlumnoBE.Materno_alumno;
                objAlumnoActualizar.doc_alumno = objAlumnoBE.Documento_alumno;
                objAlumnoActualizar.fech_nac_alumno = Convert.ToDateTime(objAlumnoBE.Fecha_nacimiento_alumno);
                objAlumnoActualizar.telf_alumno = Convert.ToInt32(objAlumnoBE.Telefono_alumno);
                objAlumnoActualizar.dir_alumno = objAlumnoBE.Dirección_alumno;
                objAlumnoActualizar.correo_alumno = objAlumnoBE.Correo_alumno;
                objAlumnoActualizar.genero = Convert.ToString(objAlumnoBE.Genero_alumno);
                objAlumnoActualizar.estado_alumno = Convert.ToBoolean(objAlumnoBE.Estado_alumno);

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
