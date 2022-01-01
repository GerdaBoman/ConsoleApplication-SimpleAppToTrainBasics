DateTime today = DateTime.Now;  

Console.Write("Enter your first name?: ");
string? firstName = Console.ReadLine();

Console.Write("Enter your age: ");
string? ageResponse = Console.ReadLine();

bool ageCheck = int.TryParse(ageResponse,out int age);


do
{

    Console.WriteLine("Invalid age! Try again");
    Console.Write("Enter your age: ");
    ageResponse = Console.ReadLine();

    ageCheck = int.TryParse(ageResponse, out age);
}
while (ageCheck == false);


int yearWait = 20 - age;
if (age > 20)
{
    Console.WriteLine("Welcome");
    if (firstName.StartsWith("g") || firstName.StartsWith("G"))
    {
        Console.WriteLine($"{firstName}, what a nice name you have!");

    }
    else
    {
        Console.WriteLine($"Hello {firstName}");

    }
}
else
{
    Console.WriteLine($"{firstName}, come back in {yearWait} years.");


}

Console.ReadKey();  

