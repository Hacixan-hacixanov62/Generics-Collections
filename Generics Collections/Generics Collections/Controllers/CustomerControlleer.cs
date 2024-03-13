

using Generics_Collections.Models.Interfaces;
using Generics_Collections.Services;
using System.Security.Cryptography.X509Certificates;

namespace Generics_Collections.Controllers
{
    public class CustomerControlleer
    {
        private readonly ICustomerService _customerService;
        public CustomerControlleer()
        {
            _customerService = new CustomerService();   
        }
        public void GetAll()
        {

            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" +item.Age);

            }
        }

        public void GetById()
        {
            try
            {

                //int id = 4;
                var result = _customerService.GetById();
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public void GetAllByAge()
        {
            int age = 21;
            foreach (var item in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);

            }
        }

        public void GetAllCountOfDatas()
        {
            Console.WriteLine(_customerService.GetCount());

        }


    }
}
