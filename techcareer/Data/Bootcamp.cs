using System.ComponentModel.DataAnnotations;

namespace techcareer.Data{

    public class Bootcamp{

        [Key]
        public int BootcampId {get;set;}
        public string? Baslik {get;set;}
    }
}