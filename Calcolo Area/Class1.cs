using System;

namespace Calcolo_Area
{
    public class WrongInputException : Exception
    {
        public WrongInputException(string message) : base(message)
        {
            Console.WriteLine("Forma non riconosciuta");
        }
    }
    public class Calcolo
    {
        private Int32 a;
        private Int32 b;
        private string Forma;
        public int Area(string forma, Int32 bas, Int32 altezza)
        {
            a = bas;
            b = altezza;
            Forma = forma;

            switch (Forma) {
                case "Quadrato":
                case "Rettangolo":
                    return a * b;
                case "Triangolo":
                    return a * b / 2;
                default:
                    throw (new WrongInputException("Forma non riconosciuta"));
            }
        }
    }
}
