//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace childrens_hospitall.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public int id_patient { get; set; }
        public string sname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public Nullable<System.DateTime> hp { get; set; }
        public Nullable<int> age { get; set; }
        public string diagnosis { get; set; }
        public Nullable<int> id_branches { get; set; }
        public Nullable<int> id_ward { get; set; }
        public Nullable<int> id_staff { get; set; }
    
        public virtual Branches Branches { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Ward Ward { get; set; }
    }
}