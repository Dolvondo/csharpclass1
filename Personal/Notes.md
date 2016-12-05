csharpclass
Notes:

Sudo Coding - write code with no code it's just comments.

------------------

static - means reachable by other files, "Global" - referencing the cookie cutter
public - Viewable by other objects "Is an access modifier"
instancing - is a copy of an object - is the cookie, but not the same as other cookies
class - Is the cookie cutter. And they make objects. Also used to assign attributes to other variables that reference the class
private - private variables are not accessible outside of the script where it was made
reference - anything that is static is referenced. Data that mention the source of data and uses it.
constructor - is the same name as the class and is called when the class is run. When it loads into your RAM the constructor runs. Common in javascript.
    - Runs before programs run
    - Building things the class needs to run
    - Constructer, automatically runs, looks like this  "public Name () {}"
bool / boolean - A variable type that stores "True" or "false"
length - counts the amount of arrays in a variable. Starting with number 1. 
enum - used to store multiple entities that is not a string or an integer. Used as keywords
       that other instances can reference to without feedback errors. The created entities 
       literally stores nothing. AKA: A label
<<<<<<< HEAD

=======
identifier - a crucial part of code that tells a page that a certain class exists
>>>>>>> master

Strategies -
--- Classes are objects that can store/(give away) attributes, which variables can ask for and assign themselves a default attribute. Another file will be for actually setting the proper
stats for the variable. This reduces repatitive clutter.
--- Parenting: with the line of code  [  public class "classname: otherClassName" {}  ] The className will inherit the attributes of the otherCLassName. This is called parenting.


Errors:
If anything doesnt make sense reboot Visual studio

- Object reference not set to an instance of an objects
    * A function is not declared with "  = new function();  "

    Others----------------------------
<<<<<<< HEAD
        - string[]
=======
        - string[]

------------  Random Numbers ----
        Random rnd = new Random();
int month = rnd.Next(1, 13); // creates a number between 1 and 12
int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
int card = rnd.Next(52);     // creates a number between 0 and 51
---------------------------------------------------------

>>>>>>> master
