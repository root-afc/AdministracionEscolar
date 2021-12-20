using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioTopAlumno" in both code and config file together.
    [ServiceContract]
    public interface IServicioTopAlumno
    {
        [OperationContract]
        List<TopAlumnoBE> GetTopAlumno(Int32 id_año, Int32 id_grado, Int32 id_curso);
    }
    [DataContract]
    [Serializable]
    public class TopAlumnoBE
    {
        private String full_name_alumno;
        private Int32 documento_alumno;
        private Int32 telefono_alumno;
        private String correo_alumno;
        private String curso_alumno;


        [DataMember]
        public string Full_name_alumno { get => full_name_alumno; set => full_name_alumno = value; }
        [DataMember]
        public int Documento_alumno { get => documento_alumno; set => documento_alumno = value; }
        [DataMember]
        public int Telefono_alumno { get => telefono_alumno; set => telefono_alumno = value; }
        [DataMember]
        public string Correo_alumno { get => correo_alumno; set => correo_alumno = value; }
        [DataMember]
        public string Curso_alumno { get => curso_alumno; set => curso_alumno = value; }
    }
}
