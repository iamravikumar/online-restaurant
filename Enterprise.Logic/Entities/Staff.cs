//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;


namespace Enterprise.Logic.Entities
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class Staff: Entity
    {
        
    	[DataMember]
        public string UserName { get; set; }
    	[DataMember]
        public string Email { get; set; }
    	[DataMember]
        public string PasswordHash { get; set; }
    	[DataMember]
        public string ContactTelephone { get; set; }
    	[DataMember]
        public string PostalCode { get; set; }
    	[DataMember]
        public string State { get; set; }
    	[DataMember]
        public string StreetAddress { get; set; }
    	[DataMember]
        public string City { get; set; }
    }
}
