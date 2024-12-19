
namespace Konu12KalitimInheritance
{
    internal class OrtakOzellikler : OrtakMetotlar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } // ? = boş geçilebilir
        public  DateTime  CreateDate{ get; set; } //Tarih ekleme
        public  DateTime  UpdateDate { get; set; } // tarih güncelleme
        public bool IsActive { get; set; }





    }
}
