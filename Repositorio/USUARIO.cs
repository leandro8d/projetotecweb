namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            COMENTARIO = new HashSet<COMENTARIO>();
            POSTAGEM = new HashSet<POSTAGEM>();
            COMENTARIO1 = new HashSet<COMENTARIO>();
        }

        [Key]
        public long ID_USUARIO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        public long ID_PERFIL { get; set; }

        [Required]
        [StringLength(80)]
        public string SENHA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMENTARIO> COMENTARIO { get; set; }

        public virtual PERFIL_USUARIO PERFIL_USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSTAGEM> POSTAGEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMENTARIO> COMENTARIO1 { get; set; }
    }
}
