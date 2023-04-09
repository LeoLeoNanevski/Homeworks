using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        public List<T> lista = new List<T>();

        public void Insert(T entity)
        {
            lista.Add(entity);
        }

        public T GetById(int id)
        {
            foreach (var entity in lista)
            {
                if (entity.Id == id)
                {
                    return entity;
                }
            }
            return null;
        }

        public void PrintAll()
        {
            foreach (var entity in lista)
            {
                Console.WriteLine($"{entity.Brand} {entity.Model} ({entity.Id})");
            }
        }
    }
}
