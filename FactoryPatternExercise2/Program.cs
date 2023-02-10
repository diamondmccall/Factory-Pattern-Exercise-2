using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Get database type from the user
            Console.WriteLine("What type of database do you want to use???");
            Console.WriteLine("Please enter: Regular or list for a static list.");
            Console.WriteLine("Please enter: Sql for a MySQL DB.");
            Console.WriteLine("Please enter: Mongo for a Mongo DB.");
            string ?dataBaseType = Console.ReadLine();

            
            IDataAccess da = DataAccessFactory.GetDataAccess(dataBaseType);

            
            List<Product> products = da.LoadData();
            da.SaveData();

            Console.WriteLine();

            

            Console.WriteLine("For loop:");
            Console.WriteLine();

            
            Console.WriteLine("Here are your products");
            for (int index = 0; index < products.Count; index++)
            {
                Console.WriteLine($"Product Name: {products[index].Name} | " +
                    $"Product Price: {products[index].Price,0:c}");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Foreach loop:");
            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }
        }
    }
}
