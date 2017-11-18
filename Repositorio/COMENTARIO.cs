namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMENTARIO")]
    public partial class COMENTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMENTARIO()
        {
            USUARIO1 = new HashSet<USUARIO>();
        }

        [Key]
        public long ID_COMENTARIO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRICAO { get; set; }

        public long ID_USUARIO_CRIADOR { get; set; }

        public long ID_POSTAGEM { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        public virtual POSTAGEM POSTAGEM { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO1 { get; set; }
    }
}
