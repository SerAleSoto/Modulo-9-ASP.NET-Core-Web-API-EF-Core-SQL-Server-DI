using CRUD_Modulo9.Entities;
using CRUD_Modulo9.Repositories;

namespace CRUD_Modulo9.Services;

public class EmpleadoService
{
    private readonly EmpleadoRepository _repository;

    public EmpleadoService(
    EmpleadoRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Empleado> ObtenerTodas()
    {
        return _repository.GetAll();
    }

    public Empleado? ObtenerPorId(int id)
    {
        return _repository.GetById(id);
    }

    public void Insertar(Empleado empleado)
    {
        if (string.IsNullOrWhiteSpace(empleado.NombreCompleto))
        {
            throw new Exception(
            "Nombre obligatorio");
        }

        _repository.Add(empleado);  
        _repository.Save();
    }

    public void Actualizar(Empleado empleado)
    {
        _repository.Update(empleado);
        _repository.Save();
    }

    public void Eliminar(int id)
    {
        var empleado = _repository.GetById(id);

        if (empleado == null)
            return;

        _repository.Delete(empleado);

        _repository.Save();
    }

}
