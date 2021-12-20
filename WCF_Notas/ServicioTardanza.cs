using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioTardanza" in both code and config file together.
    public class ServicioTardanza : IServicioTardanza
    {
        public Boolean InsertTardanza(TardanzaBE objTardanzaBE)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Creamos la instancia del nuevo vendedor

                TARDANZA objNuevaTardanza = new TARDANZA();
                //Asignamos las propiedades al nuevo vendedor, desde el parametro ObjVendeor
                objNuevaTardanza.fecha_tardanza = Convert.ToDateTime(objTardanzaBE.Fecha_tardanza);
                objNuevaTardanza.id_alumno = Convert.ToInt32(objTardanzaBE.Id_alumno);
                objNuevaTardanza.id_año = Convert.ToInt32(objTardanzaBE.Id_año);
                objNuevaTardanza.minutos_tardanza = Convert.ToInt32(objTardanzaBE.Minutos_tardanza);
                objNuevaTardanza.justificacion = objTardanzaBE.Justificacion;


                //Agregamos la nueva instancia a la clase TB_Vendedor
                Secundaria.TARDANZA.Add(objNuevaTardanza);

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
        public Boolean UpdateTardanza(TardanzaBE objTardanzaBE)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Obtenemos con LINQ la instancia del vendedor a actualizar

                TARDANZA objTardanzaActualizar = (from objTardanza in Secundaria.TARDANZA
                                                  where objTardanza.fecha_tardanza == objTardanzaBE.Fecha_tardanza.Date
                                                  where objTardanza.id_alumno == objTardanzaBE.Id_alumno
                                                  where objTardanza.id_año == objTardanzaBE.Id_año
                                                  select objTardanza).FirstOrDefault();
                //Ya identificando el vendedor a actualizar...

                //Asignamos las propiedades a la instancia de vendedor objVendedorActualizar, desde el parametro ObjVendeor
                objTardanzaActualizar.fecha_tardanza = Convert.ToDateTime(objTardanzaBE.Fecha_tardanza).Date;
                objTardanzaActualizar.id_alumno = Convert.ToInt32(objTardanzaBE.Id_alumno);
                objTardanzaActualizar.id_año = Convert.ToInt32(objTardanzaBE.Id_año);
                objTardanzaActualizar.minutos_tardanza = Convert.ToInt32(objTardanzaBE.Minutos_tardanza);
                objTardanzaActualizar.justificacion = objTardanzaBE.Justificacion;

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
        public Boolean DeleteTardanza(DateTime fecha_tardanza, Int32 id_alumno, Int32 id_año)
        {
            //Instanciamos el modelo
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                //Obtenemos con LINQ la instancia del vendedor a actualizar

                TARDANZA objTardanzaEliminar = (from objTardanza in Secundaria.TARDANZA
                                                where objTardanza.fecha_tardanza == fecha_tardanza.Date
                                                where objTardanza.id_alumno == id_alumno
                                                where objTardanza.id_año == id_año
                                                select objTardanza).FirstOrDefault();
                //Removemos al vendedor y grabamos el modelo
                Secundaria.TARDANZA.Remove(objTardanzaEliminar);

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
        public TardanzaBE GetTardanza(DateTime fecha_tardanza, Int32 id_alumno, Int32 id_año)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();

            try
            {
                //Obtenemos con LINQ la instancia Vendedor

                TARDANZA objTardanzaConsultar = (from objTardanza in Secundaria.TARDANZA
                                                 where objTardanza.fecha_tardanza == fecha_tardanza.Date
                                                 where objTardanza.id_alumno == id_alumno
                                                 where objTardanza.id_año == id_año
                                                 select objTardanza).FirstOrDefault();
                //Creamos una instancia del Vendedor para retornanr el resultado
                TardanzaBE objTardanzaBE = new TardanzaBE();

                objTardanzaBE.Fecha_tardanza = Convert.ToDateTime(objTardanzaConsultar.fecha_tardanza).Date;
                objTardanzaBE.Id_alumno = Convert.ToInt32(objTardanzaConsultar.id_alumno);
                objTardanzaBE.Id_año = Convert.ToInt32(objTardanzaConsultar.id_año);
                objTardanzaBE.Minutos_tardanza = Convert.ToInt32(objTardanzaConsultar.minutos_tardanza);
                objTardanzaBE.Justificacion = objTardanzaConsultar.justificacion;
                objTardanzaBE.ApeNom_Alumno = objTardanzaConsultar.ALUMNO.ape_paterno + " " + objTardanzaConsultar.ALUMNO.ape_materno + ", " + objTardanzaConsultar.ALUMNO.nom_alumno;


                return objTardanzaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<TardanzaBE> GetAllTardanza()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();

            try
            {

                List<TardanzaBE> objListaTardanza = new List<TardanzaBE>();

                var query = (from objTardanza in Secundaria.TARDANZA
                             select objTardanza);

                foreach (var objTardanzaConsultar in query)
                {
                    TardanzaBE objTardanzaBE = new TardanzaBE();

                    objTardanzaBE.Fecha_tardanza = Convert.ToDateTime(objTardanzaConsultar.fecha_tardanza).Date;
                    objTardanzaBE.Id_alumno = Convert.ToInt32(objTardanzaConsultar.id_alumno);
                    objTardanzaBE.Id_año = Convert.ToInt32(objTardanzaConsultar.id_año);
                    objTardanzaBE.Minutos_tardanza = Convert.ToInt32(objTardanzaConsultar.minutos_tardanza);
                    objTardanzaBE.Justificacion = objTardanzaConsultar.justificacion;
                    objTardanzaBE.ApeNom_Alumno = objTardanzaConsultar.ALUMNO.ape_paterno + " " + objTardanzaConsultar.ALUMNO.ape_materno + ", " + objTardanzaConsultar.ALUMNO.nom_alumno;

                    objListaTardanza.Add(objTardanzaBE);
                }


                return objListaTardanza;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
