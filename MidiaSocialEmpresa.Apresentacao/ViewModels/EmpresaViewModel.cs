﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        public int IdUsuario { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCriacao { get; set; }

        public IEnumerable<ProfissionalViewModel> Profissionais { get; set; }
        public IEnumerable<ProjetoViewModel> Projetos { get; set; }
    }
}