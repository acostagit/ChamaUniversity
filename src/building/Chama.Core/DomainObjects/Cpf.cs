using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.DomainObjects
{
    public class Cpf
    {
        public const int CpfMaxLenght = 11;
        public string Numero { get; set; }

        //Codigo de Validacao aqui...

        public Cpf(string numero)
        {
            if (!Validar(numero)) throw new DomainException("CPF Inválido");
            Numero = numero;
        }
        public static bool Validar(string cpf)
        {
            //TODO

            return true;
        }
    }
}
