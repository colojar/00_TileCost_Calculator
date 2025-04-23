// Description

// Ask the user to enter in width, length, and the cost per 1 unit of flooring. Have the program calculate how much it would cost to cover the area specified with the flooring.

// Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
// Also figure out how much labor costs would be given that the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr.
// Pick ONE ADDITIONAL SHAPE (triangle / circle / etc) and implement the second shape, making the user select wich one they want to calculate (time for an if statement!)

using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace _00_TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const int AREA_PER_HOUR = 20; // square feet
            const Double LABOR_COST_PER_HOUR = 86.00; // dollars

            // Variables
            Double width = 0;
            Double length = 0;
            Double costPerUnit = 0;
            Double area = 0;
            String shape = "";

            // Welcome
            Console.WriteLine("Welcome to the Tile Cost Calculator!");

            // User input
            Console.WriteLine("This program will calculate how much it will cost to cover the area of a room with flooring.");
            Console.Write("Please enter the cost per unit of flooring in dollars: ");
            costPerUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the shape of the room (Rectangle, Circle or Triangle): ");
            shape = Console.ReadLine().ToLower();

            // Make sure the user enters a valid shape
            if (shape != "rectangle" && shape != "circle" && shape != "triangle")
            {
                Console.WriteLine("Invalid shape. Please enter either 'rectangle', 'circle' or 'triangle'.");
                return;
            }

            // Shape it up
            if (shape == "circle")
            {
                Console.Write("Please enter the radius of the room in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * Math.Pow(width, 2);
            }
            if (shape == "triangle")
            {
                Console.Write("Please enter the base of the room in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the height of the room in feet: ");
                length = Convert.ToDouble(Console.ReadLine());
                area = (width * length) / 2;
            }
            if (shape == "rectangle")
            {
                Console.Write("Please enter the width of the room in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the length of the room in feet: ");
                length = Convert.ToDouble(Console.ReadLine());
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
