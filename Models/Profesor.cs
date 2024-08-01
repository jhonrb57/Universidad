using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Models
{
    [Table("Profesor")]
    public partial class Profesor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesor()
        {
            MateriaProfesor = new HashSet<MateriaProfesor>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public DateTime? FechaContratacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriaProfesor> MateriaProfesor { get; set; }
    }
}
