using System;
using System.Globalization;

class Program
{
   static void Main()
    {
        Console.WriteLine("Welcome to the ShapeShifter");
        Console.WriteLine("Press enter to start");
        Console.ReadLine();
// Kullanıcı verileri
string player_type;
Console.WriteLine("Enter player type Human or Computer: ");
player_type = Console.ReadLine()!;
while(player_type != "Human" && player_type != "Computer" )
        {
            Console.WriteLine("Enter Human or Computer: ");
            player_type = Console.ReadLine()!;
            
        }
Console.Write("Enter NOTOS (1-5): ");
int notos = Convert.ToInt32(Console.ReadLine());
        while (notos <1 || notos >5)
        {
            Console.Write("Enter NOTOS (1-5): ");
            notos = Convert.ToInt32(Console.ReadLine());
        }
        
            
Console.Write("Enter NOS (1-6): ");
int nos = Convert.ToInt32(Console.ReadLine());
        while(nos <1 || nos >6)
        {
            Console.Write("Enter NOS (1-6): ");
            nos = Convert.ToInt32(Console.ReadLine());
        }

Console.Write("Enter the Number of Shifts (1-20): ");
int shift_number = Convert.ToInt32(Console.ReadLine());
        while(shift_number<1 || shift_number > 20)
        {
            Console.Write("Enter the Number of Shifts: ");
            shift_number = Convert.ToInt32(Console.ReadLine());
        }
        

//Bilgilerin ekrana yazdırılması
Console.WriteLine("Player Type: " + player_type);
        if (notos == 1)
        {
            Console.WriteLine("NOTOS: " + notos + " =A");
        }
        else if (notos == 2)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B");
        }
        else if (notos == 3)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B-C");
        }
        else if (notos== 4)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B-C-D");
        }
        else if(notos== 5)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B-C-D-E");
        }

Console.WriteLine("NOS: " + nos);
Console.WriteLine("Number of Shifts: " + shift_number);
Console.WriteLine("   7  8  9 ");
Console.WriteLine(" +---------+");
Console.WriteLine("1|         |4");
Console.WriteLine(" |         |");
Console.WriteLine("2|         |5");
Console.WriteLine(" |         |");
Console.WriteLine("3|         |6");
Console.WriteLine(" +---------+");
Console.WriteLine("  10 11 12  ");
    }   
    }