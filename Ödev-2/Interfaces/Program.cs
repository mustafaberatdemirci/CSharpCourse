﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManger customerManger = new CustomerManger();
            //customerManger.Add(new SqlServerCustomerDal());
            customerManger.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Mustafa",
            //    LastName = "Demirci",
            //    Address = "Ankara"
            //};
            Student student = new Student()
            {
                Id = 1,
                FirstName = "mustafa",
                LastName = "demirci",
                Departmant = "Computer Sciences"
            };

            manager.Add(new Customer { Id = 1, FirstName = "Mustafa", LastName = "Demirci", Address = "Ankara" });
            manager.Add(student);
            manager.Add(new Worker { Id = 1, FirstName = "Berat", LastName = "Demirci", Departmant = "Computer Sciences" });
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}