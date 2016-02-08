﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class.
            //It is possible that you will not need these class level ones and can get all of the work done
            //with the local ones. Regardless of how you implement it, here are the class level assignments.
            //Feel free to remove the class level variables and assignments if you determine that you don't need them.
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            Int32 x = xStart;
            Int32 y = yStart;
            Int32 rowLength = maze.GetLength(0);
            Int32 colLength = maze.GetLength(1);
            Int32 maxY = rowLength - 1;
            Int32 maxX = colLength - 1;



            if (yStart <= maxY && yStart >= 0 && xStart <= maxX && xStart >= 0)
            {
                //PrintMaze(maze);
                mazeTraversal(maze, y, x, maxY, maxX);

            }
            else
            {
                Console.WriteLine("Your maze was not loaded successfully.");
            }


            //if (y + 1 > maxY || y - 1 < 0 || x + 1 > maxX || x - 1 < 0)
            //{
            //    maze[y, x] = 'X';
            //    PrintMaze(maze);
            //}
            //else
            //{
            //    mazeTraversal(maze, y, x, maxY, maxX);
            //}

            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(char[,] maze, Int32 y, Int32 x, Int32 maxY, Int32 maxX)
        {
            //Implement maze traversal recursive call
            if (y + 1 > maxY || y - 1 < 0 || x + 1 > maxX || x - 1 < 0)
            {
                maze[y, x] = 'X';
                PrintMaze(maze);
            }
            else
            {
                maze[y, x] = 'O';
                //Down
                if (maze[y + 1, x] == '.')
                {
                    //maze[y, x] = 'O';
                    mazeTraversal(maze, y + 1, x, maxY, maxX);
                }
                //Right
                if (maze[y, x + 1] == '.')
                {
                    //maze[y, x] = 'O';
                    mazeTraversal(maze, y, x + 1, maxY, maxX);
                }
                //Up
                if (maze[y - 1, x] == '.')
                {
                    //maze[y, x] = 'O';
                    mazeTraversal(maze, y - 1, x, maxY, maxX);
                }
                //Left
                if (maze[y, x - 1] == '.')
                {
                    //maze[y, x] = 'O';
                    mazeTraversal(maze, y, x - 1, maxY, maxX);
                }
            }
            



        }

        public void PrintMaze(char[,] maze)
        {
            Int32 rowLength = maze.GetLength(0);
            Int32 colLength = maze.GetLength(1);

            for (Int32 y = 0; y < rowLength; y++)
            {
                for (Int32 x = 0; x < colLength; x++)
                {
                    Console.Write(String.Format("{0} ", maze[y, x]));
                }
                Console.Write(Environment.NewLine);
            }
            //Console.ReadLine(); Used to pause the program for testing.
            Console.WriteLine(Environment.NewLine);
        }
    }
}
