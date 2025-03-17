namespace Exercicio11;

public class Circulo {
    private double raio;

    public Circulo(double raio) {
        this.raio = raio;
    }

    public double CalcularArea() {
        return Math.PI * (raio * raio);
    }
}