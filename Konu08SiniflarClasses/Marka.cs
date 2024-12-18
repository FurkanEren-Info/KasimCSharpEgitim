using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08SiniflarClasses
{
    internal class Marka
    {
        public Marka() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; } =
            DateTime.Now;//Bir property e bu şekilde başlangıç değeri atayıp eğer veri gönderilmemişse bu değeri kulanmasını sağlayabiliriz.
        public static string StatikOzellik = "static işaretli özelliği clasadi.ozellikadi şeklinde direl çağırabiliriz. Statik olmayanlar ise dinamiktir";
           
    }
}
