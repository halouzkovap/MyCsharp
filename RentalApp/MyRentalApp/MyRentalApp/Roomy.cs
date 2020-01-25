using System;
using System.Collections.Generic;

namespace MyRentalApp
{
    public class Roomy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string PernamentAddress { get; set; }
        public string Email { get; set; }
        public string StartOfRent { get; set; }
        public string PeriodOfRent { get; set; }

        public readonly List<ListOfRealty> realties = new List<ListOfRealty>();

    }
}
