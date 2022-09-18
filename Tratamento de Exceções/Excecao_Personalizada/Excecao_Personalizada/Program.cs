using Excecao_Personalizada.Entities;
using Excecao_Personalizada.Entities.Exceptions;

namespace Excecao_Personalizada
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * There are basically three ways to display Custom Exceptions in C#: 2 non-viable
             * ways and 1 viable way.
             *
             * One of the 2 ways that should not be used is to handle the exception inside loops
             * conditionals in the application itself (program.cs) and the other way is to handle
             * the exception within base class methods.
             *
             * The most used and recommended way to create and treat exceptionally specials is a
             * class for as an exceptional of this domain, as shown code.
             */
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}