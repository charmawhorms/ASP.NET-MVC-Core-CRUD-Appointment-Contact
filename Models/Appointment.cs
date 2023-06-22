using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentContact.Models
{
    public class Appointment
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required.")]        
        public string first_nm { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string last_nm { get; set;}

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "This field is required")]
        public DateTime dob { get; set; }

        [Column(TypeName = "varchar(320)")]
        [DisplayName("Email Address")]
        [Required(ErrorMessage = "This field is required")]
        public string email_addr { get; set; }

        [Column(TypeName = "varchar(13)")]
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(13, ErrorMessage = "Maximum 13 characters only.")]
        public string phone_nbr { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Address")]
        [Required(ErrorMessage = "This field is required")]
        public string address { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("City")]
        [Required(ErrorMessage = "This field is required")]
        public string city { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Parish")]
        [Required(ErrorMessage = "This field is required")]
        public string parish { get; set; }
    }
}
