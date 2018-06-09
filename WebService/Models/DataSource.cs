//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSource()
        {
            this.BaseInfo = new HashSet<BaseInfo>();
        }
    
        public int sourceId { get; set; }
        public string sourceName { get; set; }
        public int sourceTypeId { get; set; }
        public string sourceHost { get; set; }
        public string sourceUsername { get; set; }
        public string sourcePassword { get; set; }
        public string isProtect { get; set; }
        public string sourceConnection { get; set; }
        public string sourceOther { get; set; }
        public string databaseName { get; set; }
        public int State { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseInfo> BaseInfo { get; set; }
        public virtual SourceType SourceType { get; set; }
    }
}
