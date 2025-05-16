using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Student
{
    public class StudentModel : PageModel
    {
        [Authorize]

        public void OnGet()
        {
        }
    }
}
