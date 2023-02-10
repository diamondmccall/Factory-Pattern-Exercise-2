using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPatternExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to your SQL Database");
        }


        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your SQL Database. . .");

            return new List<Product>()
            {
                new Product() { Name = "Pearl Jam Ten", Price = 12.99m },
                new Product() { Name = "Megaman X Collection", Price = 59.99m },
                new Product() { Name = "Keyboard", Price = 120.99m },
                new Product() { Name = "Monitor", Price = 159.99m },
                new Product() { Name = "Mouse", Price = 65.99m },
                new Product() { Name = "Desk", Price = 250.99m },
                new Product() { Name = "Power Supply", Price = 120.99m }
            };
        }
    }
}
