using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactForm? Form { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Si la validación falla, se vuelve a mostrar el formulario
                return Page();
            }

            // Simula envío del mensaje
            TempData["Message"] = "✅ Mensaje enviado (simulado).";

            // Redirige de nuevo a la página principal
            return RedirectToPage("/Index");
        }
    }

    // Clase anidada que representa los datos del formulario
    public class ContactForm
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "El mensaje no puede estar vacío")]
        public string Message { get; set; } = "";
    }
}
