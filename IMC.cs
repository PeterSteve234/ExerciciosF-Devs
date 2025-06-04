using System;

class Program
{
    static void Main(string[] args)
    {
        // Calculo de IMC 
        Console.WriteLine("\n Digite seu peso");
        string pesoString = Console.ReadLine(); // OBS; aqui eu usei string, já que no c# tenho que converter o valor da variavel...

        Console.WriteLine("\n Digite sua Altura");
        string alturaString = Console.ReadLine(); // O mesmo vale aqui! :)

        if (!double.TryParse(pesoString, out double peso) || !double.TryParse(alturaString, out double altura))
        {
            Console.WriteLine("Entrada inválida, tente com números válidos e tente novamente");
            return;
        }

        double indiceDeMassaCorporal = peso / (altura * altura);

        // Mostrando o indice para o usuário:
        Console.WriteLine("/* IMC (kg/m²) |	 Classificação");
        Console.WriteLine("Abaixo de 18,5 |	 Abaixo do peso");
        Console.WriteLine("18,5 a 24,9	  |  Peso normal");
        Console.WriteLine("25,0 a 29,9	  |  Sobrepeso");
        Console.WriteLine("30,0 a 34,9	  |  Obesidade grau I");
        Console.WriteLine("35,0 a 39,9    |	 Obesidade grau II (severa)");
        Console.WriteLine("40,0           |  ou mais	Obesidade grau III (mórbida) */");
        Console.WriteLine("Apartir de obesidade de grau I, é recomendado procurar uma unidade de saúde, sedentarismo e uma alimentação irregular");
        Console.WriteLine("pode ser grave!");

        if (indiceDeMassaCorporal < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (indiceDeMassaCorporal >= 18.5 && indiceDeMassaCorporal <= 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (indiceDeMassaCorporal >= 25.0 && indiceDeMassaCorporal <= 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (indiceDeMassaCorporal >= 30.0 && indiceDeMassaCorporal <= 34.9)
        {
            Console.WriteLine("Obesidade Grau I ");
        }
        else if (indiceDeMassaCorporal >= 35.0 && indiceDeMassaCorporal <= 39.9)
        {
            Console.WriteLine("Obesidade Grau II, Vai malhar mano...");
        }
    }
}
