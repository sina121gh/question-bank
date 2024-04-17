using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Models
{
    [Table("Difficulties")]
    public class QuestionDifficulty_Model
    {
        [Key]
        [Required]
        public int DifficultyId { get; set; }
        [Required]
        [MaxLength(10)]
        public string Difficulty { get; set; }

        public virtual ICollection<Question_Model> Questions { get; set; }
    }
}
