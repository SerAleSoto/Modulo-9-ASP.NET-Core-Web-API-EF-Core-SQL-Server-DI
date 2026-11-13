using CRUD_Modulo9.Entities;
using CRUD_Modulo9.Data;

namespace CRUD_Modulo9.Repositories;

public class EmpleadoRepository : GenericRepository<Empleado>
{
    public EmpleadoRepository(AppDbContext context) : base(context)
    {
    }
}
    

