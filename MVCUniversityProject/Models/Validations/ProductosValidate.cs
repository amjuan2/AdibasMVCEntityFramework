using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUniversityProject.Models
{
    [MetadataType(typeof(productos.MetaData))]
    public partial class productos
    {
        sealed class MetaData
        {
            [Required]
            public string nombre;

            [Required]
            public string descripcion;
        }
    }
}