namespace web.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dangky")]
    public partial class Dangky
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Dangky()
        //{
        //    Users = new HashSet<User>();
        //}

        [Key]
        public int maUser { get; set; }

        public int? sdt { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string tenBe { get; set; }

        public int? tongDiem { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<User> Users { get; set; }
    }
}
