using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioSeccion" in both code and config file together.
    public class ServicioSeccion : IServicioSeccion
    {
        bool IServicioSeccion.DeleteSeccion(int id_seccion)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                SECCION objEliminar = (from objSeccion in Secundaria.SECCION
                                       where objSeccion.id_seccion == id_seccion
                                       select objSeccion).FirstOrDefault();

                Secundaria.SECCION.Remove(objEliminar);
                Secundaria.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }


        List<SeccionBE> IServicioSeccion.GetAllSeccion()
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                List<SeccionBE> objLista = new List<SeccionBE>();
                var query = (from objSeccion in Secundaria.SECCION
                             select objSeccion).Take(100);

                foreach (var objGrdiCursoConsultar in query)
                {

                    SeccionBE objSeccionBE = new SeccionBE();

                    objSeccionBE.Id_seccion = objGrdiCursoConsultar.id_seccion;
                    objSeccionBE.Cod_seccion = Convert.ToChar(objGrdiCursoConsultar.cod_seccion);


                    objLista.Add(objSeccionBE);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        SeccionBE IServicioSeccion.GetSeccion(int id_seccion)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                SECCION objSeccionConsultar = (from objSeccion in Secundaria.SECCION
                                               where objSeccion.id_seccion == id_seccion
                                               select objSeccion).FirstOrDefault();

                SeccionBE objSeccionBE = new SeccionBE();

                objSeccionBE.Id_seccion = objSeccionConsultar.id_seccion;
                objSeccionBE.Cod_seccion = Convert.ToChar(objSeccionConsultar.cod_seccion);


                return objSeccionBE;

            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        bool IServicioSeccion.InsertSeccion(SeccionBE objSeccionBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                SECCION objSeccionInsertar = new SECCION();

                objSeccionInsertar.id_seccion = objSeccionBE.Id_seccion;
                objSeccionInsertar.cod_seccion = Convert.ToString(objSeccionBE.Cod_seccion);


                Secundaria.SECCION.Add(objSeccionInsertar);
                Secundaria.SaveChanges();
                return true;

            }

            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        bool IServicioSeccion.UpdateSeccion(SeccionBE objSeccionBE)
        {
            SecundariaEntities Secundaria = new SecundariaEntities();
            try
            {
                SECCION objSeccionActualizar = (from objSeccion in Secundaria.SECCION
                                                where objSeccion.id_seccion == objSeccionBE.Id_seccion
                                                select objSeccion).FirstOrDefault();

                objSeccionActualizar.id_seccion = objSeccionBE.Id_seccion;
                objSeccionActualizar.cod_seccion = Convert.ToString(objSeccionBE.Cod_seccion);



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
