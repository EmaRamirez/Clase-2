using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [BindProperty]// lo que viaja atravez de la llamada post, mapealo con esta propiedad
    public Form Data { get; set; }

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametro1"];

        Data = new Form();

        Data.mail = "emanuelramirez169@gmail.com";
        Data.password = 1234;
    }

    public IActionResult OnPost()
    {
        //verificamos si es valido el formulario
        if (ModelState.IsValid)
        {
            var formValues = Data;
            //guardar en la base de datos

        }
        else
        {
            return Page();
        }
        //return RedirectToAction("Get");
        return RedirectToPage("Index");

    }
}

