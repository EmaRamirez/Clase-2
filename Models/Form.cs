using System.ComponentModel.DataAnnotations;

public class Form
{

    public Form()
    {

    }
    [Required]
    [EmailAddress]
    [Display(Name = "Correo Electronico")] // para ponerle esto en el label
    public string mail { get; set; }

    [Required]
    [Display(Name ="Contraseña")]
    public int password { get; set; }
}