

namespace Generics_Collections.Models.Interfaces
{
    public interface      ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id = null);
        List<Customer> GetAllByAge(int age);

        int GetCount();       
    }
}
