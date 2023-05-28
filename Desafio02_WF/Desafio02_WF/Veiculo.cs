using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_WF
{
    public class Veiculo
    {
        string placaVeiculo;
        DateTime dataEntrada;
        DateTime horaEntrada;
        DateTime dataSaida;
        DateTime horaSaida;
        int tempoPermanencia;
        double valorCobrado;

        public Veiculo(string placaVeiculo, DateTime dataEntrada, DateTime horaEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
        }

        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

    }
}
