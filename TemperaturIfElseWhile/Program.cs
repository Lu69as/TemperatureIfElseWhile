using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clone dette prosjektet.

            //oppgave1 - her brukes if/else int.Parse()/TryParse()
            //lag et program som leser inn et tall, en temperatur, fra en bruker
            //programmet ditt skal så skrive ut om det er pluss, minus eller null 

                    //Console.WriteLine("Write your temparature");
                    //int temp = Int32.Parse(Console.ReadLine());
                    //if (temp < 0) {
                    //    Console.WriteLine("Your Temparature is Negative");
                    //}
                    //else if (temp == 0) {
                    //    Console.WriteLine("Your Temparature is Zero");
                    //}
                    //else if (temp > 0) {
                    //    Console.WriteLine("Your Temparature is Positive");
                    //}

            //For å parse fra string til en int må det parses. (Når vi leser fra Console. Console.ReadLine()). Om man bruker int.Parse(), vi programmet krasje om det ikke er en numerisk verdi inntastet
            //Bruk derfor metoden TryParse() https://www.tutorialspoint.com/chash-int-tryparse-method

            //Oppgave 2
            //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet.

                    //Console.WriteLine("Write your temparature");
                    //bool work;
                    //int temp;
                    //work = int.TryParse(Console.ReadLine(), out temp);
                    //if (work == false) {
                    //    Console.WriteLine("That is not a valid temparature");
                    //}
                    //else {
                    //    if (temp < 0) {
                    //        Console.WriteLine("Your Temparature is Negative");
                    //    }
                    //    else if (temp == 0) {
                    //        Console.WriteLine("Your Temparature is Zero");
                    //    }
                    //    else if (temp > 0) {
                    //        Console.WriteLine("Your Temparature is Positive");
                    //    }
                    //}

            //Oppgave 3 - bruk av en loop - while
            //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet, som i oppgave 2. Brukeren skal så få mulighet til å 
            //taste inn en verdi, helt til at en gyldig verdi er inntastet. while er et godt valg av loop her. https://www.programiz.com/csharp-programming/do-while-loop

                Console.WriteLine("Write your temparature:");
                int temp;
                bool valid = false;
                bool failed = false;
                while (valid == false) {
                    if (failed == true) { 
                    Console.WriteLine("Try again, write a real number this time please.");
                    }
                    valid = int.TryParse(Console.ReadLine(), out temp);
                    if (valid == false)
                    {
                        Console.WriteLine("That is not a valid temparature");
                        failed = true;
                    }
                    else
                    {
                        if (temp < 0)
                        {
                            Console.WriteLine("Your Temparature is Negative");
                        }
                        else if (temp == 0)
                        {
                            Console.WriteLine("Your Temparature is Zero");
                        }
                        else if (temp > 0)
                        {
                            Console.WriteLine("Your Temparature is Positive");
                        }
                        valid = true;
                    }
                }

            //oppgave 4
            //Leg det hele i Git. Public repo. Send linken i oppgave i teams.


        }
    }
}
