using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Models
{
    [Table("MateriaEstudiante")]
    public partial class MateriaEstudiante
    {
        public int ID { get; set; }

        public int MateriaID { get; set; }

        public int EstudianteID { get; set; }

        public virtual Estudiante Estudiante { get; set; }

        public virtual Materia Materia { get; set; }
    }
}
