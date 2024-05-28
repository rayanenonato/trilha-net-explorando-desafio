namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public int Capacidade { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Capacidade)
          {  
             Hospedes = hospedes;
              Console.WriteLine("A capacidade é suficiente para os hóspedes.");
           } 
        
            else
            {
                Console.WriteLine("A capacidade não é suficiente para os hóspedes");
                 throw new InvalidOperationException("A capacidade não é suficiente para os hóspedes.");

                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            Capacidade = suite.Capacidade;
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
                decimal desconto = valor * 0.10m;
                valor -= desconto;
                Console.WriteLine($"Desconto aplicado: {desconto:C}");
            }

            return valor;
        }
    }
}