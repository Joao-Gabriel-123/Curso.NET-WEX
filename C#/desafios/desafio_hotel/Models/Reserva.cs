namespace desafio_hotel.Models
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

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O número de hóspedes é maior que a capacidade!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }

            return valor;
        }
    }
}