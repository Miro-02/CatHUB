using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CatHub.Data

{
    public class AppUser : IdentityUser
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private int age;
        private bool isSubscribed;
        private string? country;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber1 { get => phoneNumber; set => phoneNumber = value; }
        public int Age { get => age; set => age = value; }
        public bool IsSubscribed { get => isSubscribed; set => isSubscribed = value; }
        public string? Country { get => country; set => country = value; }


    }
}
