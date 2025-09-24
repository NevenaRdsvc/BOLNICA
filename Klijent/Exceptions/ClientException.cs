using System;

namespace Klijent.Exceptions
{
    public class EmptyStavkeException : Exception
    {
        public EmptyStavkeException() : base("Recept mora imati bar jednu stavku.") { }
    }
}
