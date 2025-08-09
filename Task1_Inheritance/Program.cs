namespace Task1_Inheritance
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

        }
    }
}
