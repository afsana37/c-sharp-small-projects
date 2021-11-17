using System.IO; // include the System.IO namespace

string writeText = "This is a test";

//Create a file and write the content of writeText to it

File.WriteAllText("filename.txt", writeText);

// Read the contents of the file
string readText = File.ReadAllText("filename.txt");

// Output the content
Console.WriteLine(readText);