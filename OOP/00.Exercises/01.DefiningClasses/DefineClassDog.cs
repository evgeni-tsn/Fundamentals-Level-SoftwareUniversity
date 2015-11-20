using System;
namespace _01.DefineClassDog
{
    class DefineClassDog
    {
        static void Main()
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepherd";
            unnamed.Bark();
            sharo.Bark();
        }
    }
}
