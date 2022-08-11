namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Donation
    {
        [Key]
        public int DONATION_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        public int AMOUNT { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE { get; set; }
    }
}
