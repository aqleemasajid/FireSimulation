using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FireSimulation
{
    class Grid 
    {
        Queue q = new Queue();
        Pair p;
        int[,] data = new int[21, 21];//declaration of 2D array  
                                      // static char[,] forest;
       // public bool checkIFTouchingBoundry();
       public double getProbabilty()
        {
            return 6.0;
        }
        public Grid(int x = 0, int y = 0)
        {
           // forest = new char[x, y];
            int i, j;

            for (i = 0; i < 21; i++)
            {
                for (j = 0; j < 21; j++)
                {
                    if (i == 0 || i == x - 1 || j == 0 || j == y - 1)
                        // forest[i, j] = ' ';
                        data[i, j] = 2;
                    else
                        data[i, j] = 0;
                }
            }
            data[x / 2, y / 2] =1 ;
        }
        
        public void displayForrest()
        {
            int i, j;
            for (i = 0; i < 21; i++)
            {
                for (j = 0; j < 21; j++)
                {
                    if (data[i, j] == 0)
                        Console.WriteLine('&');
                    else if (data[i, j] == 1)
                        Console.WriteLine('X');
                    else
                        Console.WriteLine(' ');
                }
                Console.WriteLine();
            }
        }

       public void evolve()
        {
            for(int i=0;i<=20;i++)
            {
                for(int j=0;j<=20;j++)
                {
                    if(data[i,j]==0)
                    {
                        if((j-1>=0&&data[i,j-1]==1)||(j+1<21 && data[i,j+1]==1)|| (i+1<21 && data[i+1,j]==1)|| (i-1>=0 && data[i-1,j]==1))
                        {
                            double p = getProbabilty();
                            if(p>=0.5)
                            {
                                data[i, j] = 1;
                                Pair p;
                                p.r = i;
                                p.c = j;
                            }
                        }
                    }
                }
            }
            if(checkIFTouchingBoundry())
            {

            }

        }
        public bool checkIFTouchingBoundry()
        {
            bool flag = false, flag2 = false;
            for(int i=0;i<=20 && !flag;i++)
            {
                if (data[i, 20] == 1)
                    flag = true;
            }
            for (int i = 0; i <= 20 && !flag2; i++)
            {
                if (data[20, i] == 1)
                    flag2 = true;
            }
            return flag || flag2;

        }
        public void turnFires


    }
}
