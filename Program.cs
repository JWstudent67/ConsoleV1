/// Summary
///
///
///
/// /Summary

float figure1;
float figure2;

float smallerFigure;

Console.WriteLine("Subtract your enemies!");

Console.Write("How many enemies do you have: ");
figure1 = float.Parse(Console.ReadLine());

Console.Write("How many enemies did you destroy: ");
figure2 = float.Parse(Console.ReadLine());

smallerFigure = figure1 - figure2;

Console.WriteLine("Enemies remaining: " + smallerFigure);
Console.WriteLine("END PROGRAM");
Console.ReadLine();