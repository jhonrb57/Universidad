namespace Universidad.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MateriaProfesor")]
    public partial class MateriaProfesor
    {
        public int ID { get; set; }

        public int MateriaID { get; set; }

        public int ProfesorID { get; set; }

        public virtual Materia Materia { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}
