namespace Interface_Segragation_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamsungPrinter samsungPrinter = new SamsungPrinter();
            samsungPrinter.Print();
            HPPrinter hPPrinter = new HPPrinter();
            hPPrinter.Print();
            LexmarkPrinter lexmarkPrinter = new LexmarkPrinter();
            lexmarkPrinter.Print();
        }
    }

    interface IPrint
    {
        void Print();
    }

    interface IFax
    {
        void Fax();
    }

    interface IScan
    {
        void Scan();
    }

    interface IPrintDuplex
    {
        void PrintDuplex();
    }

    public class HPPrinter : IPrintDuplex, IFax, IScan, IPrint
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void PrintDuplex()
        {
            Console.WriteLine("PrintDuplex");
        }

        public void Scan()
        {
            Console.WriteLine("Scan");
        }
    }

    public class SamsungPrinter : IPrint, IFax
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }
    }

    public class LexmarkPrinter : IFax, IPrint, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scan()
        {
            Console.WriteLine("Scan");
        }
    }
}
