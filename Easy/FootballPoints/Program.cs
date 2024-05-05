﻿/* Football Points
Create a function that takes the number of wins, draws and losses and calculates the number
of points a football team has obtained so far.

wins get 3 points
draws get 1 point
losses get 0 points

Examples:

FootballPoints(3, 4, 2) ➞ 13

FootballPoints(5, 0, 2) ➞ 15

FootballPoints(0, 0, 1) ➞ 0

*/

using System;
class Program {

    public static void Main(string[] args) { 

        //reading intput:
    int wins = int.Parse(Console.ReadLine()); 
    int draws = int.Parse(Console.ReadLine());
    int losses = int.Parse(Console.ReadLine());

        //printing output:
    Console.WriteLine(FootballPoints(wins, draws, losses));
    }

    //method that calculates football points:
    public static int FootballPoints(int wins, int draws, int losses) {

        return (wins * 3) + (draws * 1) + (losses * 0);
    }
    
    
    
    }
