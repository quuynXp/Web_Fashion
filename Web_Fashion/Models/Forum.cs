using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluent.Infrastructure.FluentModel;

namespace Web_Fashion.Models
{
    [Table("ForumForms")] // Tên bảng trong cơ sở dữ liệu
    public class Forum : BaseEntityClass
    {
        [Key] // Đánh dấu đây là khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
        public int Id { get; set; }

        [StringLength(255)] // Giới hạn độ dài chuỗi
        [Required] // Thuộc tính bắt buộc
        public string Description { get; set; }

        [Required]
        public DateTime UpdateDate { get; set; }
    }

    [Table("ForumForms")]
    public class ForumForm : BaseEntityClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }
    }
}
