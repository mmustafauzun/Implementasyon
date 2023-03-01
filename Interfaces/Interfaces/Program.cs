using Interfaces;

namespace IInterfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // abstract ve interface gibi soyut nesneleri "new" lememiz mümkün değildir

            #region İnterFace

            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "DEMİROG",
            //    Address = "Ankara",
            //};

            //Student student = new Student
            //{
            //    Id = 2,
            //    FirstName = "Mustafa",
            //    LastName = "UZUN",
            //    Departmant = "Computer Sciences"

            //};

            //Worker worker = new Worker
            //{
            //    Id = 3,
            //    FirstName = "Kamil",
            //    LastName = "EYLER",
            //    Departmant = "Computer Technical"
            //};

            //manager.Add(customer);
            //manager.Add(student);
            //manager.Add(worker);

            #endregion

            #region ICustomerDal

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            #endregion

            #region MyRegion

            ICustomerDal[] customerDals = new ICustomerDal[3]
                { 
                    new SqlServerCustomerDal(),
                    new OracleCustomerDal(),
                    new MySqlCustomerDal(),
                };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            #endregion

        }
    }
    interface IPerson
    {
        // interface ler yazılırken tamamen metodun imzası, void varsa = void ,dönüş değeri , ismi ve özelliği yer alır.
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
            Console.WriteLine(person.Id);
            Console.WriteLine("-----");
            Console.WriteLine(person.FirstName);
            Console.WriteLine("----");
            Console.WriteLine(person.LastName);
            Console.WriteLine("----------");

        }
    }

}