﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Articulo
    {
        public int Id {  get; set; }
        [DisplayName("Código De Articulo")]
        public string CodigoArticulo { get; set; }
        
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl {  get; set; } 

        public Marca Marca {  get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; } 

        



    }
}
