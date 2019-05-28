namespace WheyStore.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal? ProductPrice { get; set; }
    }
}
