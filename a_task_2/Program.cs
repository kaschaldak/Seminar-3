// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("введите координаты точек");
Console.WriteLine( " x1 : "  );
int  x1= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( " y1 : "  );
int  y1= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( " z1 : "  );
int  z1= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( " x2 : "  );
int  x2= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( " y2 : "  );
int  y2= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( " z2 : "  );
int  z2= Convert.ToInt32 (Console.ReadLine());



int  x1  =  SetNumber ( " x1 " );
int  y1  =  SetNumber ( " y1 " );
int  z1  =  SetNumber ( " z1 " );
int  x2  =  SetNumber ( " x2 " );
int  y2  =  SetNumber ( " y2 " );
int  z2  =  SetNumber ( " z2 " );

double result   =  DistanceBetween3DPoints ( x1 , x2 , y1 , y2 , z1 , z2 );

Console. WriteLine ( $" result { результат } " );
/* конец */