// See https://aka.ms/new-console-template for more information

using System.Text;
using Day5.chess;

namespace Day5;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Bike bike = new Bike();
        // bike.PrintStatus();
        // bike.Start();
        // Console.Write("Nhập speed: ");
        // string input = Console.ReadLine();
        // float speed = float.Parse(input);
        // Console.WriteLine($"Giá trị nhập speed là {speed}");
        // bike.SetSpeed(speed);
        // bike.PrintStatus();


        // bike.GetFuel();

        // GetFuel(bike);
        //
        // Bicycle bicycle = new Bicycle();
        // GetFuel(bicycle);

        Board board = new Board();

        Bishop bishop = new Bishop("Tượng 3");
        bishop.Eat(board.Piecies[4]);
        bishop.PrintStatus();
        board.Piecies[4].PrintStatus();
        Console.WriteLine(bishop.internalVariable);
        // board.PrintStatus();
        // board.Move(board.R);
        // board.PrintStatus();
    }


    static void GetFuel(Vehicle vehicle)
    {
        vehicle.GetFuel();
    }
}