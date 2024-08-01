using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Models
{
    [Table("Estudiante")]
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            MateriaEstudiante = new HashSet<MateriaEstudiante>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public DateTime? FechaInscripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriaEstudiante> MateriaEstudiante { get; set; }
    }
}
