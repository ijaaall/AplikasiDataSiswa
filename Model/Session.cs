using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiDataSiswa.Model
{
   public class Session
    {
        [Key]
        public static int OperatorId { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
    }
}
