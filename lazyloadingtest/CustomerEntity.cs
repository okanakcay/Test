//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lazyloadingtest
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerEntity
    {
        public CustomerEntity()
        {
            this.Connection = new HashSet<ConnectionEntity>();
            this.User = new HashSet<UserEntity>();
        }
    
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Address { get; set; }
    
        public virtual CityEntity City { get; set; }
        public virtual ICollection<ConnectionEntity> Connection { get; set; }
        public virtual ICollection<UserEntity> User { get; set; }
    }
}
