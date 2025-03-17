namespace Exercicio01;

public class Carro {
    
    public string Modelo;
    public double VelocidadeAtual;

    public Carro(string modelo) {
        Modelo = modelo;
        VelocidadeAtual = 0;
    }

    public void Acelerar(double incremento) {
        VelocidadeAtual += incremento;
        Console.WriteLine($"{Modelo} acelerou {incremento} km/h. Velocidade atual: " + VelocidadeAtual + "km/h");
    }
    
    class Program {
        static void Main(string[] args) {
        
            Carro carro = new Carro("Montana");
            carro.Acelerar(5);
            carro.Acelerar(10);
            carro.Acelerar(15);
            carro.Acelerar(600);
        }
    }

}