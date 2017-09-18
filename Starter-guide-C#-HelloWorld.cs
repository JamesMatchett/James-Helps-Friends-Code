//Hello world tutorial for C#
//First things first download visual studio, whatever version seems best for you (usually the more modern versions)
//https://www.visualstudio.com/ choose the IDE option from here, download & install


//once it's installed start up visual studio
//then File -> New -> Project

//Then in the submenu C# -> Console Application -> Ok

//A blank program file for C# will be generated, this is where the coding is done

//to get a computer to output "Hello world" we have to tell it two things
//what it has to do, and the data it does the thing with
//in this case what it has to do is "Console.WriteLine();"
//and the data is "Hello World";

//inbetween the two { } below Static Void Main() type in

Console.WriteLine("Hello World)";

//this is great and if you run it "hello world" will be output..... for a brief second, we need to keep it on screen longer

//we can do this by telling the console window to wait for an input before continuing 

//just below the Console.WriteLine line add

Console.ReadKey();

//this will keep the console on screen until you press a key on the console then it will code

//if we want to do more advanced string outputs all we need to do is define some strings and use console.WriteLine creatively

//again all of this coding happens between the two { } of static void Main()

string Name;
string Surname;

Console.WriteLine(Name + " " + Surname);

//this is how we output two variables together but there are other ways you may see in other C# programs such as 

Console.WriteLine("{0} {1}", Name, Surname);

//where the curly brackets are in the output, that basically means "replace me with" the xth variable listed at the end of
//the speech marks, so {0} means "replace me with the first variable" which is Name and the same with {1} for the second


//again to see this output on screen we need to add another 
Console.ReadKey();

//I'll finish up with a small bit of handling user inputs
//again starting with a fresh program, typing between the two {} of Static void main

//we'll start by asking the user their first name

Console.WriteLine("Please enter your first name");
//now we have to store what they've typed as a string

string FirstName = Console.ReadLine();

//we'll do the same for the surname

Console.WriteLine("please enter your surname");
//we'll store this as another string

string SurName = Console.ReadLine();

//now we'll return this to the user

Console.WriteLine("Your full name is {0} {1}", FirstName, SurName);
//and we'll keep it on screen

Console.ReadKey();

//hope this helps, if you need any more help just raise another issue



