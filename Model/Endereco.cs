using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labassincnetcore.Model
{
    public class Endereco
    {
        private string IdCep { get; set; }

        private string Cogradouro { get; set; }
        private string Complemento { get; set; }
        private string Bairro { get; set; }
        private string Localidade { get; set; }
        private string Uf { get; set; }
        private string Unidade { get; set; }
        private string Ibge { get; set; }
        private string Gia { get; set; }
    }
}
