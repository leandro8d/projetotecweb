namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POSTAGEM")]
    public partial class POSTAGEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POSTAGEM()
        {
            COMENTARIO = new HashSet<COMENTARIO>();
        }

        [Key]
        public long ID_POSTAGEM { get; set; }

        [Required]
        [StringLength(200)]
        public string TITULO { get; set; }

        [Required]
        [StringLength(800)]
        public string DESCRICAO { get; set; }

        public long ID_USUARIO_CRIADOR { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMENTARIO> COMENTARIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
