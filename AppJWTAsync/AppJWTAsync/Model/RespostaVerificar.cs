using System;
using System.Collections.Generic;
using System.Text;

namespace AppJWTAsync.Model
{
    public class RespostaVerificar
    {
        public string JWT { get; set; }
        public Usuario usuario { get; set; }
    }
}
