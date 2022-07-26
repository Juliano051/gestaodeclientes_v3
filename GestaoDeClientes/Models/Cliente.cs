using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeClientes.Models
{
    public class Cliente
    {
        /*public Cliente()
        {
            this.Midias = new HashSet<Midia>
        }*/
        public int ClienteId { get; set; }
        public int ClientePerfil { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteEmpresa { get; set; }
        public string ClienteNomeFantasia { get; set; }
        public string ClienteCpfCnpj { get; set; }
        public string ClienteTelefone { get; set; }
        public string ClienteCelular { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteRua { get; set; }
        public string ClienteNumero { get; set; }
        public string ClienteCep { get; set; }
        public string ClienteCidade { get; set; }
        public string ClienteEstado { get; set; }
        public string ClienteEndComplem { get; set; }

    }
}
