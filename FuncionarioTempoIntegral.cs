
public class FuncionarioTempoIntegral : Funcionario, IBonus //HERANÇA Declaração da classe FuncionarioTempoIntegral que herda de Funcionario e implementa a interface IBonus
{
    // Variável privada 
    private double SalarioMensal; //ENCAPSULAMENTO

    //Construtor parametrizado para inicializar o nome, matrícula e salário mensal
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula) // Base Chama o construtor da classe base Funcionario
    {
        SalarioMensal = salarioMensal;
    }

    public override double CalcularSalario()//POLIMORFISMO método abstrato para calcular o salário
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()//POLIMORFISO método abstrato para exibir informações do funcionário
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário Mensal: {SalarioMensal}");
        Console.WriteLine($"Projetos: {string.Join(", ", Projetos)}");
    }

    public double CalcularBonus()//POLIMORFISMO método da interface IBonus para calcular o bônus
    {
        return SalarioMensal * 0.10; // Retorna 10% do salário mensal como bônus
    }
}
