using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUniversityProject.Models
{
    [MetadataType(typeof(clientes.MetaData))]
    public partial class clientes
    {
        sealed class MetaData
        {
            [Required]
            public string nombre;

            [Required]
            public string apellido;

            [Required]
            public string telefono;

            [Required]
            public string direccion;
        }
    }
}