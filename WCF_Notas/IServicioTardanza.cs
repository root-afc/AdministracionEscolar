using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioTardanza" in both code and config file together.
    [ServiceContract]
    public interface IServicioTardanza
    {
        [OperationContract]
        Boolean InsertTardanza(TardanzaBE objTardanzaBE);
        [OperationContract]
        Boolean UpdateTardanza(TardanzaBE objTardanzaBE);
        [OperationContract]
        Boolean DeleteTardanza(DateTime fecha_tardanza, Int32 id_alumno, Int32 id_año);
        [OperationContract]
        TardanzaBE GetTardanza(DateTime fecha_tardanza, Int32 id_alumno, Int32 id_año);
        [OperationContract]
        List<TardanzaBE> GetAllTardanza();
    }

    [DataContract]
    [Serializable]
    public class TardanzaBE
    {
        private DateTime fecha_tardanza;
        private Int32 id_alumno;
        private Int32 id_año;
        private Int32 minutos_tardanza;
        private String justificacion;
        private String apenom_alumno;

        [DataMember]
        public DateTime Fecha_tardanza
        {
            get { return fecha_tardanza; }
            set { fecha_tardanza = value; }
        }
        [DataMember]
        public Int32 Id_alumno
        {
            get { return id_alumno; }
            set { id_alumno = value; }
        }

        [DataMember]
        public Int32 Id_año
        {
            get { return id_año; }
            set { id_año = value; }
        }

        [DataMember]
        public Int32 Minutos_tardanza
        {
            get { return minutos_tardanza; }
            set { minutos_tardanza = value; }
        }

        [DataMember]
        public String Justificacion
        {
            get { return justificacion; }
            set { justificacion = value; }
        }
        [DataMember]
        public String ApeNom_Alumno
        {
            get { return apenom_alumno; }
            set { apenom_alumno = value; }
        }
    }
}
