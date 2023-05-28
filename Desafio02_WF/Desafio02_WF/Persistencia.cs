using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_WF
{
    public class Persistencia
    {
        static string arquivoEntrada = "veiculosEntrada.dat";
        static string arquivoSaida = "veiculosSaida.dat";
        public static void lerArquivoVeiculosEntrada(List<Veiculo> listaEntrada)
        {
            StreamReader leitor = new StreamReader(arquivoEntrada);
             String linha;
             String[] vetorDados;
             do
             {
                 linha = leitor.ReadLine();
                 vetorDados = linha.Split(";");

                 string placaVeiculo = vetorDados[0];
                 DateTime dataEntrada = DateTime.Parse(vetorDados[1]);
                 DateTime horaEntrada = DateTime.Parse(vetorDados[2]);

                 listaEntrada.Add(new Veiculo(placaVeiculo, dataEntrada, horaEntrada));
             } while (!leitor.EndOfStream);
             leitor.Close();
        }
        public static void lerArquivoVeiculosSaida(List<Veiculo> listaSaida)
        {
            StreamReader leitor = new StreamReader(arquivoSaida);
            String linha;
            String[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");

                string placaVeiculo = vetorDados[0];
                DateTime dataEntrada = DateTime.Parse(vetorDados[1]);
                DateTime horaEntrada = DateTime.Parse(vetorDados[2]);              
                int tempoPermanencia = int.Parse(vetorDados[3]);
                double valorCobrado = double.Parse(vetorDados[4]);

                Veiculo veiculo = new Veiculo(placaVeiculo, dataEntrada, horaEntrada);
                veiculo.TempoPermanencia = tempoPermanencia;
                veiculo.ValorCobrado = valorCobrado;
                listaSaida.Add(veiculo);
            } while (!leitor.EndOfStream);
            leitor.Close();          
        }
        public static void gravarArquivoVeiculosEntrada(List<Veiculo> listaEntrada)
        {   
             StreamWriter escritor = new StreamWriter(arquivoEntrada, true);
             foreach (var item in listaEntrada)
             {
                 escritor.WriteLine($"{item.PlacaVeiculo};{item.DataEntrada:dd/MM/yyyy};{item.HoraEntrada:HH:mm}");
             }
             escritor.Close();
        }
        public static void gravarArquivoVeiculosSaida(List<Veiculo> listaSaida)
        {
            StreamWriter escritor = new StreamWriter(arquivoSaida, true);
             foreach (var item in listaSaida)
             {
                 escritor.WriteLine($"{item.PlacaVeiculo};{item.DataEntrada:dd/MM/yyyy};{item.HoraEntrada:HH:mm};" +
                     $"{item.TempoPermanencia};{item.ValorCobrado}");
             }
             escritor.Close();
        }
    }
}
