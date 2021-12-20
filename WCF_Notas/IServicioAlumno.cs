using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioAlumno" in both code and config file together.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        Boolean InsertAlumno(AlumnoBE objAlumnoBE);
        [OperationContract]
        Boolean UpdateAlumno(AlumnoBE objAlumnoBE);
        [OperationContract]
        Boolean DeleteAlumno(Int32 id_alumno);
        [OperationContract]
        AlumnoBE GetAlumno(Int32 id_alumno);
        [OperationContract]
        List<AlumnoBE> GetAllAlumno();

    }

    [DataContract]
    [Serializable]
    public class AlumnoBE
    {
        private Int32 id_alumno;
        private String nombre_alumno;
        private String paterno_alumno;
        private String materno_alumno;
        private Int32 documento_alumno;
        private DateTime fecha_nacimiento_alumno;
        private Int32 telefono_alumno;
        private String dirección_alumno;
        private String correo_alumno;
        private char genero_alumno;
        private bool estado_alumno;

        [DataMember]
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        [DataMember]
        public string Nombre_alumno { get => nombre_alumno; set => nombre_alumno = value; }

        [DataMember]
        public int Documento_alumno { get => documento_alumno; set => documento_alumno = value; }
        [DataMember]
        public DateTime Fecha_nacimiento_alumno { get => fecha_nacimiento_alumno; set => fecha_nacimiento_alumno = value; }
        [DataMember]
        public int Telefono_alumno { get => telefono_alumno; set => telefono_alumno = value; }
        [DataMember]
        public string Dirección_alumno { get => dirección_alumno; set => dirección_alumno = value; }
        [DataMember]
        public string Correo_alumno { get => correo_alumno; set => correo_alumno = value; }
        [DataMember]
        public char Genero_alumno { get => genero_alumno; set => genero_alumno = value; }
        [DataMember]
        public bool Estado_alumno { get => estado_alumno; set => estado_alumno = value; }
        [DataMember]
        public string Paterno_alumno { get => paterno_alumno; set => paterno_alumno = value; }
        [DataMember]
        public string Materno_alumno { get => materno_alumno; set => materno_alumno = value; }
    }
}
