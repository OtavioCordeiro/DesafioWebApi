using Desafio.Repositorio.Abstrato.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        public DesafioContexto Contexto { get; set; }

        public Repositorio(DesafioContexto desafioContexto)
        {
            Contexto = desafioContexto;
        }

        protected void Save() => Contexto.SaveChanges();

        public void Add(T entity)
        {
            Contexto.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            Contexto.Remove(entity);
            Save();
        }

        public IEnumerable<T> Get()
        {
            return Contexto.Set<T>();
        }

        public T Get(int Id)
        {
            return Contexto.Set<T>().Find(Id);
        }

        public void Update(T entity)
        {
            Contexto.Update(entity);
            Save();
        }
    }
}
