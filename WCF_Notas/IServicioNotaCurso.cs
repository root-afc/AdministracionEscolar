using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioNotaCurso" in both code and config file together.
    [ServiceContract]
    public interface IServicioNotaCurso
    {
        [OperationContract]
        Boolean InsertNotaCurso(NotaCursoBE objNotaCursoBE);
        [OperationContract]
        Boolean UpdateNotaCurso(NotaCursoBE objNotaCursoBE);
        [OperationContract]
        Boolean DeleteNotaCurso(Int32 id_alumno, Int32 id_curso);
        [OperationContract]
        NotaCursoBE GetNotaCurso(Int32 id_alumno, Int32 id_curso);
        [OperationContract]
        List<NotaCursoBE> GetAllNotaCurso();
    }

    [DataContract]
    [Serializable]
    public class NotaCursoBE
    {
        private Int32 id_alumno;
        private Int32 id_año;
        private Int32 id_grado;
        private Int32 id_curso;
        private Int32 trimestre_uno;
        private Int32 trimestre_dos;
        private Int32 trimestre_tres;
        private Int32 promedio;
        private bool aprobo_curso;

        [DataMember]
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        [DataMember]
        public int Id_año { get => id_año; set => id_año = value; }
        [DataMember]
        public int Id_grado { get => id_grado; set => id_grado = value; }
        [DataMember]
        public int Id_curso { get => id_curso; set => id_curso = value; }
        [DataMember]
        public int Trimestre_uno { get => trimestre_uno; set => trimestre_uno = value; }
        [DataMember]
        public int Trimestre_dos { get => trimestre_dos; set => trimestre_dos = value; }
        [DataMember]
        public int Trimestre_tres { get => trimestre_tres; set => trimestre_tres = value; }
        [DataMember]
        public int Promedio { get => promedio; set => promedio = value; }
        [DataMember]
        public bool Aprobo_curso { get => aprobo_curso; set => aprobo_curso = value; }
    }
}
