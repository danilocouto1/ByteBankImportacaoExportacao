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
        static void testeEntrada()
        {
            using (var fluxo = Console.OpenStandardInput())
            using (var fs = new FileStream("entrada.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                while (true)
                {
                    var bytelidos = fluxo.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, bytelidos);

                    fs.Flush();
                    Console.WriteLine(bytelidos + " : BytesLidos no Console");
                }
            }
        }
    }
}
