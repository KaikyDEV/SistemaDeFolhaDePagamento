using System;
using System.Collections.Generic;
using SistemaDeFolhaDePagamento;

class Program
{
    static void Main(string[] args)
    {
        FolhaDePagamento folhaDePagamento = new FolhaDePagamento();
        List<Funcionario> funcionarios = SistemaDeFolha.CarregarFuncionarios();

        // Adicionar funcionários carregados na folha
        foreach (var func in funcionarios)
        {
            folhaDePagamento.AdicionarFuncionario(func);
        }

        bool rodando = true;
        while (rodando)
        {
            Console.Clear();
            Console.WriteLine("*** Sistema de Folha de Pagamento ***");
            Console.WriteLine("1. Cadastrar Funcionário");
            Console.WriteLine("2. Calcular e Exibir Folha de Pagamento");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarFuncionario(folhaDePagamento);
                    break;
                case "2":
                    folhaDePagamento.GerarRelatorio();
                    break;
                case "3":
                    SistemaDeFolha.SalvarFuncionarios(folhaDePagamento.Funcionarios);
                    rodando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void CadastrarFuncionario(FolhaDePagamento folhaDePagamento)
    {
        Console.Clear();
        Console.WriteLine("Cadastro de Funcionário");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Cargo: ");
        string cargo = Console.ReadLine();

        Console.Write("Salário Base: ");
        decimal salarioBase = decimal.Parse(Console.ReadLine());

        Console.Write("Benefícios: ");
        decimal beneficios = decimal.Parse(Console.ReadLine());

        Console.Write("Descontos: ");
        decimal descontos = decimal.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, cargo, salarioBase, beneficios, descontos);
        folhaDePagamento.AdicionarFuncionario(funcionario);

        Console.WriteLine("Funcionário cadastrado com sucesso!");
    }
}