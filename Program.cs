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
int numberofshift = Convert.ToInt32(Console.ReadLine());
        while(numberofshift<1 || numberofshift > 20)
        {
            Console.Write("Enter the Number of Shifts: ");
            numberofshift = Convert.ToInt32(Console.ReadLine());
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
//1. satır hücreleri
char h11=' ';
char h12=' ';
char h13=' ';
//2. satır hücreleri
char h21=' ';
char h22=' ';
char h23=' ';
//3. satır hücreleri
char h31=' ';
char h32=' ';
char h33=' ';

Random rnd = new Random();
int yerleştirilensembol = 0;

while(yerleştirilensembol < nos)
        {
            int rastgeleHucre = rnd.Next(1,10);

            char rastgeleharf = Convert.ToChar('A' + rnd.Next(0, notos));

            switch (rastgeleHucre)
            {
                case 1:
                    if(h11 == ' ')
                    {
                        h11 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 2:
                if(h12 == ' ')
                    {
                        h12 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 3:
                if(h13 == ' ')
                    {
                        h13 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 4:
                if(h21 == ' ')
                    {
                        h21 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 5:
                if(h22 == ' ')
                    {
                        h22 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 6:
                if(h23 == ' ')
                    {
                        h23 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 7:
                if(h31 == ' ')
                    {
                        h31 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 8:
                if(h32 == ' ')
                    {
                        h32 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 9:
                if(h33 == ' ')
                    {
                        h33 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
            }
                

        }
        
Console.WriteLine("NOS: " + nos);
Console.WriteLine("Number of Shifts: " + numberofshift);
Console.WriteLine("--- Target Board ---");
Console.WriteLine("    7   8   9 ");
Console.WriteLine("  +-----------+");
Console.WriteLine($"1 | {h11}   {h12}   {h13} | 4");
Console.WriteLine("  |           |  ");
Console.WriteLine($"2 | {h21}   {h22}   {h23} | 5");
Console.WriteLine("  |           |  ");
Console.WriteLine($"3 | {h31}   {h32}   {h33} | 6");
Console.WriteLine("  +-----------+  ");
Console.WriteLine("   10  11  12  ");

//Shift Commands
int shift;    
int yapilantoplamshift = 0;
        while (yapilantoplamshift < numberofshift)
        {
        Console.Write("Enter shift command (1-12): ");
        shift = Convert.ToInt32(Console.ReadLine());
            while(shift<1 || shift > 12)
            {
                Console.Write("Enter shift command (1-12): ");
                shift = Convert.ToInt32(Console.ReadLine());
            }

            switch (shift)
            {
                case 1:
                    if(h13 == ' '&& h12 == ' ')
                    {
                        h13 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h13 == ' ')
                    {
                        h13 = h12;
                        h12 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h12 ==' ')
                        {
                            h12 = h11;
                            h11 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 2:
                    if(h23 == ' '&& h22 == ' ')
                    {
                        h23 = h21;
                        h21 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h23 == ' ')
                    {
                        h23 = h22;
                        h22 = h21;
                        h21 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h22 ==' ')
                        {
                            h22 = h21;
                            h21 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 3:
                    if(h33 == ' '&& h32 == ' ')
                    {
                        h33 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h33 == ' ')
                    {
                        h33 = h32;
                        h32 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h32 ==' ')
                        {
                            h32 = h31;
                            h31 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 4:
                    if(h12 == ' '&& h11 == ' ')
                    {
                        h11 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h11 == ' ')
                    {
                        h11 = h12;
                        h12 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h12 ==' ')
                        {
                            h12 = h13;
                            h13 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 5:
                    if(h22 == ' '&& h21 == ' ')
                    {
                        h21 = h23;
                        h23 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h21 == ' ')
                    {
                        h21 = h22;
                        h22 = h23;
                        h23 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h22 ==' ')
                        {
                            h22 = h23;
                            h23 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 6:
                    if(h32 == ' '&& h31 == ' ')
                    {
                        h31 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h31 == ' ')
                    {
                        h31 = h32;
                        h32 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h32 ==' ')
                        {
                            h32 = h33;
                            h33 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 7:
                    if(h31 == ' '&& h21 == ' ')
                    {
                        h31 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h31 == ' ')
                    {
                        h31 = h21;
                        h21 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h21 ==' ')
                        {
                            h21 = h11;
                            h11 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 8:
                    if(h32 == ' '&& h22 == ' ')
                    {
                        h32 = h12;
                        h12 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h32 == ' ')
                    {
                        h32 = h22;
                        h22 = h12;
                        h12 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h22 ==' ')
                        {
                            h22 = h12;
                            h12 = ' ';
                            yapilantoplamshift++;
                        }
                    
                    break;
                case 9:
                    if(h33 == ' '&& h23 == ' ')
                    {
                        h33 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h33 == ' ')
                    {
                        h33 = h23;
                        h23 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h23 ==' ')
                        {
                            h23 = h13;
                            h13 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 10:
                    if(h21 == ' '&& h11 == ' ')
                    {
                        h11 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h11 == ' ')
                    {
                        h11 = h21;
                        h21 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h21 ==' ')
                        {
                            h21 = h31;
                            h31 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 11:
                    if(h22 == ' '&& h12 == ' ')
                    {
                        h12 = h32;
                        h32 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h12 == ' ')
                    {
                        h12 = h22;
                        h22 = h32;
                        h32 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h22 ==' ')
                        {
                            h22 = h32;
                            h32 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                case 12:
                    if(h13 == ' '&& h23 == ' ')
                    {
                        h13 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    if(h13 == ' ')
                    {
                        h13 = h23;
                        h23 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h23 ==' ')
                        {
                            h23 = h33;
                            h33 = ' ';
                            yapilantoplamshift++;
                        }
                    break;
                    }
Console.WriteLine(" --- Round "+ (yapilantoplamshift) + " ---");
Console.WriteLine("    7   8   9 ");
Console.WriteLine("  +-----------+      Board ");
Console.WriteLine($"1 | {h11}   {h12}   {h13} | 4    Score : 0");
Console.WriteLine("  |           |  ");
Console.WriteLine($"2 | {h21}   {h22}   {h23} | 5    Yapılan toplam shift: " + yapilantoplamshift);
Console.WriteLine("  |           |  ");
Console.WriteLine($"3 | {h31}   {h32}   {h33} | 6    Shift: "+ shift);
Console.WriteLine("  +-----------+  ");
Console.WriteLine("   10  11  12  ");



            
                

        }
Console.WriteLine("The ShapeShifter is over!");
    }   
    }