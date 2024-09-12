
using estacionamento.Models;

Estacionamento estacionamento1 = new Estacionamento();

bool exibirmeu = true;

Console.WriteLine("=====================================================");
Console.WriteLine("------Seja bem-vindo ao sistema de estacinamento----- ");
Console.WriteLine("=====================================================");

Console.WriteLine("Informe o valor inicial:  ");
Double valueInit = Convert.ToDouble(Console.ReadLine());
estacionamento1.valueInit = valueInit;

Console.WriteLine("=====================================================");
Console.WriteLine("Informe o valor por hora:  ");
Double valueForhour = Convert.ToDouble(Console.ReadLine());
estacionamento1.forHouer = valueForhour;
Console.WriteLine("Dados salvos com sucesso!");
Console.Clear();

while (exibirmeu)
{
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Digite uma Opção: ");
    Console.WriteLine("1 - Cadastrar Veiculo ");
    Console.WriteLine("2 - Remover veículo ");
    Console.WriteLine("3 - Listar veículos ");
    Console.WriteLine("4 - Encerrar ");

    string? opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            estacionamento1.carPlate();
            break;
        case "2":
            estacionamento1.removeCars();
            break;
        case "3":
            estacionamento1.listCars();
            break;
        case "4":
            Console.WriteLine("Encerrando...");
            exibirmeu = false;
            break;
        default:
            break;
    }
}

static void menu(){
    
}