using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Models
{
    [Table("QuestionTypes")]
    public class QuestionType_Model
    {
        [Key]
        [Required]
        public int TypeId { get; set; }
        [Required]
        public string Type { get; set; }

        public virtual ICollection<Question_Model> Questions { get; set; }
    }
}
