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
    
    public partial class tblCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCliente()
        {
            this.tblChamado = new HashSet<tblChamado>();
        }
    
        public int Id { get; set; }
        public string RedeNome { get; set; }
        public string Nome { get; set; }
        public string Prioridade { get; set; }
        public string Carteira { get; set; }
        public Nullable<int> IdRede { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChamado> tblChamado { get; set; }
        public virtual tblRedeCliente tblRedeCliente { get; set; }
    }
}
