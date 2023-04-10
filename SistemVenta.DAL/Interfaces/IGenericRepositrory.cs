using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace SistemVenta.DAL.Interfaces
{
    public interface IGenericRepositrory<TEntity> where TEntity : class
    {
        //Metodos asincronos que devuelven una entidad
        Task<TEntity> Obtener(Expression<Func<TEntity, bool>> filtro);
        Task<TEntity> Crear(TEntity entidad);
        Task<bool> Editar(TEntity entidad);
        Task<bool> Eliminar(TEntity entidad);
        Task<IQueryable<TEntity>> Consultar(Expression<Func<TEntity, bool>> filtro = null);
    }
}
