using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogLib
{
    public class DogsRepository
    {
        private List<Dog> dogs = new List<Dog>();
        private int nextId = 4;

        public DogsRepository()
        {
            Add(new Dog { Id = 1, Name = "Fido", Age = 3 });
            Add(new Dog { Id = 2, Name = "Rex", Age = 5 });
            Add(new Dog { Id = 3, Name = "Spot", Age = 2 });
        }
        public List<Dog> GetAll(string? name = null, int age = 0)
        {
            var result = dogs.AsEnumerable();
            if(name != null)
            {
                result = dogs.Where(d => d.Name == name);
            }
            else if(age > 0)
            {
                result = dogs.Where(d => d.Age == age);
            }
            return result.ToList();
        }
        public Dog? GetById(int id)
        {
            Dog? dog = dogs.FirstOrDefault(d => d.Id == id);
            if (dog == null)
            {
                throw new ArgumentException("No dog found with the specified Id.");
            }
            return dog;
        }
        public Dog Add(Dog dog)
        {
            dog.Id = nextId++;
            dogs.Add(dog);
            return dog;
        }
        public Dog? Delete(int id)
        {
            Dog? dog = dogs.FirstOrDefault(d => d.Id == id);
            if (dog == null)
            {
                throw new ArgumentException("No dog found with the specified Id.");
            }
            dogs.Remove(dog);
            return dog;
        }

    }
}