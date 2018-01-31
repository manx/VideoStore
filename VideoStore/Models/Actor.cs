﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
    }
}
