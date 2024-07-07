
public abstract class Funcionario //ABSTRAÇAO, Declaração da classe abstrata Funcionario
{
    // Variáveis públicas 
    public string Nome ;
    public int Matricula ;
    public List<string> Projetos ;

    public Funcionario(string nome, int matricula)// Construtor para inicializar o nome e a matrícula
    {
        Nome = nome;
        Matricula = matricula;
        Projetos = new List<string>(); // Inicializa a lista de projetos como uma nova lista vazia
    }


    public abstract double CalcularSalario();//POLOMORFISMO , Declaração de método abstrato 

    public abstract void ExibirInformacoes();//POLOMORFISMO , Declaração de método abstrato 

    public void AdicionarProjeto(string projeto)//SOBRECARGA DE METODOS , Método para adicionar um único projeto à lista de projetos
    {
        Projetos.Add(projeto);
    }


    public void AdicionarProjeto(List<string> projetos)//SOBRECARG METODOS , Método para adicionar uma lista de projetos à lista de projetos
    {
        Projetos.AddRange(projetos); // Adiciona todos os projetos da lista passada como argumento
    }
}
