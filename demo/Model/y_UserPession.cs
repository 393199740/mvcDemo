//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class y_UserPession
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string PerssionCode { get; set; }
    
        public virtual y_Users y_Users { get; set; }
    }
}
