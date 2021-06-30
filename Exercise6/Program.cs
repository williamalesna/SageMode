using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
Console.Write("Enter Max Row: ");
int maxRow = ValidateInput();
Console.Write("Enter Max Column: ");
int maxCol = ValidateInput();

Multiplication table1 = new Multiplication(maxRow, maxCol);

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Table generated successfully! ");
Console.ResetColor();
Console.Write("Press any key to continue...");
Console.ReadKey();
Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("GENERATED TABLE");
Console.ResetColor();

MakeSeparator();
table1.GenerateTable();
MakeSeparator();

while(true)
{
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    Console.Write("Do you want to change a number in any coordinate? (y/n): ");
    string choice = Console.ReadLine();

    if(choice == "y" || choice == "Y")
    {
        Console.Write("Enter coordinate X: ");
        int xCoordinate = ValidateInput() - 1;
        Console.Write("Enter coordinate y: ");
        int yCoordinate = ValidateInput() - 1;
        Console.Write("Enter new value: ");
        int newValue = ValidateInput();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();

        MakeSeparator();
        table1.ChangeTableValue(xCoordinate, yCoordinate, newValue);
        MakeSeparator();
    }
    else
    {
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
}

void MakeSeparator()
{
    for(int x = 0; x <= 100; x++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("-");
    }
    Console.ResetColor();
    Console.WriteLine();
}

int ValidateInput()
{
    int output;
    bool reEnter = false;

    while(true)
    {
        if(reEnter == true)
        {
            Console.Write("Please Enter Again: ");
        }

        string input = Console.ReadLine();
        bool result = int.TryParse(input, out output);

        if(result == true || result == false)
        {
            if(result == true)
            {
                if(output <= 0)
                {
                    reEnter = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter again.");
                    Console.ResetColor();
                    continue;
                }
            }
            if(result == false)
            {
                reEnter = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter again.");
                Console.ResetColor();
                continue;
            }
        }
        break;
    }
    return output;
}
