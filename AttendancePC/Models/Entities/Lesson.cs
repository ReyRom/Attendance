//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendancePC.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson()
        {
            this.LessonAttends = new HashSet<LessonAttend>();
        }
    
        public int IdLesson { get; set; }
        public int IdDay { get; set; }
        public int IdSubject { get; set; }
        public byte OrderNumber { get; set; }
    
        public virtual Day Day { get; set; }
        public virtual Subject Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonAttend> LessonAttends { get; set; }
    }
}
