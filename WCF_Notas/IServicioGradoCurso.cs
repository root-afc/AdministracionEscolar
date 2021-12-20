using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGradoCurso" in both code and config file together.
    [ServiceContract]
    public interface IServicioGradoCurso
    {
        [OperationContract]
        Boolean InsertGradoCurso(GradoCursoBE objGradoCursoBE);
        [OperationContract]
        Boolean UpdateGradoCurso(GradoCursoBE objGradoCursoBE);
        [OperationContract]
        Boolean DeleteGradoCurso(Int32 id_grado, Int32 id_curso);
        [OperationContract]
        GradoCursoBE GetGradoCurso(Int32 id_grado, Int32 id_curso);
        [OperationContract]
        List<GradoCursoBE> GetAllGradoCurso();
    }

    [DataContract]
    [Serializable]
    public class GradoCursoBE
    {
        private Int32 id_grado;
        private Int32 id_curso;
        private Int32 horas_dictadas;
        private bool estado_gra_cur;


        [DataMember]
        public int Id_grado { get => id_grado; set => id_grado = value; }
        [DataMember]
        public int Id_curso { get => id_curso; set => id_curso = value; }
        [DataMember]
        public int Horas_dictadas { get => horas_dictadas; set => horas_dictadas = value; }
        [DataMember]
        public bool Estado_gra_cur { get => estado_gra_cur; set => estado_gra_cur = value; }
    }
}
