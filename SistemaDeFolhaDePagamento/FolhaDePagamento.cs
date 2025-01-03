using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeFolhaDePagamento;

public class FolhaDePagamento
{
    public List<Funcionario> Funcionarios { get; set; }

    public FolhaDePagamento()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void GerarRelatorio()
    {
        Console.WriteLine("\n*** Relatório de Folha de Pagamento ***\n");
        foreach (var funcionario in Funcionarios)
        {
            Console.WriteLine(funcionario);
        }
        Console.WriteLine("\n*** Fim do Relatório ***");
    }
}
