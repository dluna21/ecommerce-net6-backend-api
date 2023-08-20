using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Entidades
{
    
    public partial class OnlineShop
    {
        public OnlineShop() { 
        
        }
        public int OnlineShopId { get; set; }
        public int Anio { get; set; }
        public int Periodo { get; set; }
        public string Nombre { get; set; }
        public string BasesDocumentacion { get; set; }
        public DateTime BasesPublicacion { get; set; }
        public DateTime Registro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? Modificacion { get; set; }
        public String? UsuarioModificacion { get; set; }
    }
}
