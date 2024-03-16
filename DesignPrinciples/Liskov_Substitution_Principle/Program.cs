namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cloud cloud1 = new AWS();
            cloud1.MachineLearning();
            (cloud1 as ITranslate)?.Translate();

            Cloud cloud2 = new Google();
            cloud2.MachineLearning();
            (cloud2 as ITranslate)?.Translate();

            Cloud cloud3 = new Azure();
            cloud3.MachineLearning();
            (cloud3 as ITranslate)?.Translate();

        }
    }

    interface ITranslate
    {
        void Translate();
    }

    abstract class Cloud
    {       
        public abstract void MachineLearning();      
    }
    class AWS : Cloud, ITranslate
    {
        public void Translate()
            => Console.WriteLine("AWS Translate");
        override public void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    class Azure : Cloud
    {
        override public void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    class Google : Cloud , ITranslate
    {
        public void Translate()
            => Console.WriteLine("Google Translate");

        override public void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }
}
