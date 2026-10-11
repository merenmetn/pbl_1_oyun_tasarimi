
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




//1. satir hucreleri 
char h11=' ';
char h12=' ';
char h13=' ';
//2. satir hucreleri
char h21=' ';
char h22=' ';
char h23=' ';
//3. satir hucreleri
char h31=' ';
char h32=' ';
char h33=' ';

Random rnd = new Random();
int yerlestirilenSembol = 0;

while (yerlestirilenSembol < nos)
{
    int rastgeleHucre = rnd.Next(1, 10);
    
    char rastgeleHarf = (char)('A' + rnd.Next(0, notos));

    switch (rastgeleHucre)
    {
        case 1:
            if (h11 == ' ') { h11 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 2:
            if (h12 == ' ') { h12 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 3:
            if (h13 == ' ') { h13 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 4:
            if (h21 == ' ') { h21 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 5:
            if (h22 == ' ') { h22 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 6:
            if (h23 == ' ') { h23 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 7:
            if (h31 == ' ') { h31 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 8:
            if (h32 == ' ') { h32 = rastgeleHarf; yerlestirilenSembol++; }
            break;
        case 9:
            if (h33 == ' ') { h33 = rastgeleHarf; yerlestirilenSembol++; }
            break;
    }
}


Console.WriteLine("NOS: " + nos);
Console.WriteLine("Number of Shifts: " + shift_number);
Console.WriteLine("|| Başlangıç Tahtası ||");
Console.WriteLine( "     12   11  10 ");  
Console.WriteLine("     ---+---+---");
Console.WriteLine($" 1  | {h11} | {h12} | {h13} |  9");
Console.WriteLine("     ---+---+---");
Console.WriteLine($" 2  | {h21} | {h22} | {h23} |  8");
Console.WriteLine("     ---+---+---");
Console.WriteLine($" 3  | {h31} | {h32} | {h33} |  7");
Console.WriteLine("     ---+---+---");
Console.WriteLine( "      4   5   6 ");  
    }   
    }

