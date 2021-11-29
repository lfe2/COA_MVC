using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoaMVC.Models
{
    public class Usuario{
       
        [Key]
        public int Id {get;set;}

        [Required]
        [StringLength(50)]
        [DisplayName("Usuario")]
        public string UserName{get;set;}

        [Required]
        [StringLength(100)]
        [DisplayName("Nombre y Apellido")]
        public string Nombre { get;set;}
        
        [Required]
        [EmailAddress]
        [StringLength(100)]
        [DisplayName("Dirección de E-Mail")]
        public string Email{ get;set;}

        [StringLength(100)]
        [DisplayName("Teléfono")]
        public string Telefono { get;set;}
    }
}