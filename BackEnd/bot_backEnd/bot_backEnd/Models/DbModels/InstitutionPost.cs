﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class InstitutionPost
    {
        public int Id { get; set; }
        public int InstitutionID { get; set; }
        public int PostID { get; set; }
        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("id")]
        public virtual Post UserPost { get; set; }

        [ForeignKey("id")]
        public virtual Institution Institution { get; set; }
    }
}
