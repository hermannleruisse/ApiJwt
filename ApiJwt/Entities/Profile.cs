using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiJwt.Entities
{
    public class Profile
    {
        public string Code { get; set; }
        public string Libelle { get; set; }

        public Profile(string code, string libelle)
        {
            Code = code;
            Libelle = libelle;
        }
    }
}
