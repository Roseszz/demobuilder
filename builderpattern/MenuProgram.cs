using System;
using System.Collections.Generic;

namespace builderpattern
{
    public class ProductManager
    {
        private List<Computer> products;
        public ProductManager()
        {
            products = new List<Computer>();
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Product Management Program");
            System.Console.WriteLine("1. Add Parts");
            System.Console.WriteLine("2. Show Product"); 
            System.Console.WriteLine("3. Quit Program"); 
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddParts(); break;
                case 2: ShowProducts(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        private void ShowError()
        {
            System.Console.WriteLine("Invalid Choice!");
        }

        private void ShowProducts()
        {
            foreach(Computer p in products) 
            {
                p.ShowInfor();
            }
        }

        private void AddParts()
        {
            System.Console.Write("Enter CPU: ");
            string cpu = Console.ReadLine();

            System.Console.Write("Enter Graphic Card: ");
            string graphiccard = Console.ReadLine();
            System.Console.Write("Enter Hard Drive: ");
            string harddrive = Console.ReadLine();
            System.Console.Write("Enter Mainbroad: ");
            string mainbroad = Console.ReadLine();
            System.Console.Write("Enter RAM: ");
            string ram = Console.ReadLine();
            System.Console.Write("Enter Device Color: ");
            string color = Console.ReadLine();
            

            Computer p = new Computer(cpu, graphiccard, harddrive, mainbroad, ram, color);
            products.Add(p);
            System.Console.WriteLine("Product added successful!");
            System.Console.WriteLine("--------------------------------------------");
        }
    }
}