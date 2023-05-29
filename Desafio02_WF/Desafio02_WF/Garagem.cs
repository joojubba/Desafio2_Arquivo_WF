using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_WF
{
    public class Garagem
    {
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();
        const int vagas = 50;
        const double valorHora = 5.0;
        public List<Veiculo> ListaEntrada
        {
            get { return listaEntrada; }
        }
        public List<Veiculo> ListaSaida
        {
            get { return listaSaida; }
        }
        public bool horarioGaragem(DateTime horario)
        {
            return horario.Hour >= 7 && horario.Hour < 20;
        }
        public bool temLugar()
        {
            return listaEntrada.Count < vagas;
        }
        public bool jaCadastrado(string placaVeiculo)
        {
            foreach (Veiculo veiculo in listaEntrada)
            {
                if (placaVeiculo.Equals(veiculo.PlacaVeiculo))
                {
                    return true;
                }
            }
            return false;
        }
        public void EntradaVeiculo(Veiculo veiculo, DateTime horaEntrada)
        {
            if (horarioGaragem(horaEntrada) && temLugar() && !jaCadastrado(veiculo.PlacaVeiculo))
            {
                veiculo.DataEntrada = horaEntrada.Date;
                veiculo.HoraEntrada = horaEntrada;
                listaEntrada.Add(veiculo);
            }
        }
        public void SaidaVeiculo(Veiculo veiculo, DateTime horaSaida)
        {
            if (horarioGaragem(horaSaida) && listaEntrada.Contains(veiculo))
            {
                TimeSpan tempoPermanencia = horaSaida - veiculo.HoraEntrada;
                int minutos = (int)tempoPermanencia.TotalMinutes;
                veiculo.TempoPermanencia = minutos;
                veiculo.ValorCobrado = Math.Ceiling(veiculo.TempoPermanencia / 60.0) * valorHora;
                listaEntrada.Remove(veiculo);
                listaSaida.Add(veiculo);
            }
        }
    }
}
