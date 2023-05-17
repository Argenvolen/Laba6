namespace Praktika6
{
    interface IParent
    {
        void Info();
        float Metod1();
        float Metod2();
    }
    class Child1: IParent
    {
        float pole1, pole2, pole3;
        public Child1(float pole1, float pole2, float pole3)
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
            this.pole3 = pole3;
        }
        public void Info()
        {
            Console.WriteLine($"a = {this.pole1}, b = {this.pole2}, c = {this.pole3}");
        }
        public float Metod1()
        {
            float SquareP = (float)(2*(this.pole1 * this.pole2 + this.pole2 * this.pole3 + this.pole1 * this.pole3));
            return SquareP;
            
        }
        public float Metod2()
        {
            float Volume = (float)(this.pole1*this.pole2*this.pole3);
            return Volume;
        }
    }
    class Child2 : IParent
    {
        float pole4, pole5;
        public Child2(float pole4, float pole5)
        {
            this.pole4 = pole4;
            this.pole5 = pole5;
        }
        public void Info()
        {
            Console.WriteLine($"r = {this.pole4}, h = {this.pole5}");
        }
        public float Metod1()
        {
            float L = (float)(Math.Sqrt(Math.Pow(this.pole5, 2) + Math.Pow(this.pole4, 2)));
            float SquerePRL = (float)(Math.PI * this.pole4 * L + Math.PI * Math.Pow(this.pole5, 2));
            return SquerePRL;
        }
        public float Metod2()
        {
            float VolumeC = (float)((1f/3) * Math.PI * Math.Pow(this.pole4, 2) * this.pole5);
            return VolumeC;
        }
    }
    class Child3 : IParent
    {
        float pole6;
        public Child3(float pole6)
        {
            this.pole6 = pole6;
        }
        public void Info()
        {
            Console.WriteLine($"R = {this.pole6}");
        }
        public float Metod1()
        {
            float SquareKylya = (float)(4 * Math.PI * Math.Pow(this.pole6, 2));
            return SquareKylya;
        }
        public float Metod2()
        {
            float VolumeKylya = (float)((4 * Math.PI * Math.Pow(this.pole6, 3)) / 3);
            return VolumeKylya;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IParent obj = null;
            Random o = new Random();
            string n = ""; int pole1, pole2, pole3, pole4, pole5, pole6, f;
            for ( int i = 1; i <= 5; i++ ) 
            { 
                f = o.Next(1, 4);
                if ( f == 1)
                {
                    n = "Паралелепипед: ";
                    pole1 = o.Next(1, 5);
                    pole2 = o.Next(1, 5);
                    pole3 = o.Next(1, 5);
                    obj = new Child1(pole1, pole2, pole3);
                    float p = obj.Metod1();
                    float s = obj.Metod2();
                    Console.WriteLine($"{n} S = {p}, V = {s}");
                    obj.Info();
                }
                else if ( f == 2 )
                {
                    n = "Конус: ";
                    pole4 = o.Next(1, 5);
                    pole5 = o.Next(1, 5);
                    obj = new Child2(pole4, pole5);
                    float p = obj.Metod1();
                    float s = obj.Metod2();
                    Console.WriteLine($"{n} S = {p}, V = {s}");
                    obj.Info();
                }
                else if ( f == 3)
                {
                    n = "Куля: ";
                    pole6 = o.Next(1, 5);
                    obj = new Child3(pole6);
                    obj.Info();
                    float p = obj.Metod1();
                    float s = obj.Metod2();
                    Console.WriteLine($"{n} S = {p}, V = {s}");
                    obj.Info();
                }
                else
                {
                    Console.WriteLine("Error!");
                }

            }
        }
    }
}