//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lazyfitness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class postInfo
    {
        public int areaId { get; set; }
        public int postId { get; set; }
        public string postTitle { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<System.DateTime> postTime { get; set; }
        public Nullable<int> pageView { get; set; }
        public Nullable<int> isPost { get; set; }
        public Nullable<int> isPay { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<int> postStatus { get; set; }
        public string postContent { get; set; }
    
        public virtual postArea postArea { get; set; }
    }
}
