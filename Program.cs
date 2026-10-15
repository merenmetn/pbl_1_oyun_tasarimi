using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the ShapeShifter");
        Console.WriteLine("Press enter to start");
        Console.ReadLine();
        // User Informations
        string player_type;
        Console.WriteLine("Enter player type Human or Computer: ");
        player_type = Console.ReadLine();
        while (player_type != "Human" && player_type != "Computer")
        {
            Console.WriteLine("Enter Human or Computer: ");
            player_type = Console.ReadLine();

        }
        Console.Write("Enter NOTOS (1-5): ");
        int notos = Convert.ToInt32(Console.ReadLine());
        while (notos < 1 || notos > 5)
        {
            Console.Write("Enter NOTOS (1-5): ");
            notos = Convert.ToInt32(Console.ReadLine());
        }


        Console.Write("Enter NOS (1-6): ");
        int nos = Convert.ToInt32(Console.ReadLine());
        while (nos < 1 || nos > 6)
        {
            Console.Write("Enter NOS (1-6): ");
            nos = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the Number of Shifts (1-20): ");
        int numberofshift = Convert.ToInt32(Console.ReadLine());
        while (numberofshift < 1 || numberofshift > 20)
        {
            Console.Write("Enter the Number of Shifts: ");
            numberofshift = Convert.ToInt32(Console.ReadLine());
        }


        //Bilgilerin ekrana yazdırılması
        Console.WriteLine(" ");
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
        else if (notos == 4)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B-C-D");
        }
        else if (notos == 5)
        {
            Console.WriteLine("NOTOS: " + notos + " = A-B-C-D-E");
        }
         //Initial Boards variables
        //1. satır hücreleri
        char h11 = ' ', h12 = ' ', h13 = ' ';
        //2. satır hücreleri
        char h21 = ' ', h22 = ' ', h23 = ' ';
        //3. satır hücreleri
        char h31 = ' ', h32 = ' ', h33 = ' ';
        //RANDOM İNİTİAL BOARD OLUŞTURMA 

        Random rnd = new Random();
        int yerleştirilensembol = 0;

        while (yerleştirilensembol < nos)
        {
            int rastgeleHucre = rnd.Next(1, 10);

            char rastgeleharf = Convert.ToChar('A' + rnd.Next(0, notos));

            switch (rastgeleHucre)
            {
                case 1:
                    if (h11 == ' ')
                    {
                        h11 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 2:
                    if (h12 == ' ')
                    {
                        h12 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 3:
                    if (h13 == ' ')
                    {
                        h13 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 4:
                    if (h21 == ' ')
                    {
                        h21 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 5:
                    if (h22 == ' ')
                    {
                        h22 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 6:
                    if (h23 == ' ')
                    {
                        h23 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 7:
                    if (h31 == ' ')
                    {
                        h31 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 8:
                    if (h32 == ' ')
                    {
                        h32 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
                case 9:
                    if (h33 == ' ')
                    {
                        h33 = rastgeleharf;
                        yerleştirilensembol++;
                    }
                    break;
            }


        }
        //Target board variables

        char g11=h11, g12=h12, g13=h13;
        char g21=h21, g22=h22, g23=h23;
        char g31=h31, g32=h32, g33=h33;

        //Target Board Shift Commands


        int sayac1 = 0;
int lastShift = 0; 
if(nos==1 || nos == 2)
        {
            while (sayac1 < numberofshift)
{
    char old_g11 = g11, old_g12 = g12, old_g13 = g13;
    char old_g21 = g21, old_g23 = g23;
    char old_g31 = g31, old_g32 = g32, old_g33 = g33;
    
    
    int randomShift;
    bool ayniMi;

    do 
    {
        randomShift = rnd.Next(1, 13);
        ayniMi = false; 

        switch (randomShift)
        {
            case 1:
                if (lastShift == 4) ayniMi = true;
                break;
            case 4:
                if (lastShift == 1) ayniMi = true;
                break;
            case 2:
                if (lastShift == 5) ayniMi = true;
                break;
            case 5:
                if (lastShift == 2) ayniMi = true;
                break;
            case 3:
                if (lastShift == 6) ayniMi = true;
                break;
            case 6:
                if (lastShift == 3) ayniMi = true;
                break;
            case 7:
                if (lastShift == 10) ayniMi = true;
                break;
            case 10:
                if (lastShift == 7) ayniMi = true;
                break;
            case 8:
                if (lastShift == 11) ayniMi = true;
                break;
            case 11:
                if (lastShift == 8) ayniMi = true;
                break;
            case 9:
                if (lastShift == 12) ayniMi = true;
                break;
            case 12:
                if (lastShift == 9) ayniMi = true;
                break;
        }
    } while (ayniMi); 

            switch (randomShift)
            {
                case 1:
                    if (g13 == ' ' && g12 == ' ')
                    {
                        g13 = g11;
                        g11 = ' ';
                    }
                    else if (g13 == ' ')
                    {
                        g13 = g12;
                        g12 = g11;
                        g11 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g11;
                        g11 = ' ';
                    }
                    break;
                case 2:
                    if (g23 == ' ' && g22 == ' ')
                    {
                        g23 = g21;
                        g21 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g22;
                        g22 = ' ';
                    }
                    break;
                case 3:
                    if (g33 == ' ' && g32 == ' ')
                    {
                        g33 = g31;
                        g31 = ' ';
                    }
                    else if (g33 == ' ')
                    {
                        g33 = g32;
                        g32 = g31;
                        g31 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g31;
                        g31 = ' ';
                    }
                    break;
                case 4:
                    if (g12 == ' ' && g11 == ' ')
                    {
                        g11 = g13;
                        g13 = ' ';
                    }
                    else if (g11 == ' ')
                    {
                        g11 = g12;
                        g12 = g13;
                        g13 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g13;
                        g13 = ' ';
                    }
                    break;
                case 5:
                    if (g22 == ' ' && g21 == ' ')
                    {
                        g21 = g23;
                        g23 = ' ';
                    }
                    else if (g21 == ' ')
                    {
                        g21 = g22;
                        g22 = ' ';
                    }
                    break;
                case 6:
                    if (g32 == ' ' && g31 == ' ')
                    {
                        g31 = g33;
                        g33 = ' ';
                    }
                    else if (g31 == ' ')
                    {
                        g31 = g32;
                        g32 = g33;
                        g33 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g33;
                        g33 = ' ';
                    }
                    break;
                case 7:
                    if (g31 == ' ' && g21 == ' ')
                    {
                        g31 = g11;
                        g11 = ' ';
                    }
                    else if (g31 == ' ')
                    {
                        g31 = g21;
                        g21 = g11;
                        g11 = ' ';
                    }
                    break;
                case 8:
                    if (g32 == ' ' && g22 == ' ')
                    {
                        g32 = g12;
                        g12 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g22;
                        g22 = ' ';
                    }
                    break;
                case 9:
                    if (g33 == ' ' && g23 == ' ')
                    {
                        g33 = g13;
                        g13 = ' ';
                    }
                    else if (g33 == ' ')
                    {
                        g33 = g23;
                        g23 = g13;
                        g13 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g13;
                        g13 = ' ';
                    }
                    break;
                case 10:
                    if (g21 == ' ' && g11 == ' ')
                    {
                        g11 = g31;
                        g31 = ' ';
                    }
                    else if (g11 == ' ')
                    {
                        g11 = g21;
                        g21 = g31;
                        g31 = ' ';
                    }
                    else if (g21 == ' ')
                    {
                        g21 = g31;
                        g31 = ' ';
                    }
                    break;
                case 11:
                    if (g22 == ' ' && g12 == ' ')
                    {
                        g12 = g32;
                        g32 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g22;
                        g22 = ' ';
                    }
                    break;
                case 12:
                    if (g13 == ' ' && g23 == ' ')
                    {
                        g13 = g33;
                        g33 = ' ';
                    }
                    else if (g13 == ' ')
                    {
                        g13 = g23;
                        g23 = g33;
                        g33 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g33;
                        g33 = ' ';
                    }
                    break;
            }


            if (g11 != old_g11 || g12 != old_g12 || g13 != old_g13 || g21 != old_g21 ||  g23 != old_g23 || g31 != old_g31 || g32 != old_g32 || g33 != old_g33)
            {
                sayac1++;
                lastShift = randomShift;
            }
            
        }
        }
        else
        {
            while (sayac1 < numberofshift)
{
    char old_g11 = g11, old_g12 = g12, old_g13 = g13;
    char old_g21 = g21, old_g22 = g22, old_g23 = g23;
    char old_g31 = g31, old_g32 = g32, old_g33 = g33;
    
    
    int randomShift;
    bool ayniMi;

    do 
    {
        randomShift = rnd.Next(1, 13);
        ayniMi = false; 

        switch (randomShift)
        {
            case 1:
                if (lastShift == 4) ayniMi = true;
                break;
            case 4:
                if (lastShift == 1) ayniMi = true;
                break;
            case 2:
                if (lastShift == 5) ayniMi = true;
                break;
            case 5:
                if (lastShift == 2) ayniMi = true;
                break;
            case 3:
                if (lastShift == 6) ayniMi = true;
                break;
            case 6:
                if (lastShift == 3) ayniMi = true;
                break;
            case 7:
                if (lastShift == 10) ayniMi = true;
                break;
            case 10:
                if (lastShift == 7) ayniMi = true;
                break;
            case 8:
                if (lastShift == 11) ayniMi = true;
                break;
            case 11:
                if (lastShift == 8) ayniMi = true;
                break;
            case 9:
                if (lastShift == 12) ayniMi = true;
                break;
            case 12:
                if (lastShift == 9) ayniMi = true;
                break;
        }
    } while (ayniMi); 

            switch (randomShift)
            {
                case 1:
                    if (g13 == ' ' && g12 == ' ')
                    {
                        g13 = g11;
                        g11 = ' ';
                    }
                    else if (g13 == ' ')
                    {
                        g13 = g12;
                        g12 = g11;
                        g11 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g11;
                        g11 = ' ';
                    }
                    break;
                case 2:
                    if (g23 == ' ' && g22 == ' ')
                    {
                        g23 = g21;
                        g21 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g22;
                        g22 = g21;
                        g21 = ' ';
                    }
                    else if (g22 == ' ')
                    {
                        g22 = g21;
                        g21 = ' ';
                    }
                    break;
                case 3:
                    if (g33 == ' ' && g32 == ' ')
                    {
                        g33 = g31;
                        g31 = ' ';
                    }
                    else if (g33 == ' ')
                    {
                        g33 = g32;
                        g32 = g31;
                        g31 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g31;
                        g31 = ' ';
                    }
                    break;
                case 4:
                    if (g12 == ' ' && g11 == ' ')
                    {
                        g11 = g13;
                        g13 = ' ';
                    }
                    else if (g11 == ' ')
                    {
                        g11 = g12;
                        g12 = g13;
                        g13 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g13;
                        g13 = ' ';
                    }
                    break;
                case 5:
                    if (g22 == ' ' && g21 == ' ')
                    {
                        g21 = g23;
                        g23 = ' ';
                    }
                    else if (g21 == ' ')
                    {
                        g21 = g22;
                        g22 = g23;
                        g23 = ' ';
                    }
                    else if (g22 == ' ')
                    {
                        g22 = g23;
                        g23 = ' ';
                    }
                    break;
                case 6:
                    if (g32 == ' ' && g31 == ' ')
                    {
                        g31 = g33;
                        g33 = ' ';
                    }
                    else if (g31 == ' ')
                    {
                        g31 = g32;
                        g32 = g33;
                        g33 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g33;
                        g33 = ' ';
                    }
                    break;
                case 7:
                    if (g31 == ' ' && g21 == ' ')
                    {
                        g31 = g11;
                        g11 = ' ';
                    }
                    else if (g31 == ' ')
                    {
                        g31 = g21;
                        g21 = g11;
                        g11 = ' ';
                    }
                    else if (g21 == ' ')
                    {
                        g21 = g11;
                        g11 = ' ';
                    }
                    break;
                case 8:
                    if (g32 == ' ' && g22 == ' ')
                    {
                        g32 = g12;
                        g12 = ' ';
                    }
                    else if (g32 == ' ')
                    {
                        g32 = g22;
                        g22 = g12;
                        g12 = ' ';
                    }
                    else if (g22 == ' ')
                    {
                        g22 = g12;
                        g12 = ' ';
                    }

                    break;
                case 9:
                    if (g33 == ' ' && g23 == ' ')
                    {
                        g33 = g13;
                        g13 = ' ';
                    }
                    else if (g33 == ' ')
                    {
                        g33 = g23;
                        g23 = g13;
                        g13 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g13;
                        g13 = ' ';
                    }
                    break;
                case 10:
                    if (g21 == ' ' && g11 == ' ')
                    {
                        g11 = g31;
                        g31 = ' ';
                    }
                    else if (g11 == ' ')
                    {
                        g11 = g21;
                        g21 = g31;
                        g31 = ' ';
                    }
                    else if (g21 == ' ')
                    {
                        g21 = g31;
                        g31 = ' ';
                    }
                    break;
                case 11:
                    if (g22 == ' ' && g12 == ' ')
                    {
                        g12 = g32;
                        g32 = ' ';
                    }
                    else if (g12 == ' ')
                    {
                        g12 = g22;
                        g22 = g32;
                        g32 = ' ';
                    }
                    else if (g22 == ' ')
                    {
                        g22 = g32;
                        g32 = ' ';
                    }
                    break;
                case 12:
                    if (g13 == ' ' && g23 == ' ')
                    {
                        g13 = g33;
                        g33 = ' ';
                    }
                    else if (g13 == ' ')
                    {
                        g13 = g23;
                        g23 = g33;
                        g33 = ' ';
                    }
                    else if (g23 == ' ')
                    {
                        g23 = g33;
                        g33 = ' ';
                    }
                    break;
            }


            if (g11 != old_g11 || g12 != old_g12 || g13 != old_g13 || g21 != old_g21 || g22 != old_g22 || g23 != old_g23 || g31 != old_g31 || g32 != old_g32 || g33 != old_g33)
            {
                sayac1++;
                lastShift = randomShift;
            }
            
        }
        }


        //first Board
        Console.WriteLine("NOS: " + nos);
        Console.WriteLine("Number of Shifts: " + numberofshift);
        Console.WriteLine(" ");
        Console.WriteLine("--- Initial Board ---     --- Target Board ---");
        Console.WriteLine("    7   8   9                  7   8   9 ");
        Console.WriteLine("  +-----------+              +-----------+       ");
        Console.WriteLine($"1 | {h11}   {h12}   {h13} | 4          1 | {g11}   {g12}   {g13} | 4    ");
        Console.WriteLine("  |           |              |           |");
        Console.WriteLine($"2 | {h21}   {h22}   {h23} | 5          2 | {g21}   {g22}   {g23} | 5   ");
        Console.WriteLine("  |           |              |           |");
        Console.WriteLine($"3 | {h31}   {h32}   {h33} | 6          3 | {g31}   {g32}   {g33} | 6    ");
        Console.WriteLine("  +-----------+              +-----------+  ");
        Console.WriteLine("   10  11  12                 10  11  12  ");


        //Shift Commands
        int shift;
        int yapilantoplamshift = 0;
        while (yapilantoplamshift <= 20 && (g11 != h11 || g12 != h12 || g13 != h13 || g21 != h21 || g22 != h22 || g23 != h23 || g31 != h31 || g32 != h32 || g33 != h33))
        {
            Console.Write("Enter shift command (1-12): ");
            shift = Convert.ToInt32(Console.ReadLine());
            
            while (shift < 1 || shift > 12)
            {
                    Console.Write("Enter shift command (1-12): ");
                    shift = Convert.ToInt32(Console.ReadLine());
                    yapilantoplamshift++;            
            }

            switch (shift)
            {
                case 1:
                    if (h13 == ' ' && h12 == ' ')
                    {
                        h13 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h13 == ' ')
                    {
                        h13 = h12;
                        h12 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h12 == ' ')
                    {
                        h12 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h13 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h12 != ' ' && h13 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h12 != ' ' && h13 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 2:
                    if (h23 == ' ' && h22 == ' ')
                    {
                        h23 = h21;
                        h21 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h23 == ' ')
                    {
                        h23 = h22;
                        h22 = h21;
                        h21 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h22 == ' ')
                    {
                        h22 = h21;
                        h21 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h22 != ' ' && h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h21 != ' ' && h22 != ' ' && h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 3:
                    if (h33 == ' ' && h32 == ' ')
                    {
                        h33 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h33 == ' ')
                    {
                        h33 = h32;
                        h32 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h32 == ' ')
                    {
                        h32 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h32 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h31 != ' ' && h32 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 4:
                    if (h12 == ' ' && h11 == ' ')
                    {
                        h11 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h11 == ' ')
                    {
                        h11 = h12;
                        h12 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h12 == ' ')
                    {
                        h12 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h12 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h12 != ' ' && h13 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 5:
                    if (h22 == ' ' && h21 == ' ')
                    {
                        h21 = h23;
                        h23 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h21 == ' ')
                    {
                        h21 = h22;
                        h22 = h23;
                        h23 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h22 == ' ')
                    {
                        h22 = h23;
                        h23 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h21 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h21 != ' ' && h22 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h21 != ' ' && h22 != ' ' && h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 6:
                    if (h32 == ' ' && h31 == ' ')
                    {
                        h31 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h31 == ' ')
                    {
                        h31 = h32;
                        h32 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h32 == ' ')
                    {
                        h32 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h31 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h31 != ' ' && h32 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h31 != ' ' && h32 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 7:
                    if (h31 == ' ' && h21 == ' ')
                    {
                        h31 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h31 == ' ')
                    {
                        h31 = h21;
                        h21 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h21 == ' ')
                    {
                        h21 = h11;
                        h11 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h13 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h21 != ' ' && h31 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h21 != ' ' && h31 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 8:
                    if (h32 == ' ' && h22 == ' ')
                    {
                        h32 = h12;
                        h12 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h32 == ' ')
                    {
                        h32 = h22;
                        h22 = h12;
                        h12 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h22 == ' ')
                    {
                        h22 = h12;
                        h12 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h22 != ' ' && h32 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h12 != ' ' && h22 != ' ' && h32 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 9:
                    if (h33 == ' ' && h23 == ' ')
                    {
                        h33 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h33 == ' ')
                    {
                        h33 = h23;
                        h23 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h23 == ' ')
                    {
                        h23 = h13;
                        h13 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h23 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h13 != ' ' && h23 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 10:
                    if (h21 == ' ' && h11 == ' ')
                    {
                        h11 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h11 == ' ')
                    {
                        h11 = h21;
                        h21 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h21 == ' ')
                    {
                        h21 = h31;
                        h31 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h21 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h11 != ' ' && h21 != ' ' && h31 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 11:
                    if (h22 == ' ' && h12 == ' ')
                    {
                        h12 = h32;
                        h32 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h12 == ' ')
                    {
                        h12 = h22;
                        h22 = h32;
                        h32 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h22 == ' ')
                    {
                        h22 = h32;
                        h32 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h12 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h12 != ' ' && h22 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h12 != ' ' && h22 != ' ' && h32 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
                case 12:
                    if (h13 == ' ' && h23 == ' ')
                    {
                        h13 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h13 == ' ')
                    {
                        h13 = h23;
                        h23 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if (h23 == ' ')
                    {
                        h23 = h33;
                        h33 = ' ';
                        yapilantoplamshift++;
                    }
                    else if(h13!= ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h13 != ' ' && h23 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    else if (h13 != ' ' && h23 != ' ' && h33 != ' ')
                    {
                        yapilantoplamshift++;
                    }
                    break;
            }
            //Game score calculation
            int game_score = 0;
            if (h11 != ' ' && h11 == g11)
            {
                int score = 0;

                if (h11 == 'A') score = 1;
                else if (h11 == 'B') score = 2;
                else if (h11 == 'C') score = 3;
                else if (h11 == 'D') score = 4;
                else if (h11 == 'E') score = 5;

                game_score += score * 1;
            }
            if (h12 != ' ' && h12 == g12)
            {
                int score = 0;

                if (h12 == 'A') score = 1;
                else if (h12 == 'B') score = 2;
                else if (h12 == 'C') score = 3;
                else if (h12 == 'D') score = 4;
                else if (h12 == 'E') score = 5;

                game_score += score * 2;
            }
            if (h13 != ' ' && h13 == g13)
            {
                int score = 0;

                if (h13 == 'A') score = 1;
                else if (h13 == 'B') score = 2;
                else if (h13 == 'C') score = 3;
                else if (h13 == 'D') score = 4;
                else if (h13 == 'E') score = 5;

                game_score += score * 1;
            }
            if (h21 != ' ' && h21 == g21)
            {
                int score = 0;

                if (h21 == 'A') score = 1;
                else if (h21 == 'B') score = 2;
                else if (h21 == 'C') score = 3;
                else if (h21 == 'D') score = 4;
                else if (h21 == 'E') score = 5;

                game_score += score * 2;
            }
            if (h22 != ' ' && h22 == g22)
            {
                int score = 0;

                if (h22 == 'A') score = 1;
                else if (h22 == 'B') score = 2;
                else if (h22 == 'C') score = 3;
                else if (h22 == 'D') score = 4;
                else if (h22 == 'E') score = 5;

                game_score += score * 4;
            }
            if (h23 != ' ' && h23 == g23)
            {
                int score = 0;

                if (h23 == 'A') score = 1;
                else if (h23 == 'B') score = 2;
                else if (h23 == 'C') score = 3;
                else if (h23 == 'D') score = 4;
                else if (h23 == 'E') score = 5;

                game_score += score * 2;
            }
            if (h31 != ' ' && h31 == g31)
            {
                int score = 0;

                if (h31 == 'A') score = 1;
                else if (h31 == 'B') score = 2;
                else if (h31 == 'C') score = 3;
                else if (h31 == 'D') score = 4;
                else if (h31 == 'E') score = 5;

                game_score += score * 1;
            }
            if (h32 != ' ' && h32 == g32)
            {
                int score = 0;

                if (h32 == 'A') score = 1;
                else if (h32 == 'B') score = 2;
                else if (h32 == 'C') score = 3;
                else if (h32 == 'D') score = 4;
                else if (h32 == 'E') score = 5;

                game_score += score * 2;
            }
            if (h33 != ' ' && h33 == g33)
            {
                int score = 0;

                if (h33 == 'A') score = 1;
                else if (h33 == 'B') score = 2;
                else if (h33 == 'C') score = 3;
                else if (h33 == 'D') score = 4;
                else if (h33 == 'E') score = 5;

                game_score += score * 1;
            }
            if (g11 == h11 && g12 == h12 && g13 == h13 && g21 == h21 && g22 == h22 && g23 == h23 && g31 == h31 && g32 == h32 && g33 == h33)
            {
                Console.WriteLine(" ");
                Console.WriteLine("--- Completed ---");
                Console.WriteLine("    7   8   9                ");
                Console.WriteLine("  +-----------+     Board      ");
                Console.WriteLine($"1 | {h11}   {h12}   {h13} | 4   Score: {game_score}       ");
                Console.WriteLine("  |           |                         ");
                Console.WriteLine($"2 | {h21}   {h22}   {h23} | 5          ");
                Console.WriteLine("  |           |                         ");
                Console.WriteLine($"3 | {h31}   {h32}   {h33} | 6          ");
                Console.WriteLine("  +-----------+           ");
                Console.WriteLine("   10  11  12          ");
                Console.WriteLine(" ");
                Console.Write("Game Score: " + (10 * game_score) + " + " + (notos * nos * (numberofshift - yapilantoplamshift) + " = "));
                Console.Write((10 * game_score) + (notos * nos * (numberofshift - yapilantoplamshift)));
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Congratulations! The ShapeShifter is over!");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(" --- Round " + (yapilantoplamshift) + " ---          --- Target Board ---");
                Console.WriteLine("    7   8   9                  7   8   9 ");
                Console.WriteLine("  +-----------+              +-----------+       ");
                Console.WriteLine($"1 | {h11}   {h12}   {h13} | 4          1 | {g11}   {g12}   {g13} | 4    ");
                Console.WriteLine("  |           |              |           |");
                Console.WriteLine($"2 | {h21}   {h22}   {h23} | 5          2 | {g21}   {g22}   {g23} | 5   ");
                Console.WriteLine("  |           |              |           |");
                Console.WriteLine($"3 | {h31}   {h32}   {h33} | 6          3 | {g31}   {g32}   {g33} | 6    ");
                Console.WriteLine("  +-----------+              +-----------+  ");
                Console.WriteLine("   10  11  12                 10  11  12  ");
                Console.WriteLine($"Yapılan toplam shift: {yapilantoplamshift}");
                Console.WriteLine($"Shift:  {shift}");
                Console.WriteLine("Board Score= " + game_score);
            }




        }
    }
}