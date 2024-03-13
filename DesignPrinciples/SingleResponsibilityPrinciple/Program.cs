namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.GetPersonList();

            PersonManager personManager = new PersonManager();
            personManager.GetPersonList();
        }
    }
    // Entity'ler sadece property tutarlar
    class Person
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public string Description { get; set; }

        //public void GetPersonList()
        //{
        //    Console.WriteLine("Person List");
        //}
    }

    class PersonManager
    {
        public void GetPersonList()
        {
            Console.WriteLine("Person List");
        }
    }
}
