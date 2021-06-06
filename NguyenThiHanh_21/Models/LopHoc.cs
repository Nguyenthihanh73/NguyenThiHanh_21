using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiHanh_21.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }
        [MaxLength(50)]
        public string TenLop { get; set; }
        
    }
}