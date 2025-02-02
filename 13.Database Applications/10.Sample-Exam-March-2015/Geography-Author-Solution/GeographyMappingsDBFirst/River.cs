//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeographyMappingsDBFirst
{
    using System;
    using System.Collections.Generic;

    public partial class River
    {
        public River()
        {
            this.Countries = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string RiverName { get; set; }
        public int Length { get; set; }
        public Nullable<int> DrainageArea { get; set; }
        public Nullable<int> AverageDischarge { get; set; }
        public string Outflow { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
