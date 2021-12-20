using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;


namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioAnoLectivo" in both code and config file together.
    public class ServicioAnoLectivo : IServicioAnoLectivo
    {
        bool IServicioAnoLectivo.DeleteAñoLectivo(int id_año)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                AÑO_LECTIVO objEliminar = (from objAñoLectivo in Secundaria.AÑO_LECTIVO
                                           where objAñoLectivo.id_año == id_año
                                           select objAñoLectivo).FirstOrDefault();

                Secundaria.AÑO_LECTIVO.Remove(objEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }


        List<AñoLectivoBE> IServicioAnoLectivo.GetAllAñoLectivo()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<AñoLectivoBE> objLista = new List<AñoLectivoBE>();
                var query = (from objAñoLectivo in Secundaria.AÑO_LECTIVO
                             select objAñoLectivo).Take(100);

                foreach (var objGrdiCursoConsultar in query)
                {

                    AñoLectivoBE objAñoLectivoBE = new AñoLectivoBE();
                    objAñoLectivoBE.Id_año = objGrdiCursoConsultar.id_año;
                    objAñoLectivoBE.Inicio_año = Convert.ToDateTime(objGrdiCursoConsultar.inicio_año);
                    objAñoLectivoBE.Fin_año = Convert.ToDateTime(objGrdiCursoConsultar.fin_año);
                    objAñoLectivoBE.Estado_año = Convert.ToBoolean(objGrdiCursoConsultar.estado_año);

                    objLista.Add(objAñoLectivoBE);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        AñoLectivoBE IServicioAnoLectivo.GetAñoLectivo(int id_año)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                AÑO_LECTIVO objAñoLectivoConsultar = (from objAñoLectivo in Secundaria.AÑO_LECTIVO
                                                      where objAñoLectivo.id_año == id_año
                                                      select objAñoLectivo).FirstOrDefault();

                AñoLectivoBE objAñoLectivoBE = new AñoLectivoBE();

                objAñoLectivoBE.Id_año = objAñoLectivoConsultar.id_año;
                objAñoLectivoBE.Inicio_año = Convert.ToDateTime(objAñoLectivoConsultar.inicio_año);
                objAñoLectivoBE.Fin_año = Convert.ToDateTime(objAñoLectivoConsultar.fin_año);
                objAñoLectivoBE.Estado_año = Convert.ToBoolean(objAñoLectivoConsultar.estado_año);

                return objAñoLectivoBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        bool IServicioAnoLectivo.InsertAñoLectivo(AñoLectivoBE objAñoLectivoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                AÑO_LECTIVO objAñoLectivoInsertar = new AÑO_LECTIVO();

                objAñoLectivoInsertar.id_año = objAñoLectivoBE.Id_año;
                objAñoLectivoInsertar.inicio_año = Convert.ToDateTime(objAñoLectivoBE.Inicio_año);
                objAñoLectivoInsertar.fin_año = Convert.ToDateTime(objAñoLectivoBE.Fin_año);
                objAñoLectivoInsertar.estado_año = Convert.ToBoolean(objAñoLectivoBE.Estado_año);

                Secundaria.AÑO_LECTIVO.Add(objAñoLectivoInsertar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioAnoLectivo.UpdateAñoLectivo(AñoLectivoBE objAñoLectivoBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                AÑO_LECTIVO objAñoLectivoActualizar = (from objAñoLectivo in Secundaria.AÑO_LECTIVO
                                                       where objAñoLectivo.id_año == objAñoLectivoBE.Id_año
                                                       select objAñoLectivo).FirstOrDefault();

                objAñoLectivoActualizar.id_año = objAñoLectivoBE.Id_año;
                objAñoLectivoActualizar.inicio_año = Convert.ToDateTime(objAñoLectivoBE.Inicio_año);
                objAñoLectivoActualizar.fin_año = Convert.ToDateTime(objAñoLectivoBE.Fin_año);
                objAñoLectivoActualizar.estado_año = Convert.ToBoolean(objAñoLectivoBE.Estado_año);


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
