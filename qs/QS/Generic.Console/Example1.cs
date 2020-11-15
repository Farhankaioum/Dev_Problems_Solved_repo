using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Console
{

    public class Example1 <T>
    {
        public T Id { get; set; }
    }

    public class User : IBaseInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Example2<TEntity, TKey> 
        where TEntity : class
    {
        public List<TEntity> Entities { get; set; }

        public Example2()
        {
            Entities = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void Remove(TEntity removeEntity)
        {
            Entities.Remove(removeEntity);
        }
    }

    public interface IBaseInterface
    {

    }

    public class Base
    {

    }

    public class Child : Base
    {

    }
    public class A : Child
    {

    }

    public class Example3<T, U>
        where T : IBaseInterface
        where U : Base, new()
         
    {
        public void Message()
        {
            System.Console.WriteLine("Message from example-3");
        }
    }

    public class Test
    {
        public void Tt()
        {
            var example3 = new Example3<User, A>();
            example3.Message();
        }
    }
}
