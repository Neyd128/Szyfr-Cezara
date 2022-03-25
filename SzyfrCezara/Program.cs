using System;
using static System.Array;
using static System.Char;

class MainClass
{
    static void Main(string[] args)
    {
        char[] alfabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.WriteLine("Wpisz tutaj tekst do zaszyfrowania");
        string tekst = Console.ReadLine();

        char[] secretMessage = tekst.ToCharArray();



        Console.WriteLine("podaj ilość przesunięcie");
        int przesuniecie = Convert.ToInt32(Console.ReadLine());



        char[] zaszyfrowane = new char[secretMessage.Length];



        int i;
        for (i = 0; i < secretMessage.Length; i++)
        {
            char secretItem = secretMessage[i];
            int index = Array.IndexOf(alfabet, secretItem);
            int letterPosition = (index += przesuniecie) % 26;
            char encryptedCharacter = alfabet[letterPosition];
            zaszyfrowane[i] = encryptedCharacter;
        }




        string zakodowane = String.Join("", zaszyfrowane);
        Console.WriteLine("zaszyfrowane:");
        Console.Write(zakodowane);
    }





}