﻿

using Generics_Collections.Models;
using System.Diagnostics.Contracts;

namespace Generics_Collections.Data
{
    public class AppDbContext
    {
        public static List<Customer> customers;
        static AppDbContext()
        {
            customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FullName = "Fexriyye Tagizade",
                    Address = "28 may",
                    Age = 21
                },

                new Customer
                {
                    Id = 2,
                    FullName = "Elmir Qafarzade",
                    Address = "Sahil",
                    Age = 21
                },

                new Customer
                {
                    Id = 3,
                    FullName = "Sirac Memmedov",
                    Address = "Masazir",
                    Age = 23
                },

                new Customer
                {
                    Id = 4,
                    FullName = "Reshad Agayev",
                    Address = "Nefciller",
                    Age = 21
                },

                new Customer
                {
                    Id = 5,
                    FullName = "Behruz Aliyev",
                    Address = "Kurdaxani",
                    Age = 33
                },

            };

        }

    }   
         
        
}
