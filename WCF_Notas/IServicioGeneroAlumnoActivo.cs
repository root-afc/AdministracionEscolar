using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGeneroAlumnoActivo" in both code and config file together.
    [ServiceContract]
    public interface IServicioGeneroAlumnoActivo
    {
        [OperationContract]
        List<GeneroAlumnoActivo> GetGeneroAlumnoActivos();
    }

    public class GeneroAlumnoActivo
    {
        private String genero;
        private Int32 activo;

        
        public int Activo { get => activo; set => activo = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
