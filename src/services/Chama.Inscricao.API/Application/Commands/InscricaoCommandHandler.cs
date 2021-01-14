using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Application.Commands
{
    public class InscricaoCommandHandler: RegistrarInscricaoCommand
    {
        public bool Handle(RegistrarInscricaoCommand message)
        {
            if (!message.Registrado) return false;

            return true;
        }
    }
    
   
}
