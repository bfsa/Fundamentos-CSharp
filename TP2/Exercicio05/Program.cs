namespace Exercicio05;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite uma temperatura (em Celsius): ");
        
        double temperaturaCelsius = double.Parse(Console.ReadLine());
        double temperaturaFahrenheit = (temperaturaCelsius * 9/5) + 32;
        double temperaturaKelvin = temperaturaCelsius + 273.15;
        
        Console.WriteLine($"Temperatura Celsius: {temperaturaCelsius} \u00b0C");
        Console.WriteLine($"Temperatura Fahrenheit: {temperaturaFahrenheit:F2} \u00b0F");
        Console.WriteLine($"Temperatura Kelvin: {temperaturaKelvin:F2} K");



    }
}