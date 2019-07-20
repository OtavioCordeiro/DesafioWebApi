using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.Abstrato.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        void Add(T entity);

        IEnumerable<T> Get();

        T Get(int Id);

        void Update(T entity);

        void Delete(T entity);
    }
}
