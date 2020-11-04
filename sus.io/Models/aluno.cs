using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sus.io.Models
{
    public class aluno
    {
        public aluno()
        {
            id = Guid.NewGuid();
        }

        public Guid id { get; set; }


        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime dataNascimento { get; set; }





    }
}
