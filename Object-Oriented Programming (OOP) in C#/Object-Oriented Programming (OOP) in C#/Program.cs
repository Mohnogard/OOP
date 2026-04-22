namespace Object_Oriented_Programming__OOP__in_C_
{

    class Person
    {
        public string Name {  get; set; }
        private int age = 60;
         void getInfo()
        {
            Console.WriteLine(Name + age);
        }
    }

    class Student : Person 
    {
        public string studentName { get; set;}
        public void getGrade( int num)
        {
            Console.WriteLine($"{studentName} studies with {Name}");
        }
    }


    class Car
    {
        public string Maker { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public int PalletNo { get; set; }
        public string Color { get; set; }

        public Car(string maker, int year, string type, int price, string model, int palletNo, string color)
        {
            Maker = maker;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }
        public void StartStop(string Todo)
        {
            if (Todo == "stop")
            {
                Console.WriteLine("Engine has stopped");
            }
            else if (Todo == "start")
            {
                Console.WriteLine("Engine has started");
            }
        }
        public void getInfo()
        {
            Console.WriteLine($"{Maker} , {Year} , {Type} , {Price} , {Model} , {PalletNo} , {Color}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Student student = new Student();
            student.Name = "Ahmad";
            student.studentName = "Ahmad Kararheh";
            student.getGrade(59);


            Car car = new Car("toyota", 1999, "coupe", 10000, "x2", 32, "red");
            car.StartStop("stop");
            car.getInfo();

        }
    }
}
