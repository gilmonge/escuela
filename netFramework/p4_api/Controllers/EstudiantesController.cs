using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace p4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {

        [HttpGet]
        public string GetEstudiantes()
        {
            return p3_logica.Logica.getEstudiantes();
        }

        [HttpGet("{id}")]
        public string GetEstudiante(int id)
        {
            return p3_logica.Logica.getEstudiante(id);
        }

        [HttpPost]
        public void PostEstudiante([FromBody] p1_Entity.EstudiantePutPost estudianteJson)
        {
            p3_logica.Logica.postEstudiante(estudianteJson);
        }

        [HttpDelete("{id}")]
        public void DeleteEstudiante(int id)
        {
             p3_logica.Logica.deleteEstudiante(id);
        }

        [HttpPut("{id}")]
        public void PutEstudiante(int id, [FromBody] p1_Entity.EstudiantePutPost estudianteJson)
        {
            p3_logica.Logica.putEstudiante(id, estudianteJson);
        }
    }
}
