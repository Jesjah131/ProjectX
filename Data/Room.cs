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
    
    public partial class Room
    {
        public Room()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int RID { get; set; }
        public string Room_Number { get; set; }
        public bool Room_Status { get; set; }
        public string FLOOR { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> HID { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
