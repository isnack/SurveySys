//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveySysDAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questionario
    {
        public Questionario()
        {
            this.PerguntaSet = new HashSet<Pergunta>();
        }
    
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<Pergunta> PerguntaSet { get; set; }
    }
}