

using Generics_Collections.Data;
using Generics_Collections.Models;
using Generics_Collections.Models.Interfaces;

namespace Generics_Collections.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> orderedword;

        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id = null)
        {

            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);

        }
        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(string oderedword)
        {
            List<Customer> word = new();

            switch (oderedword.Trim().ToLower())
            {
                case "ascending":
                    oderedword.AddRange (AppDbContext.customers.OrderBy(m => m.Age);
                    return oderedword;

                case "descending":
                    orderedword.AddRange(AppContext.customers.OrderByAge(m => m.Age));
                    return orderedword;

                default;
            
            
            }




        }
    }
}
