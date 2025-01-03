using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SistemaDeFolhaDePagamento
{
    public class SistemaDeFolha
    {
        private static string caminhoArquivo = "funcionarios.json";

        public static void SalvarFuncionarios(List<Funcionario> funcionarios)
        {
            string json = JsonConvert.SerializeObject(funcionarios, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, json);
        }

        public static List<Funcionario> CarregarFuncionarios()
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Funcionario>>(json);
            }
            return new List<Funcionario>();

        }
}
