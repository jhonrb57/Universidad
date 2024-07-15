namespace Universidad.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Materia")]
    public partial class Materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materia()
        {
            MateriaEstudiante = new HashSet<MateriaEstudiante>();
            MateriaProfesor = new HashSet<MateriaProfesor>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MateriaID { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public int? Creditos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriaEstudiante> MateriaEstudiante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriaProfesor> MateriaProfesor { get; set; }
    }
}
