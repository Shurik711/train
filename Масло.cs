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
    
    public partial class Масло
    {
        public int id { get; set; }
        public string Дата { get; set; }
        public string Масло_72_5 { get; set; }
        public string Масло_82_5 { get; set; }
    
        public virtual Молоко_и_сливки Молоко_и_сливки { get; set; }
    }
}
