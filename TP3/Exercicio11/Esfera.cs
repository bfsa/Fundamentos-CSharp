namespace Exercicio11;

public class Esfera {
    private double raio;

    public Esfera(double raio) {
        this.raio = raio;
    }

    public double CalcularVolume() {
        return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
    }
}