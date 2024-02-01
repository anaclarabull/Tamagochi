using Tamagochi_Back;

var tamagochiClient = new TamagochiClient();

do
{
    Console.WriteLine();
    Console.WriteLine("O que você deseja?");
    Console.WriteLine("1 - Listar Tamagochis");
    Console.WriteLine("2 - Buscar tamagochi por nome");
    Console.WriteLine();
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            var tamagochis = tamagochiClient.GetTamagochis();
            tamagochis.ForEach(c => Console.WriteLine(c.ToString()));
            continue;
        case "2":
            Console.WriteLine("Digite o nome do Pokémon:");
            var tamagochiName = Console.ReadLine();
            var tamagochi = tamagochiClient.GetTamagochi(tamagochiName!.ToLower());

            if (tamagochi != null)
            {
                Console.WriteLine($"Informações detalhadas de {tamagochiName}:\n");
                Console.WriteLine($"ID: {tamagochi.Id}");
                Console.WriteLine($"Name: {tamagochi.Name}");
                Console.WriteLine($"Base Experience: {tamagochi.BaseExperience}");
            }
            else
            {
                Console.WriteLine($"Pokémon com o nome {tamagochiName} não encontrado.");
            }
            continue;
        default:
            break;
    }
}

while (true);
