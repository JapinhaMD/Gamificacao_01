﻿using JRJ.Modas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace JRJ.Modas
    {
        public class ProdutoModel
        {
            public long? ProdutoID { get; set; }
            public string Descricao { get; set; } = string.Empty;
            public string Nome { get; set; } = string.Empty;
            public double Preco { get; set; }
            public CategoriaModel? Categoria { get; set; }
        }
    }

