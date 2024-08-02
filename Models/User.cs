using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly Birthday { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Adreess { get; set; }


        public User(string name, string lastname, string typedocument, string identificationnumber, DateOnly birthday, string phonenumber, string adreess)
        {
            Name = name;
            LastName = lastname;
            TypeDocument = typedocument;
            IdentificationNumber = identificationnumber;
            Birthday = birthday;
            PhoneNumber = phonenumber;
            Adreess = adreess;
        }



        public void ShowDetils()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Apellido: {LastName}");
            Console.WriteLine($"Tipo de Documento: {TypeDocument}");
            Console.WriteLine($"Número de Identificación: {IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {Birthday.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Teléfono: {PhoneNumber}");
            Console.WriteLine($"Dirección: {Adreess}");
            Console.WriteLine("----------------------------------------");
            
        }

        public void CalculateAge()
        {
            int age = DateTime.Today.Year - Birthday.Year;
            int m = DateTime.Today.Month - Birthday.Month;

            if (m < 0 || (m == 0 && DateTime.Today.Day < Birthday.Day))
            {
                age--;
            }

            Console.WriteLine($"Edad: {age} años");
            Console.WriteLine("----------------------------------------");
            
        }


    }
}