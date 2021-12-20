using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Notas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCurso" in both code and config file together.
    [ServiceContract]
    public interface IServicioCurso
    {
        [OperationContract]
        List<CursoBE> GetAllCurso();
    }

    public class CursoBE
    {
        Int32 id_curso;
        String nom_curso;
        Boolean estado_curso;

        [DataMember]
        public int Id_curso { get => id_curso; set => id_curso = value; }
        [DataMember]
        public string Nom_curso { get => nom_curso; set => nom_curso = value; }
        [DataMember]
        public bool Estado_curso { get => estado_curso; set => estado_curso = value; }
    }
}
