using Microsoft.AspNetCore.Mvc;
using W01AssignmentNETApplications.Models;
using W01AssignmentNETApplications.Services;

namespace W01AssignmentNETApplications.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        // POST action

        // PUT action

        // DELETE action
    }
}
