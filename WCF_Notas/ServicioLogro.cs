using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioLogro" in both code and config file together.
    public class ServicioLogro : IServicioLogro
    {
        public Boolean InsertLogro(LogroBE objLogroBE)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Creamos la instancia del nuevo vendedor

                LOGRO objNuevoLogro = new LOGRO();
                //Asignamos las propiedades al nuevo vendedor, desde el parametro ObjVendeor
                objNuevoLogro.id_logro = 0;
                objNuevoLogro.fecha_logo = Convert.ToDateTime(objLogroBE.Fecha_logro);
                objNuevoLogro.competicion = objLogroBE.Competicion;
                objNuevoLogro.descripcion = objLogroBE.Descripcion;
                objNuevoLogro.id_alumno = Convert.ToInt32(objLogroBE.Id_alumno);
                objNuevoLogro.id_año = Convert.ToInt32(objLogroBE.Id_año);

                //Agregamos la nueva instancia a la clase TB_Vendedor
                Secundaria.LOGRO.Add(objNuevoLogro);

                //Se graba el modelo
                Secundaria.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
        public Boolean UpdateLogro(LogroBE objLogroBE)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Obtenemos con LINQ la instancia del vendedor a actualizar

                LOGRO objLogroActualizar = (from objLogro in Secundaria.LOGRO
                                            where objLogro.id_logro == objLogroBE.Id_logro
                                            select objLogro).FirstOrDefault();
                //Ya identificando el vendedor a actualizar...

                //Asignamos las propiedades a la instancia de vendedor objVendedorActualizar, desde el parametro ObjVendeor
                objLogroActualizar.id_logro = Convert.ToInt32(objLogroBE.Id_logro);
                objLogroActualizar.fecha_logo = Convert.ToDateTime(objLogroBE.Fecha_logro);
                objLogroActualizar.competicion = objLogroBE.Competicion;
                objLogroActualizar.descripcion = objLogroBE.Descripcion;
                objLogroActualizar.id_alumno = Convert.ToInt32(objLogroBE.Id_alumno);
                objLogroActualizar.id_año = Convert.ToInt32(objLogroBE.Id_año);

                //Grabamos el modelo
                Secundaria.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
        public Boolean DeleteLogro(Int32 strCod)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Obtenemos con LINQ la instancia del vendedor a actualizar

                LOGRO objLogroEliminar = (from objLogro in Secundaria.LOGRO
                                          where objLogro.id_logro == strCod
                                          select objLogro).FirstOrDefault();
                //Removemos al vendedor y grabamos el modelo
                Secundaria.LOGRO.Remove(objLogroEliminar);

                //Grabamos el modelo
                Secundaria.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);

            }

        }
        public LogroBE GetLogro(Int32 strCod)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();

            try
            {
                //Obtenemos con LINQ la instancia Vendedor

                LOGRO objLogroConsultar = (from objLogro in Secundaria.LOGRO
                                           where objLogro.id_logro == strCod
                                           select objLogro).FirstOrDefault();
                //Creamos una instancia del Vendedor para retornanr el resultado
                LogroBE objLogroBE = new LogroBE();

                objLogroBE.Id_logro = objLogroConsultar.id_logro;
                objLogroBE.Fecha_logro = Convert.ToDateTime(objLogroConsultar.fecha_logo);
                objLogroBE.Competicion = objLogroConsultar.competicion;
                objLogroBE.Descripcion = objLogroConsultar.descripcion;
                objLogroBE.Id_alumno = Convert.ToInt32(objLogroConsultar.id_alumno);
                objLogroBE.Id_año = Convert.ToInt32(objLogroConsultar.id_año);
                objLogroBE.ApeNom_Alumno = objLogroConsultar.ALUMNO.ape_paterno + " " + objLogroConsultar.ALUMNO.ape_materno + ", " + objLogroConsultar.ALUMNO.nom_alumno;


                return objLogroBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<LogroBE> GetAllLogro()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();

            try
            {

                List<LogroBE> objListaLogro = new List<LogroBE>();

                var query = (from objLogro in Secundaria.LOGRO
                             select objLogro);

                foreach (var objLogroConsultar in query)
                {
                    LogroBE objLogroBE = new LogroBE();

                    objLogroBE.Id_logro = objLogroConsultar.id_logro;
                    objLogroBE.Fecha_logro = Convert.ToDateTime(objLogroConsultar.fecha_logo);
                    objLogroBE.Competicion = objLogroConsultar.competicion;
                    objLogroBE.Descripcion = objLogroConsultar.descripcion;
                    objLogroBE.Id_alumno = Convert.ToInt32(objLogroConsultar.id_alumno);
                    objLogroBE.Id_año = Convert.ToInt32(objLogroConsultar.id_año);
                    objLogroBE.ApeNom_Alumno = objLogroConsultar.ALUMNO.ape_paterno + " " + objLogroConsultar.ALUMNO.ape_materno + ", " + objLogroConsultar.ALUMNO.nom_alumno;

                    objListaLogro.Add(objLogroBE);
                }


                return objListaLogro;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
