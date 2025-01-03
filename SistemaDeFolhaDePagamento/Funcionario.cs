using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeFolhaDePagamento;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioBase { get; set; }
    public decimal Beneficios { get; set; }
    public decimal Descontos { get; set; }

    public Funcionario(string nome, string cargo, decimal salarioBase, decimal beneficios, decimal descontos)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
        Beneficios = beneficios;
        Descontos = descontos;
    }

    public decimal SalarioFinal()
    {
        return SalarioBase + Beneficios - Descontos;
    }

    public override string ToString()
    {
        return $"{Nome} ({Cargo}) - Salário: R${SalarioBase:F2}, Benefícios: R${Beneficios:F2}, Descontos: R${Descontos:F2}, Salário Final: R${SalarioFinal():F2}";
    }
}
