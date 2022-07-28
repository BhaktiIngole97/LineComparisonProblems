
using Day3Assignment2;

FindLength line1 = new FindLength(); 
FindLength line2 = new FindLength(); 
double length1 = line1.Length(); 
double length2 = line2.Length();
Console.WriteLine("The Equals method ans is : " + length1.Equals(length2));
Console.WriteLine("The CompareTo method ans is : " + length1.CompareTo(length2)); 