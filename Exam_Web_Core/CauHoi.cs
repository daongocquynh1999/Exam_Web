//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam_Web_Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class CauHoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauHoi()
        {
            this.DapAnDaLuaChons = new HashSet<DapAnDaLuaChon>();
            this.DeThis = new HashSet<DeThi>();
        }
    
        public int CauHoiID { get; set; }
        public string NoiDungCauHoi { get; set; }
        public string Answer_A { get; set; }
        public string Answer_B { get; set; }
        public string Answer_C { get; set; }
        public string Answer_D { get; set; }
        public string CauTraLoiDung { get; set; }
        public Nullable<int> DoKhoID { get; set; }
        public Nullable<int> MonHocID { get; set; }
    
        public virtual DoKho DoKho { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DapAnDaLuaChon> DapAnDaLuaChons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeThi> DeThis { get; set; }
    }
}
