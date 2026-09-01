using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class Doctor
    {
        public string FullName { get; set; }
        public int Age { get; set; }


        public string Email { get; set; }
        public string Adress { get; set; }
        public Doctor(string fullName, int age, string email, string adress)
        {
            FullName = fullName;
            Age = age;
            Email = email;
            Adress = adress;
        }
        public void GetAll()
        {
            Console.WriteLine($"FullName: {FullName}, Age: {Age}, Email: {Email}, Adress: {Adress}");
        }
        public void SearchByFullName(Doctor[] doctors, string fullName)
        {
            foreach (var doctor in doctors)
            {
                if (doctor.FullName == fullName)
                {
                    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Adress: {doctor.Adress}");
                    return;
                }
            }
            Console.WriteLine("Doctor not found.");
        }
        public void SortByAge(Doctor[] doctors)
        {
            Array.Sort(doctors, (d1, d2) => d1.Age.CompareTo(d2.Age));
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Adress: {doctor.Adress}");
            }
        }
        public void GetAverageByAge(Doctor[] doctors)
        {
            double averageAge = 0;
            foreach (var doctor in doctors)
            {
                averageAge += doctor.Age;
            }
            averageAge /= doctors.Length;
            Console.WriteLine($"Average Age: {averageAge}");
        }
    }
}
