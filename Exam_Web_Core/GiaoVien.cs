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
    
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            this.DeThis = new HashSet<DeThi>();
        }
    
        public int GiaoVienID { get; set; }
        public Nullable<int> TaiKhoanID { get; set; }
        public string TenGV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string Email { get; set; }
        public Nullable<int> MonHocID { get; set; }
        public Nullable<int> HocViID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeThi> DeThis { get; set; }
        public virtual HocVi HocVi { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
