using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.Entity;

namespace SistemVenta.DAL.Interfaces
{
    public interface IVentaRepository : IGenericRepositrory<Venta>
    {
        Task<Venta> Registrar(Venta entidad);
        Task<List<DetalleVenta>> Reporte(DateTime FechaInicio, DateTime FechaFin);
    }
}
