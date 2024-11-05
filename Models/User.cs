using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;
using Supabase;

namespace uploadPDFBooK.Models
{
    [Table("users")]
    public class User : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; } // تأكد من تطابق نوع Id مع قاعدة البيانات

        [Column("user")]
        public string Username { get; set; } = string.Empty; // حقل اسم المستخدم، مع قيمة افتراضية لتجنب الأخطاء

        [Column("password")]
        public string Password { get; set; } = string.Empty; // حقل كلمة المرور، مع قيمة افتراضية لتجنب الأخطاء
    }
}
