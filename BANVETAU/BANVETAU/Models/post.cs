
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
    
public partial class post
{

    public int ID { get; set; }

    public Nullable<int> topid { get; set; }

    public string title { get; set; }

    public string slug { get; set; }

    public string detail { get; set; }

    public string img { get; set; }

    public string type { get; set; }

    public System.DateTime created_at { get; set; }

    public int created_by { get; set; }

    public System.DateTime updated_at { get; set; }

    public int updated_by { get; set; }

    public int status { get; set; }



    public virtual topic topic { get; set; }

}

}
