using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Models
{
    [Table("QuestionOptions")]
    public class QuestionOptions
    {
        [Key]
        [Required]
        public int OptionId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Option { get; set; }

        [Required]
        public int OptionNumber {  get; set; }

        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        [Required]
        public Question_Model Question { get; set; }
    }
}
