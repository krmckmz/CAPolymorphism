public class Program
{
    public static void main(String[] args)
    {
        //Overloading

        Calculation obj = new Calculation();
        obj.Sum(5, 7);
        obj.Sum(5, 7, 2);

        //Overriding
        Animal animal = new Animal();
        Animal dog = new Dog();

        animal.Move();
        dog.Move();

    }
}