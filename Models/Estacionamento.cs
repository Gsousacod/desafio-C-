using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Estacionamento
    {
        private List<string> parking = new List<string>();

        public double valueInit { get; set; }
        public double forHouer { get; set; }


        public void listCars()
        {
            if (parking.Count == 0)
            {
                Console.WriteLine($"==================================");
                Console.WriteLine($"Ainda não há carros cadastrados:");
            }
            else
            {
                Console.WriteLine($"==================================");
                Console.WriteLine($"=======Carros estacionados:=======");
                int cont = 0;
                foreach (string item in parking)
                {
                    Console.WriteLine($"Vaga ({cont}) -> {item}");
                }
            }
            Console.WriteLine($"==================================");

        }

        public void carPlate()
        {
            Console.WriteLine($"================================================");
            Console.WriteLine("Informe a placa do veículo:");
            String plate = Console.ReadLine();
            parking.Add(plate);
            Console.WriteLine($"================================================");
            Console.WriteLine("Carro adicionado ao estacionamento com sucesso! ");
            Console.WriteLine($"================================================");
        }

        public void removeCars()
        {
            listCars();

            Console.WriteLine("Selecione qual carro deseja remover:(vaga)");
            int vacancy = Convert.ToInt32(Console.ReadLine());
            parking.Remove(parking[vacancy]);
            Console.WriteLine($"================================================");
            Console.WriteLine("Digite a quantidade horas que o veículo permaneceu estacionado:");
            int hours = Convert.ToInt32(Console.ReadLine());
            double total = valueInit + (forHouer*hours);
            Console.WriteLine($"A conta desse Carro deu: {total} ");
            Console.WriteLine($"==================================");
        }
    }
}