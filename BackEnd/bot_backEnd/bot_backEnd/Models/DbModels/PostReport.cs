﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class PostReport
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public int SenderID { get; set; }
        public int ReportedUserID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public bool Read { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [ForeignKey("SenderID")]
        public User Sender { get; set; }
        [ForeignKey("ReportedUserID")]
        public User ReportedUser { get; set; }
    }
}