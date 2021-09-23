﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public int CursoID { get; set; }

        [ForeignKey("CursoID")]
        public virtual Curso Universidade { get; set; }
    }
}