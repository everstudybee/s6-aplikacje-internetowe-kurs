using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Intranet.Models.CMS
{
    public class Aktualnosc
    {
        [Key]
        public int IdAktualnosci { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł odnośnika do aktualności")]
        [MaxLength(10, ErrorMessage = "Tytuł powinien zawierać max 10 znaków")]
        [Display(Name = "Tytuł odnośnika aktualności")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(30, ErrorMessage = "Tytuł aktualności powinien zawierać max 30 znaków")]
        [Display(Name = "Tytuł aktualności")]
        public string Tytul { get; set; }

        [Display(Name = "Treść aktualności")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania aktualności")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }

        // Pola dodatkowe, które powinny być w każdym projekcie
        // Można to zrobić na zasadzie dziedziczenia z klasy Record
        //    - Kto dodał
        //    - Kiedy dodał
        //    - Kto zmodyfikował
        //    - Kiedy zmodyfikował
        //    - Kto usunął
        //    - Kiedy usunął
        //    - Czy aktywny
    }
}
