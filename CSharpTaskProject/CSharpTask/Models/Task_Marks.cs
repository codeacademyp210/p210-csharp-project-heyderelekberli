//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task_Marks
    {
        public int İd { get; set; }
        public int StudentİD { get; set; }
        public int TaskİD { get; set; }
        public int Mark { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Task Task { get; set; }
    }
}