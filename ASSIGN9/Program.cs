// See https://aka.ms/new-console-template for more information
// 9. Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C) ?

double celsius, fahrenheit;

Console.WriteLine("enter the temperature in fahrenheit");

fahrenheit = Convert.ToInt32(Console.ReadLine());

celsius = (fahrenheit - 32) * 0.55;

Console.WriteLine(celsius);