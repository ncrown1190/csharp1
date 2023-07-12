// Random dice = new Random();
// int roll = dice.Next(0, 2);

// Console.WriteLine((roll == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 53;

// if(permission.Contains("Admin")){
//     if(level > 55){
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else if(level <= 55){
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if(permission.Contains("Manager")){
// if(level >= 20){
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if(level < 20){
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// }
// else{
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//int[] data = new int[3];

//*! Create a method to display random numbers
// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

// ** application that tracks medication times across different time zones. The user enters their current time zone and their destination time zone. Their medication schedule is displayed and then adjusted for the new time zone. **//
// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// ** A valid IPv4 address consists of four numbers separated by dots Each number must not contain leading zeroes Each number must range from 0 to 255 **//
// *! pseudo-code
/* if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// *! Your challenge is to create a reusable method that prints a player's fortune at any time. The method should contain the logic that is already present in the code provided.
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();
luck = random.Next(100);
TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}