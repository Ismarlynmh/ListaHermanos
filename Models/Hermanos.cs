using HermanosApi.DAL;
using HermanosApi.Models;
using System.ComponentModel.DataAnnotations;

namespace HermanosApi.Models{

    public class Hermanos{
        [Key]
        public String? ImagenUrl { get; set; }
        public String? Nombre { get; set; }
        public int Telefono { get; set; }
        public byte Edad { get; set; }
    }
 }