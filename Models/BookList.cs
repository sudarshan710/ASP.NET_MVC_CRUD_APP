using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ASP.NET_MVC_CRUD_APP.Models
{
    public class BookList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        [DisplayName("Published Year")]
		public DateTime PublisedYear { get; set; } = DateTime.Now;

    }
}
