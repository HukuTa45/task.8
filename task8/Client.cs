using System;
using System.Collections.Generic;
using System.Text;
using task8.Cats;
using task8.Dogs;

namespace task8
{
    public class Client 
    {
        public string Name { get; }
        public string Phone { get; }
        public List<Pet> Pets { get; }

        public Client(string name, List<Pet> pet, string phone)
        {
            Phone = phone;
            Name = name;
            Pets = pet;
        }

        public override string ToString()
        {
            string type;
            string petList = "";
            Pets.ForEach(delegate (Pet pet)
            {
                switch (pet)
                {

                    case Cat cat:
                        type = pet.GetType().ToString();
                        petList = $"{petList}\nКошка породы {type.Substring(type.IndexOf('.') + type.IndexOf('.') + 1)} по кличке \"{pet.PetName}\" ";
                        break;

                    case Dog dog:
                        type = pet.GetType().ToString();
                        petList = $"{petList}\nСобака породы {type.Substring(type.IndexOf('.')+type.IndexOf('.')+1)} по кличке \"{pet.PetName}\" ";
                        break;
                }
               
            });
            
            return $"\nКлиент: {Name}. Телефон: {Phone}. \nС питомцем(-ами): {petList}\n";
                       
        }
    }
}
