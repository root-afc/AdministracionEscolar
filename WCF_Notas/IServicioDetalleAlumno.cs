using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioDetalleAlumno" in both code and config file together.
    [ServiceContract]
    public interface IServicioDetalleAlumno
    {
        [OperationContract]
        Boolean InsertDetalleAlumno(DetalleAlumnoBE objDetalleAlumnoBE);
        [OperationContract]
        Boolean UpdateDetalleAlumno(DetalleAlumnoBE objDetalleAlumnoBE);
        [OperationContract]
        Boolean DeleteDetalleAlumno(Int32 id_alumno);
        [OperationContract]
        DetalleAlumnoBE GetDetalleAlumno(Int32 id_alumno);
        [OperationContract]
        List<DetalleAlumnoBE> GetAllDetalleAlumno();
    }

    [DataContract]
    [Serializable]

    public class DetalleAlumnoBE
    {
        private Int32 id_alumno;
        private Int32 id_ano;
        private String comportamiento_alumno;
        private bool aprobo_grado;
        private Int32 id_grado;
        private Int32 id_seccion;
        [DataMember]
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        [DataMember]
        public int Id_ano { get => id_ano; set => id_ano = value; }
        [DataMember]
        public string Comportamiento_alumno { get => comportamiento_alumno; set => comportamiento_alumno = value; }
        [DataMember]
        public bool Aprobo_grado { get => aprobo_grado; set => aprobo_grado = value; }
        [DataMember]
        public int Id_grado { get => id_grado; set => id_grado = value; }
        [DataMember]
        public int Id_seccion { get => id_seccion; set => id_seccion = value; }
    }
}
