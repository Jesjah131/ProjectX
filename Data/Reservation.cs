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
    
    public partial class Reservation
    {
        public Reservation()
        {
            this.Rooms = new HashSet<Room>();
        }
    
        public int REID { get; set; }
        public string Total_Sum { get; set; }
        public System.DateTime Check_In { get; set; }
        public System.DateTime Check_Out { get; set; }
        public Nullable<int> UID { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
