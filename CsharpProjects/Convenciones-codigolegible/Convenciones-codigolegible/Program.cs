using System;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90,0 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89,0,0 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 ,0,0};
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92,0 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91,0 };
        string[] nameStudents = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        int[] sum = new int[8];
        decimal[] score = new decimal[8];
        string[] typeNote = new string[nameStudents.Length + 1];

        //Sumando los puntos de cada alumno
        for (int i = 0; i < currentAssignments; i++)
        {
            sum[0] += sophiaScores[i];
            sum[1]+= andrewScores[i];
            sum[2]+= emmaScores[i];
            sum[3]+= loganScores[i];
            sum[4] += beckyScores[i];
            sum[5] += chrisScores[i];
            sum[6] += ericScores[i];
            sum[7] += gregorScores[i];
        }

        //Obteniendo la media de cada alumno
        for (int i = 0; i < nameStudents.Length; i++)
        {
            score[i] = (decimal)sum[i] / currentAssignments;
        }

        Console.WriteLine(nameStudents.Length);
        //Seteando el tipo de nota segun su media y ademnas teniendo en cuenta que cada indice pertenece a un estudiante.
        for (int i = 0; i < score.Length; i++)
        {
            if (score[i] >= 97)
            {
                typeNote[i] = "A+";
            }
            else if (score[i] >= 93)
            {
                typeNote[i] = "A";
            }
            else if (score[i] >= 90)
            {
                typeNote[i] = "A-";
            }
            else if (score[i] >= 87)
            {
                typeNote[i] = "B+";
            }
            else if (score[i] >= 83)
            {
                typeNote[i] = "B";
            }
            else if (score[i] >= 80)
            {
                typeNote[i] = "B-";
            }
            else if (score[i] >= 77)
            {
                typeNote[i] = "C+";
            }
            else if (score[i] >= 73)
            {
                typeNote[i] = "C";
            }
            else if (score[i] >= 70)
            {
                typeNote[i] = "C-";
            }
            else if (score[i] >= 67)
            {
                typeNote[i] = "C";
            }
            else if (score[i] >= 63)
            {
                typeNote[i] = "D";
            }
            else if (score[i] >= 60)
            {
                typeNote[i] = "D-";
            }
        }

        //Monstrando por consola el resultado.
        Console.WriteLine(@"Student         Grade");
        for (int i = 0; i < nameStudents.Length; i++)
        {
            Console.WriteLine($@"{nameStudents[i]}          {score[i]}      {typeNote[i]}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

        string[] nameRegiones = new string[10];
        int[] regiones = new int[10];



    }
}