using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiHanh_21.Models
{
     [Table("SinhVIen")]
        public class sinhVIen
        {
            [Key]
            public string Masinhvien { get; set; }
            [MaxLength(20)]
            public string HoTen { get; set; }
             public int MaLop { get; set;  }


        }
    }
