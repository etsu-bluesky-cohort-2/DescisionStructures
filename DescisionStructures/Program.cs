//data types

//primitive data types
//
byte smallWholeNumber = 5;
short slightLargerWholeNumber = 1223;
int wholeNumber = 1000000;
long largerWholNumber = 1234672346327453243;
float lessAccurateDecimal = 12.34F;
double littleMoreAccurateLessPresiseDecimal = 1234.23232;
decimal mostAccurateLeastPresiseDecimal = 12327.2337543735234M;

char aNumberButRepresentedByASingleLetter = 'A';
bool aTrueOfFalse = false;



//Arrays
//the storage on memory is the memory locatoin where the values "span" or are located
int[] numbers = { 1, 2, 3, 4, 5 };

int[] anotherSetOfNumbers = new int[5];
anotherSetOfNumbers[0] = 1;
anotherSetOfNumbers[1] = 2;
anotherSetOfNumbers[2] = 3;
anotherSetOfNumbers[3] = 4;
anotherSetOfNumbers[4] = 5;

string collectionOfCharacters = "Some String";


//any numbers default value is 0

//null means that no memory allocation exists or pointer or reference to a memory location
/*
Console.Write("What is your age? ");
int age = Convert.ToInt32(Console.ReadLine());
*/

//NO! BAD
//var someVal = Console.Write("Some text");


//string interpolation
//Console.WriteLine($"My age is {age}.");
//string concatanation
//Console.WriteLine("My age is " + age + ".");

string name = "Matt";

//a single item in name is a character
Console.WriteLine(name[0].GetType());

//play around with the diffent Properties and Methods within a the string class
//get to know what something can do. Explore!
Console.WriteLine(name.Length);

/*
 * +
 * -
 * *
 * /

// = assignment operator 

/
 * Comparision Operators
 * <
 * >
 * ==
 * !=
 * <=
 * >=
 * 
 */

//decision stuctures



/*
 * Logical Operators
 * &&
 * ||
 * !
 * 
 */
  //inside the parentheses we have a boolean expresion. We are using comparision
  //operators to make a comparision with something to produce.....
  //True or False

if(4 == 4)
{
    //if true this block of code will execute
    Console.WriteLine("This executed because matt hard coded 4 == to 4");
}
if(4 == 5)
{
    //this will never occur because this can neber be true
}

/*
Console.Write("Give me a number 1!");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
    //the next line of code will execute if no braces exists
    Console.WriteLine("This statement will execute because you entered 1!");
Console.WriteLine("This one will always execute regardless of what number you entered!");

if (name is null)
{

}

if (name.EndsWith('t'))
{

}
*/
string luck = "neutral";

Console.WriteLine($"Your current luck is {luck}.");

Console.WriteLine("A penny was found!");
Console.Write("Is it on heads or tails? ");
string penny = Console.ReadLine();



if (penny.ToUpper() == "HEADS")
{
    Console.WriteLine("I picked up the penny!");
    
}
else
{
    Console.WriteLine("*You flipped it over for the next person*");
    luck = "good";
}

Console.WriteLine($"Your current luck is {luck}.");
