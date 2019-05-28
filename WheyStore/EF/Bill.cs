namespace WheyStore.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public long ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phonenumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public bool? Payment { get; set; }

        [StringLength(10)]
        public string CreatedDate { get; set; }
    }
}
