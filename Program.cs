﻿// Задача 23/ Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int num = SetNumber (" N ");
int [] CubeTable ( int  n );
{
    int [] arr  =  new int [ n ];

   for ( int  i  =  1 ; i  <=  п ; i ++ )
    {
        arr [ i  -  1 ] =  i  *  i  *  i ;
    }

    return arr ;
}
