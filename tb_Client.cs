//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Database_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Client()
        {
            this.tb_Address = new HashSet<tb_Address>();
        }
    
        public int n_ClientNo { get; set; }
        public string s_ClientCode { get; set; }
        public string s_ClientName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Address> tb_Address { get; set; }
    }
}
