//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelAdmin
    {
        public HotelAdmin()
        {
            this.Hotels = new HashSet<Hotel>();
        }
    
        public int HAID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string SSN { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
    
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
