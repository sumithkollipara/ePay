using CustomerManagement.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Test.Helpers
{
    public static class DataGenerator
    {
        public static List<string> GenerateLastName()
        {
            List<string> lastNames = new List<string> {
                "Liberty"
                ,"Ray"
                ,"Harrison"
                ,"Ronan"
                ,"Drew"
                ,"Powell"
                ,"Larsen"
                ,"Chan"
                ,"Anderson"
                ,"Lane"
            };
            return lastNames;
        }
        public static List<string> GenerateFirstName()
        {
            List<string> firstNames = new List<string> {
                 "Leia"
                ,"Sadie"
                ,"Jose"
                ,"Sara"
                ,"Frank"
                ,"Dewey"
                ,"Tomas"
                ,"Joel"
                ,"Lukas"
                ,"Carlos"
            };
            return firstNames;
        }
        public static List<CustomerModel> GenerateRandomCustomerObjects(List<string> firstNames, List<string> lastNames)
        {
            List<CustomerModel> lstCustomers = new List<CustomerModel>();

            List<int> randomIndecesFirstName = new List<int>();
            List<int> randomIndecesLastName = new List<int>();
            Random rnd = new Random();

            while (randomIndecesFirstName.Count != 10)
            {
                int num = rnd.Next(1, 11);
                if (!randomIndecesFirstName.Contains(num))
                {
                    randomIndecesFirstName.Add(num);
                }
            }

            while (randomIndecesLastName.Count != 10)
            {
                int num = rnd.Next(1, 11);
                if (!randomIndecesLastName.Contains(num))
                {
                    randomIndecesLastName.Add(num);
                }
            }


            for (int i = 0; i < firstNames.Count; i++)
            {
                CustomerModel model = new CustomerModel();
                model.Id = i + 1;
                model.FirstName = firstNames[i];
                model.LastName = lastNames[i];
                model.Age = rnd.Next(19, 50);
                lstCustomers.Add(model);
            }

            return lstCustomers;
        }
    }
}
