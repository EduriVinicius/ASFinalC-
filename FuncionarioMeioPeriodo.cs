
public class FuncionarioMeioPeriodo : Funcionario, IBonus //HERANÇA Declaração da classe FuncionarioMeioPeriodo que herda de Funcionario e implementa a interface IBonus
{
    // Variáveis privadas 
    private double SalarioPorHora; //ENCAPSULAMENTO
    private int NumeroDeHorasTrabalhadas;//ENCAPSULAMENTO



    // Construtor parametrizado para inicializar o nome, matrícula, salário por hora e número de horas trabalhadas
    public  FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int numeroDeHorasTrabalhadas): base(nome, matricula) // Chama o construtor da classe base Funcionario // HERANÇA
    {
        this.SalarioPorHora = salarioPorHora;
        this.NumeroDeHorasTrabalhadas = numeroDeHorasTrabalhadas;
     
    }


    public override double CalcularSalario()//POLIMORFISMO método abstrato para calcular salário 

    {
        return SalarioPorHora * NumeroDeHorasTrabalhadas;
    }

    public override void ExibirInformacoes()//POLIMORFISMO método abstrato para exibir informações do funcionário
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário por Hora: {SalarioPorHora}");
        Console.WriteLine($"Horas Trabalhadas: {NumeroDeHorasTrabalhadas}");
        Console.WriteLine($"Projetos: {string.Join(", ", Projetos)}");
    }

    public double CalcularBonus()//POLIMORFISMO  Implementação do método da interface IBonus para calcular o bônus
    {
        return CalcularSalario() * 0.05; // Retorna 5% do salário total calculado como bônus
    }



}

