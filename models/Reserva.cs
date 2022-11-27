using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite _suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes){
            
            
            if (hospedes.Count <= _suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("ocorreu uma exceção");
            }

        }
        public void CadastrarSuite(Suite suite)
        {
            this._suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = 0;
             quantidadeHospedes += Hospedes.Count;
            return quantidadeHospedes;
            
        }
        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = 0;
            valorDiaria= _suite.ValorDiaria*DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados>=10)
            {
                valorDiaria -=  valorDiaria* 0.10M;
            }

            return valorDiaria;
    }
}
}