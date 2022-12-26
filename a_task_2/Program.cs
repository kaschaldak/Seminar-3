﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5

int  x1  =  SetNumber ( " x1 " );
int  y1  =  SetNumber ( " y1 " );
int  z1  =  SetNumber ( " z1 " );
int  x2  =  SetNumber ( " x2 " );
int  y2  =  SetNumber ( " y2 " );
int  z2  =  SetNumber ( " z2 " );

int  SetNumber ( string   numberName )
{
    Console.WriteLine ( $" Введите число  { numberName }: " );
    int num   =  Convert . ToInt32 ( Console.ReadLine ( ) ) ;
    return num;
}

double  DistanceBetween3DPoints ( int  x1 , int  x2 , int  y1 , int  y2 , int  z1 , int  z2 )
{
    return Math . Sqrt ( Math.Pow (( x2 - x1 ) , 2 ) + Math.Pow (( y2 - y1 ) , 2 ) + Math.Pow ( ( z2 - z1 ) , 2 ) ) ;        
}
Console. WriteLine ( $" Расстояние между точками={ distanceBetweenPoints : f2 } " );