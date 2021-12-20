using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGrado" in both code and config file together.
    [ServiceContract]
    public interface IServicioGrado
    {
        [OperationContract]
        List<GradoBE> GetAllGrado();
    }

    public class GradoBE
    {
        Int32 id_grado;
        String nombre_grado;

        [DataMember]
        public int Id_grado { get => id_grado; set => id_grado = value; }
        [DataMember]
        public string Nombre_grado { get => nombre_grado; set => nombre_grado = value; }
    }
}
