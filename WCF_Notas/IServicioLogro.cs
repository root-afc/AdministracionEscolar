using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioLogro" in both code and config file together.
    [ServiceContract]
    public interface IServicioLogro
    {
        [OperationContract]
        Boolean InsertLogro(LogroBE objLogroBE);
        [OperationContract]
        Boolean UpdateLogro(LogroBE objLogroBE);
        [OperationContract]
        Boolean DeleteLogro(Int32 id_logro);
        [OperationContract]
        LogroBE GetLogro(Int32 id_logro);
        [OperationContract]
        List<LogroBE> GetAllLogro();
    }

    [DataContract]
    [Serializable]
    public class LogroBE
    {
        private Int32 id_logro;
        private DateTime fecha_logro;
        private String competicion;
        private String descripcion;
        private Int32 id_alumno;
        private Int32 id_año;
        private String apenom_alumno;



        [DataMember]
        public Int32 Id_logro
        {
            get { return id_logro; }
            set { id_logro = value; }
        }

        [DataMember]
        public DateTime Fecha_logro
        {
            get { return fecha_logro; }
            set { fecha_logro = value; }
        }


        [DataMember]
        public String Competicion
        {
            get { return competicion; }
            set { competicion = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        public String ApeNom_Alumno
        {
            get { return apenom_alumno; }
            set { apenom_alumno = value; }
        }
    }
}
