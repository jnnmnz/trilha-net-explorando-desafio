using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes, int capacidadeSuite)
        {
            if (hospedes.Count<=capacidadeSuite)
                Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(decimal valorDiaria)
        {
            decimal valor = DiasReservados*valorDiaria;

            if (DiasReservados>=10)
            {
                Decimal desconto = 0.10m;
                Decimal valorDesconto = Decimal.Multiply(valor, desconto);
                valor = valor - valorDesconto;
            }

            return valor;
        }
    }
}