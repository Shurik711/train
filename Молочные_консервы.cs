//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Молочные_консервы
    {
        public int id { get; set; }
        public string Дата { get; set; }
        public string Молоко_сгущенное { get; set; }
        public string Молоко_концентрированное_2_5 { get; set; }
    
        public virtual Молоко_и_сливки Молоко_и_сливки { get; set; }
    }
}
