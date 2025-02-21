using DogMeeting_Joao;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Aula-02-Dog-Meeting";
        string firstDogName = null;
        Console.Write("Digite o nome do dog: ");
        firstDogName = Console.ReadLine();

        Dog firstDog = new Dog(firstDogName);

        Dog secondDog = new Dog();

            Dog[] dogs = new Dog[]
            {
                firstDog,
                secondDog
            };

        foreach (Dog item in dogs)
        {
            item.Bark();
        }

        Console.WriteLine("=================================================");

        Cat bichano = new Cat();
        Cat bichanoDois = new Cat("Bob");
        bichano.Bark();
        Console.WriteLine("O gato se chama {0}", bichanoDois.Nome);
        float price;
        Console.WriteLine("Digite o preco do gato: ");
        price = float.Parse(Console.ReadLine());

        Cat bichanoTres = new Cat(price);

        Dog[] cats = new Cat[]
            {
                bichano,
                bichanoDois,
                bichanoTres
            };

        foreach (Cat item in cats)
        {
            item.Miau();
        }

        Console.WriteLine("Gato tem preco: R${0}", bichanoTres.Preco);

        Console.WriteLine("Gato tem desconto: R${0}", bichanoTres.desconto(bichanoTres.Preco, price));
    }
}
