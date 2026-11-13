using Microsoft.AspNetCore.Mvc;
using CRUD_Modulo9.Entities;
using CRUD_Modulo9.Services;

namespace CRUD_Modulo9.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpleadosController :  ControllerBase
{
    private readonly EmpleadoService _service;
    public EmpleadosController(EmpleadoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(
        _service.ObtenerTodas());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var persona =
        _service.ObtenerPorId(id);

        if (persona == null)
            return NotFound();

        return Ok(persona);
    }

    [HttpPost]
    public IActionResult Post(Empleado empleado)
    {
        _service.Insertar(empleado);

        return CreatedAtAction(nameof(Get), new { id = empleado.IdEmpleado }, empleado);
    }

    [HttpPut("{id}")]
    public IActionResult Put( int id, Empleado empleado)
    {
        if (id != empleado.IdEmpleado)
            return BadRequest();

        _service.Actualizar(empleado);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Eliminar(id);

        return NoContent();
    }

}
