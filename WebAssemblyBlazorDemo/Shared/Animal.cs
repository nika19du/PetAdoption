using System;
using System.Collections.Generic;
using System.Text;

namespace WebAssemblyBlazorDemo.Shared
{
    public class Animal
    {
        public int Id
        {
            get;
            set;
        }
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int Age
        {
            get 
            {
                if (DateOfBirth.HasValue)
                {
                    var calculateAge = DateTime.Today.Year - DateOfBirth.Value.Year;

                    if (DateTime.Today.DayOfYear< DateOfBirth.Value.DayOfYear)
                    {
                        calculateAge -= 1;
                    }
                    return calculateAge;
                }
                return EstimatedAge.Value;
            } 
        }

        public int? EstimatedAge { get; set; }

        public AnimalKind AnimalKind { get; set; }

        public string PictureUrl { get; set; }

        public Gender Gender { get; set; }

    }
}
