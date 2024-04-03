using System.ComponentModel.DataAnnotations;

namespace MedicalClinicWebApp.Models
{
    public class Person
    {
        [Key]
        public string Pesel { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string ZipCode { get; set; } = "";

        public Person(){}
    }
}
