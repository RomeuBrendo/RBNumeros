//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblChamado
    {
        public int Id { get; set; }
        public System.DateTime DataAbertura { get; set; }
        public Nullable<System.DateTime> DataFechamento { get; set; }
        public int IdCliente { get; set; }
        public string NomeTecnico { get; set; }
        public string NomeCliente { get; set; }
        public string Carteira { get; set; }
        public int IdAbertoPor { get; set; }
        public string TipoChamado { get; set; }
        public string Modulo { get; set; }
        public string Assunto { get; set; }
        public string Titulo { get; set; }
    
        public virtual tblCliente tblCliente { get; set; }
        public virtual tblTecnico tblTecnico { get; set; }
    }
}
