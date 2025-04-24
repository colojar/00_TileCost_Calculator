// Description

// Ask the user to enter in width, length, and the cost per 1 unit of flooring. Have the program calculate how much it would cost to cover the area specified with the flooring.

// Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
// Also figure out how much labor costs would be given that the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr.
// Pick ONE ADDITIONAL SHAPE (triangle / circle / etc) and implement the second shape, making the user select wich one they want to calculate (time for an if statement!)

namespace _00_TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const int AREA_PER_HOUR = 20; // square feet
            const Double LABOR_COST_PER_HOUR = 86.00; // dollars
            // TODO: use a list or array to store the shapes
            const string SHAPE_RECTANGLE = "rectangle";
            const string SHAPE_CIRCLE = "circle";
            const string SHAPE_TRIANGLE = "triangle";

            // Welcome
            Console.WriteLine("Welcome to the Tile Cost Calculator!");
            Console.WriteLine("This program will calculate how much it will cost to cover the area of a room with flooring.");

            // User input
            Double costPerUnit = 0;
            Console.Write("Please enter the cost per unit of flooring in dollars: ");
            costPerUnit = Convert.ToDouble(Console.ReadLine());
            String shape = "";
            Console.WriteLine($"Enter the shape of the room ('{SHAPE_RECTANGLE}', '{SHAPE_CIRCLE}' or '{SHAPE_TRIANGLE}'): ");
            shape = Console.ReadLine().ToLower();

            // Make sure the user enters a valid shape
            // TODO: use a function to validate the shapes
            if (shape != SHAPE_RECTANGLE && shape != SHAPE_CIRCLE && shape != SHAPE_TRIANGLE)
            {
                Console.WriteLine($"Invalid shape. Please enter either '{SHAPE_RECTANGLE}', '{SHAPE_CIRCLE}' or '{SHAPE_TRIANGLE}'.");
                return;
            }
            Double area = 0;
            // Shape it up
            if (shape == SHAPE_CIRCLE)
            {
                Console.Write("Please enter the radius of the room in feet: ");
                Double radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
            }
            if (shape == SHAPE_TRIANGLE)
            {
                Console.Write("Please enter the base of the room in feet: ");
                Double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the height of the room in feet: ");
                Double triangleHeight = Convert.ToDouble(Console.ReadLine());
                area = (triangleBase * triangleHeight) / 2;
            }
            if (shape == SHAPE_RECTANGLE)
            {
                Console.Write("Please enter the width of the room in feet: ");
                Double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the length of the room in feet: ");
                Double length = Convert.ToDouble(Console.ReadLine());
                area = width * length;
            }

            // Calculate
            Console.WriteLine($"The area of the room is {area} square feet.");
            Console.WriteLine($"The cost of flooring for the room is {area * costPerUnit} dollars.");
            Console.WriteLine($"The labor cost for the room is {area / AREA_PER_HOUR * LABOR_COST_PER_HOUR} dollars.");
            Console.WriteLine($"The total cost for the room is {(area * costPerUnit) + (area / AREA_PER_HOUR * LABOR_COST_PER_HOUR)} dollars.");
        }
    }
}
