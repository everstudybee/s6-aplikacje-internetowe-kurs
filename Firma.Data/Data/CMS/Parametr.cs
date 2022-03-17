using System.ComponentModel.DataAnnotations;

namespace Firma.Data.Data.CMS
{
    public class Parametr
    {
        [Key]
        public int IdParametru { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        public string Kod { get; set; } // do rozpoznawania pola

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa powinna zawierać max 30 znaków")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Wartość jest wymagana")]
        [Display(Name = "Wartość")]
        public string Wartosc { get; set; }
        public string Opis { get; set; }

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
