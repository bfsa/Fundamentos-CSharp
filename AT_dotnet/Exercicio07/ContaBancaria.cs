namespace Exercicio07;

public class ContaBancaria {
    public string Titular { get; set; }
    private decimal _saldo;
    public ContaBancaria(string titular, decimal saldoInicial = 0) {
        Titular = titular;
        
        if (saldoInicial < 0) {
            Console.WriteLine(
                "Não é possível criar uma conta com saldo negativo. Saldo inicial definido como R$ 0,00.");
            _saldo = 0;
        }
        else {
            _saldo = saldoInicial;
        }
    }
    public bool Depositar(decimal valor) {
        if (valor <= 0) {
            Console.WriteLine("O valor do depósito deve ser positivo!");
            return false;
        }

        _saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        return true;
    }
    public bool Sacar(decimal valor) {
        if (valor <= 0) {
            Console.WriteLine("O valor do saque deve ser positivo!");
            return false;
        }
        
        if (valor > _saldo) {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
            return false;
        }
        
        _saldo -= valor;
        Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        return true;
    }
    
    public void ExibirSaldo() {
        Console.WriteLine($"Saldo atual: R$ {_saldo:F2}");
    }
}