using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCantidadAlumnosAño" in both code and config file together.
    [ServiceContract]
    public interface IServicioCantidadAlumnosAño
    {
        [OperationContract]
        List<CantidadAlumnoAño> GetCantidadAlumnoAño();
    }

    [DataContract]
    [Serializable]

    public class CantidadAlumnoAño
    {
        private Int32 año;
        private Int32 cantidad;

        [DataMember]
        public int Año { get => año; set => año = value; }
        [DataMember]
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
