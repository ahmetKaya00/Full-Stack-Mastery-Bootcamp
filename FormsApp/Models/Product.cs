using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId {get;set;}

        [Display(Name="Ürün Adı")]
        [Required(ErrorMessage = "Gerekli bir Alan")]
        [StringLength(100)]
        public string? Name {get;set;} 

        [Display(Name="Ürün Fiyatı")]
        [Required(ErrorMessage = "Gerekli bir Alan")]
        [Range(0,1000000)]
        public decimal? Price {get;set;}

        [Display(Name="Ürün Görseli")]
        public string? Image {get;set;} = string.Empty;
        public bool IsActive {get;set;}
        [Required(ErrorMessage = "Gerekli bir Alan")]
        public int? CategoryId {get;set;}
    }
}