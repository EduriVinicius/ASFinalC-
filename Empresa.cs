
public class Empresa
{

    public List<Funcionario> funcionarios; 

    public Empresa()//Construtor inicializar lista de funcionários
    {
        funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)// Método 
    {
        funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)// Método 
    {
        funcionarios.RemoveAll(i => i.Matricula == matricula); // Remove todos os funcionários com a matrícula especificada. Expressao Lamdbda (i => i.Matricula == matricula) é uma maneira concisa de escrever uma função anônima.Ele compara a matrícula do funcionário atual (i.Matricula) com a matrícula fornecida como argumento (matricula).
    }

    public void ExibirFuncionarios()// Método 
    {
        foreach (var funcionario in funcionarios) // Percorrer lista de funcionários
        {
            funcionario.ExibirInformacoes();
            Console.WriteLine(); // Adiciona uma linha em branco
        }
    }
}
