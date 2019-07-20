using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        public DbContext Context { get; set; }

        public Repositorio(DbContext context)
        {
            Context = context;
        }

        protected void Save() => Context.SaveChanges();

        public void Add(T entity)
        {
            Context.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
            Save();
        }

        public IEnumerable<T> Get()
        {
            return Context.Set<T>();
        }

        public T Get(int Id)
        {
            return Context.Set<T>().Find(Id);
        }

        public void Update(T entity)
        {
            Context.Update(entity);
            Save();
        }
    }
}
