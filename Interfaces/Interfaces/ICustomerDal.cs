using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        // Dal = data access layer
        // Dal veri tabanı işlerini bu sınıfta yaparız

        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Add");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Add");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Add");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Delete");
        }

        public void Update()
        {
            Console.WriteLine("MySql Update");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        { 
            customerDal.Add();
        }
    }

}
