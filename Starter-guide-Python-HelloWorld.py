#first things first download the IDE or rather IDLE from Python's website at
#https://www.python.org/downloads/ I'd personally stick with the 3.X version

#Once it's downloaded and installed, search your pc for the IDLE and launch it
#click on file -> new file and a new window should appear, this is what's used for programming/typing in

#we'll make a simple program that outputs "hello world" to a user

#we have to tell the computer two things, what it has to do and what data to do the thing with

#what it has to do is output something which uses the "print keyword" and the data is "hello world"

#So our first line of code looks like this

print("Hello World") 

#pressing F5 will run this after saving

#say we want to do something more advanced like outputting two things at once, all we have to do is add a plus sign inbetween
#the two things

name = "James"
surname = "Matchett"

print(name + " " + surname)

#pressing F5 and saving this will output both strings with a space in the middle

#To finish up I'll do some basic user input manipulation

#starting with a fresh blank program we'll first ask the user for their first name

name = input("Please enter your first name ")

#The instruction "input", outputs a statement to the user and records what they reply if you put an "x = " in front of it

#we'll do the same for the surname, with a line space between the two

print("")
surname = input("Please enter your surname ")

#now we'll return this to the user

print("Your full name is "+name+" "+surname)

#if you need any more help getting into python just raise an issue!
