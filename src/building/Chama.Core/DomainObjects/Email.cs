using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.DomainObjects
{   public class Email
    {
        public string Endereco { get; set; }

        //para EF 
        protected Email() { }
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public static bool Validar(string email)
        {
            if (email.Length == 0) return false;

            return true;
        }
    }
}
