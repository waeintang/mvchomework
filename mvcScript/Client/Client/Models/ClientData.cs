//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientData()
        {
            this.ClientContact = new HashSet<ClientContact>();
            this.ClientInformation = new HashSet<ClientInformation>();
        }
    
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string EINNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ContactAddress { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientContact> ClientContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientInformation> ClientInformation { get; set; }
    }
}
