using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models
{
    public class UserLogin
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public int Parallelism { get; set; }
        public int Iterations { get; set; }
        public int Memory { get; set; }
    }
}
