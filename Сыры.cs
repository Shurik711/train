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
    
    public partial class Сыры
    {
        public int id { get; set; }
        public string Дата { get; set; }
        public string Пармезан { get; set; }
        public string Российский { get; set; }
        public string Гауда { get; set; }
    
        public virtual Молоко_и_сливки Молоко_и_сливки { get; set; }
    }
}
