//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Notas
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALUMNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALUMNO()
        {
            this.DETALLE_ALUMNO = new HashSet<DETALLE_ALUMNO>();
            this.LOGRO = new HashSet<LOGRO>();
            this.NOTA_CURSO = new HashSet<NOTA_CURSO>();
            this.TARDANZA = new HashSet<TARDANZA>();
        }
    
        public int id_alumno { get; set; }
        public string nom_alumno { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public int doc_alumno { get; set; }
        public Nullable<System.DateTime> fech_nac_alumno { get; set; }
        public Nullable<int> telf_alumno { get; set; }
        public string dir_alumno { get; set; }
        public string correo_alumno { get; set; }
        public string genero { get; set; }
        public bool estado_alumno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ALUMNO> DETALLE_ALUMNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGRO> LOGRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTA_CURSO> NOTA_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARDANZA> TARDANZA { get; set; }
    }
}
