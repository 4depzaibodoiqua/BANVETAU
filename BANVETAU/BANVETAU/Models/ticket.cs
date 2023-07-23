
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BanVeMayBay.Models
{

using System;
    using System.Collections.Generic;
    
public partial class ticket
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ticket()
    {

        this.ordersdetails = new HashSet<ordersdetail>();

    }


    public int id { get; set; }

    public string name { get; set; }

    public string description { get; set; }

    public string flightCode { get; set; }

    public string airline { get; set; }

    public string ticketType { get; set; }

    public string img { get; set; }

    public Nullable<System.DateTime> departure_date { get; set; }

    public Nullable<int> guestTotal { get; set; }

    public Nullable<double> price { get; set; }

    public Nullable<double> priceSale { get; set; }

    public int Sold { get; set; }

    public System.DateTime created_at { get; set; }

    public int created_by { get; set; }

    public System.DateTime updated_at { get; set; }

    public int updated_by { get; set; }

    public int status { get; set; }

    public Nullable<System.TimeSpan> departure_time { get; set; }

    public Nullable<System.TimeSpan> arrival_time { get; set; }

    public Nullable<int> fromAirport { get; set; }

    public Nullable<int> toAirport { get; set; }



    public virtual city city { get; set; }

    public virtual city city1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ordersdetail> ordersdetails { get; set; }

}

}
