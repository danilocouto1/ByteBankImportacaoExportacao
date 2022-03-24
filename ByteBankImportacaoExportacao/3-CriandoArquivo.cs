using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivoCSV(string caminho)
        {
            caminho = caminho + ".csv";
            using (var fluxo = new FileStream(caminho, FileMode.Create))
            {
                
                //var enconding = Encoding.UTF8.GetBytes(stringzada);
                //fluxo.Write(enconding, 0, enconding.Length);
            }
        }
        static void CriarArquivoWrite(string caminho)
        {
            caminho = caminho + ".csv";
            using (var fluxo = new FileStream(caminho, FileMode.CreateNew))
                using(var write = new StreamWriter(fluxo, Encoding.UTF8))
            {
                var stringzada = "123,1234,12.12,Danilo Couto";
                write.Write(stringzada);
            }
        }

    }
}