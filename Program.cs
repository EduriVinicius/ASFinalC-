     Empresa empresa = new Empresa(); // Cria uma instância da classe Empresa
        bool continuar = true; // Variável para controlar o loop do menu


        while (continuar)   // Loop para exibir o menu e interagir com o usuário
        {
            // Exibe as opções do menu no console
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar funcionário de tempo integral");
            Console.WriteLine("2. Adicionar funcionário de meio período");
            Console.WriteLine("3. Remover um funcionário");
            Console.WriteLine("4. Exibir informações de todos os funcionários");
            Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
            Console.WriteLine("6. Sair");
        

            int opcao = int.Parse(Console.ReadLine());// Lê a opção escolhida pelo usuário no console

      
            switch (opcao)  // Executa a ação correspondente à opção escolhida no console
            {
                case 1: // Adiciona um funcionário de tempo integral
                    Console.Write("Nome: ");
                    string nomeFuncIntg = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    int matriculaFuncInteg = int.Parse(Console.ReadLine());
                    Console.Write("Salário Mensal: ");
                    double salarioFuncInteg = double.Parse(Console.ReadLine());

                     //Instancia direta.
                    empresa.AdicionarFuncionario(new FuncionarioTempoIntegral(nomeFuncIntg, matriculaFuncInteg, salarioFuncInteg));
                    break;


                case 2:  // Adiciona um funcionário de meio período
                    Console.Write("Nome: ");
                    string nomeMeioPer = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    int matriculaMeioPer = int.Parse(Console.ReadLine());
                    Console.Write("Salário por Hora: ");
                    double salarioMeioPer = double.Parse(Console.ReadLine());
                    Console.Write("Horas Trabalhadas: ");
                    int horasMeioPer = int.Parse(Console.ReadLine());

                    //Instancia direta.
                    empresa.AdicionarFuncionario(new FuncionarioMeioPeriodo(nomeMeioPer, matriculaMeioPer, salarioMeioPer, horasMeioPer));
                    // FuncionarioMeioPeriodo funcMeioPeriodo = new FuncionarioMeioPeriodo();
                    // funcMeioPeriodo.Nome = nomeMeioPer;
                    // funcMeioPeriodo.Matricula = matriculaMeioPer;
                    // funcMeioPeriodo.salarioPorHora = salarioMeioPer;
                    // funcMeioPeriodo.numeroDeHorasTrabalhadas = horasMeioPer;
                    // empresa.AdicionarFuncionario(funcMeioPeriodo);

                    break;


                case 3:// Remove um funcionário
                    Console.Write("Matrícula do funcionário a ser removido: ");
                    int matriculaRemover = int.Parse(Console.ReadLine());
                    empresa.RemoverFuncionario(matriculaRemover);

                    break;


                case 4:// Exibe informações de todos os funcionários
                    empresa.ExibirFuncionarios();

                    break;


                    case 5:
                    // Adiciona projetos a um funcionário
                    Console.Write("Matrícula do funcionário: ");
                    int matriculaProjeto = int.Parse(Console.ReadLine());
                    var funcionario = empresa.funcionarios.FirstOrDefault(f => f.Matricula == matriculaProjeto); // Expressao Lamdbda (i => i.Matricula == matriculaProjeto) compara a matrículas dentro da lista sao iguai e para atribuir na variavel funcionario caso contario funcionario será 'null' 
                    
                    if (funcionario != null)
                    {
                        Console.Write("Digite o projeto a ser adicionado: ");
                        string projeto = Console.ReadLine();
                        funcionario.AdicionarProjeto(projeto);
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }
                    break;


                case 6:
                    // Sai do programa
                    continuar = false;
                    break;


                default:
                    // Informa opção inválida
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

 