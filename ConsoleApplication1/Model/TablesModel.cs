//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablesModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesModel()
        {
            this.newEquipments = new HashSet<newEquipment>();
            this.TablesSNPrefixes = new HashSet<TablesSNPrefix>();
        }
    
        public int intModelID { get; set; }
        public string strName { get; set; }
        public Nullable<int> intManufacturerID { get; set; }
        public Nullable<int> intSMCSFamilyID { get; set; }
        public string strImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipments { get; set; }
        public virtual TablesManufacturer TablesManufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSNPrefix> TablesSNPrefixes { get; set; }
    }
}