using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioSeccion" in both code and config file together.
    [ServiceContract]
    public interface IServicioSeccion
    {
        [OperationContract]
        Boolean InsertSeccion(SeccionBE objSeccionBE);
        [OperationContract]
        Boolean UpdateSeccion(SeccionBE objSeccionBE);
        [OperationContract]
        Boolean DeleteSeccion(Int32 id_seccion);
        [OperationContract]
        SeccionBE GetSeccion(Int32 id_seccion);
        [OperationContract]
        List<SeccionBE> GetAllSeccion();
    }

    [DataContract]
    [Serializable]
    public class SeccionBE
    {
        private Int32 id_seccion;
        private char cod_seccion;

        [DataMember]
        public int Id_seccion { get => id_seccion; set => id_seccion = value; }
        [DataMember]
        public char Cod_seccion { get => cod_seccion; set => cod_seccion = value; }

    }
}
