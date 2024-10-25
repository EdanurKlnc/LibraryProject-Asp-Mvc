using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Kitabın Adı")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Kitabın Yazarı")]
        public string Author { get; set; }

        [Required]
        [DisplayName("Yayın Tarihi")]
        public DateTime PublicationDate { get; set; }

        [Required]
        [DisplayName("Sayfa Sayısı")]
        
        public int PageCount { get; set; }
    }
}
