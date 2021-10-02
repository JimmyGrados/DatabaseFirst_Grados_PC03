using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst_Grados_PC03.Models
{
    public partial class Automovil
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public string Color { get; set; }
        public int CantidadDePuertas { get; set; }
    }
}
