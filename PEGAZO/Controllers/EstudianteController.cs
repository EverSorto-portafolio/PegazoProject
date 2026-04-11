using Microsoft.AspNetCore.Mvc;

namespace PEGAZO.Controllers
{
    [Route("api/[controller]")]
    public class EstudianteController : Controller
    {
        [HttpPost("/CrearEstudiante")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
