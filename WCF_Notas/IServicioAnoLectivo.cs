using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioAnoLectivo" in both code and config file together.
    [ServiceContract]
    public interface IServicioAnoLectivo
    {
        [OperationContract]
        Boolean InsertAñoLectivo(AñoLectivoBE objAñoLectivoBE);
        [OperationContract]
        Boolean UpdateAñoLectivo(AñoLectivoBE objAñoLectivoBE);
        [OperationContract]
        Boolean DeleteAñoLectivo(Int32 id_año);
        [OperationContract]
        AñoLectivoBE GetAñoLectivo(Int32 id_año);
        [OperationContract]
        List<AñoLectivoBE> GetAllAñoLectivo();
    }

    [DataContract]
    [Serializable]
    public class AñoLectivoBE
    {
        private Int32 id_año;
        private DateTime inicio_año;
        private DateTime fin_año;
        private bool estado_año;


        [DataMember]
        public int Id_año { get => id_año; set => id_año = value; }
        [DataMember]
        public DateTime Inicio_año { get => inicio_año; set => inicio_año = value; }
        [DataMember]
        public DateTime Fin_año { get => fin_año; set => fin_año = value; }
        [DataMember]
        public bool Estado_año { get => estado_año; set => estado_año = value; }
    }
}
