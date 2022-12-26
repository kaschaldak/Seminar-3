// Задача 19/ Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Enter SetNumber : ");
int SetNumber = Convert.ToInt32(Console.ReadLine ());
int  numPalindrome  =  SetNumber ( "Palindrome " );

bool  isPalindrome  =  IsPalindromeInt( numPalindrome );

// bool isPalindrome = IsPalindromeString(numPalindrome.ToString());

string str  =  isPalindrome  ?  " является палиндромом "  :  " не является палиндромом " ;

if (  isPalindrome )
{
    str  =  " является палиндромом " ;
}
else
{
    str  =  " не является палиндромом " ;
}
System.Console. WriteLine ( $" число { numPalindrome } { str } " );