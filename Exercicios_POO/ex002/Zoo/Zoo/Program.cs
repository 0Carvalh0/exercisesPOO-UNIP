using Zoo;

public class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Aula-03-Zoo";


        Animals dog = new Dog(25, "cachorro");

        Console.WriteLine($"Espécie: {dog.Especie}\n" + $"Peso: {dog.Peso} Kg");

        dog.HowToEat();

        Animals cat = new Cat(12, "gato");

        Console.WriteLine($"Espécie: {cat.Especie}\n" + $"Peso: {cat.Peso} Kg");

        cat.HowToEat();

        List<Mouse> ratos = new List<Mouse>();

        ratos.Add(new Mouse(5, "Will"));
        ratos.Add(new Mouse(1, "Tom"));
        ratos.Add(new Mouse(3, "Einstein"));

        foreach(Mouse item in ratos)
        {
            Console.WriteLine($"\nIdade: {item.Age}\n" +
                $"Nome: {item.Name}");
        }

        Console.WriteLine("A lista tem {0} elementos", ratos.Count);

        Console.WriteLine("O {0} rato da lista tem nome {1}", 1+1, ratos[1].Name);
    }
}
