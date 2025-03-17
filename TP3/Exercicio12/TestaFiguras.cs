namespace Exercicio12;

class TestaFiguras {
    static void Main(string[] args) {
        
        Circulo circulo = new Circulo(3.0);
        double areaCirculo = circulo.CalcularArea();
        Console.WriteLine($"Área do Círculo (Raio: 3.0): {areaCirculo:F2}");


        Esfera esfera = new Esfera(5.0);
        double volumeEsfera = esfera.CalcularVolume();
        Console.WriteLine($"Volume da Esfera (Raio: 5.0): {volumeEsfera:F2}");

    }
}