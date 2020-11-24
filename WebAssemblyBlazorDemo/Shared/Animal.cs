using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAssemblyBlazorDemo.Shared
{
    public class Animal
    {
        [Required]
        public int Id
        {
            get;
            set;
        }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [NotMapped]
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

        [Range(0,30)]
        public int? EstimatedAge { get; set; }

        [Required]
        [Url(ErrorMessage ="This is nod a valid url")]
        public AnimalKind AnimalKind { get; set; }

        public string PictureUrl { get; set; }

        public Gender Gender { get; set; }

    }
}
