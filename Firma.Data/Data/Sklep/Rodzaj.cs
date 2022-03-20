using System.ComponentModel.DataAnnotations;

namespace Firma.Data.Data.Sklep;

public class Rodzaj
{
    [Key] public int IdRodzaju { get; set; }

    [Required(ErrorMessage = "Wpisz nazwę rodzaju")]
    [MaxLength(20, ErrorMessage = "Rodzaj powinien zawierać max 20 znaków")]
    public string Nazwa { get; set; }

    public string Opis { get; set; }
    public List<Towar> Towar { get; set; }
}