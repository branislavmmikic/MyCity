using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class Rank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartPoint { get; set; }
        public int? EndPoint { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}
