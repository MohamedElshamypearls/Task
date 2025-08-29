using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Person[] people = new Person[3];
            people[0] = new Person("Ahmed", 30);
            people[1] = new Person("Mohamed", 25);
            people[2] = new Person("Salah", 40);

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
            #endregion

            #region 2
            Console.Write("Enter X for first point: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Y for first point: ");
            double y1 = double.Parse(Console.ReadLine());

            Point p1 = new Point(x1, y1);

            Console.Write("Enter X for second point: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Y for second point: ");
            double y2 = double.Parse(Console.ReadLine());

            Point p2 = new Point(x2, y2);

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"\nDistance between the two points: {distance:F2}");
            #endregion

            #region 3

            Person[] newpeople = new Person[3];

            // Input data for 3 persons
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter age of {name}: ");
                int age = int.Parse(Console.ReadLine());

                newpeople[i] = new Person(name, age);
            }

            // Find the oldest person
            Person oldest = newpeople[0];
            for (int i = 1; i < newpeople.Length; i++)
            {
                if (newpeople[i].Age > oldest.Age)
                {
                    oldest = newpeople[i];
                }
            }

            // Display result
            Console.WriteLine($"\nOldest person is: {oldest.Name}, Age: {oldest.Age}");


            #endregion

            #region 4

            Rectangle rect = new Rectangle();

            // Set values using properties
            Console.Write("Enter width: ");
            rect.Width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            rect.Height = double.Parse(Console.ReadLine());

            // Display rectangle information
            rect.DisplayInfo();

            // Try setting a negative value
            Console.WriteLine("\nAttempting to set a negative width...");
            rect.Width = -10;
            #endregion



        }
    }

    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor for convenience
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"Name: {this.Name}, Age: {this.Age}";

    }
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Method to calculate distance to another point
        public double DistanceTo(Point other)
        {
            double dx = other.X - this.X;
            double dy = other.Y - this.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }


    struct Rectangle
    {
        // Private fields
        private double _width;
        private double _height;

        // Public properties with validation
        public double Width
        {
            get => _width;
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    Console.WriteLine("Error: Width cannot be negative.");
            }
        }

        public double Height
        {
            get => _height; 
            set
            {
                if (value >= 0)
                    _height = value;
                else
                    Console.WriteLine("Error: Height cannot be negative.");
            }
        }

        // Read-only property to calculate area
        public double Area
        {
            get => _width * _height; 
        }

        // Method to display rectangle info
        public void DisplayInfo()
        {
            Console.WriteLine($"\nRectangle Details:");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area}");
        }
    }


    public class Ahmed
    {
        public string Elshamt { get; set; }

    }


}
