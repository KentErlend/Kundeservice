﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QA
    {
        [Key]
        public long Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
