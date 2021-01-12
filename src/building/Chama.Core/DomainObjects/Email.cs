using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.DomainObjects
{
    //TODO
    public class Email
    {
        public string Endereco { get; set; }

        //EF 
        protected Email() { }
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public static bool Validar(string email)
        {
            //TODO

            return true;
        }


    }
}
