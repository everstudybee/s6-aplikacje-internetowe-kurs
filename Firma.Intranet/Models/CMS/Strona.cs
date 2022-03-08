using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.CMS
{
    public class Strona
    {
        [Key]
        public int IdStrony { get; set; }
        
        [Required(ErrorMessage = "Wpisz tytuł odnośnika")]
        [MaxLength(10, ErrorMessage = "Tytuł powinien zawierać max. 10 znaków")]
        [Display(Name = "Tytuł odnośnika")]
        public string LinkTytulu { get; set; }


        public string Tytul { get; set; }
        public string Tresc { get; set; }
        public int Pozycja { get; set; }
    }
}
