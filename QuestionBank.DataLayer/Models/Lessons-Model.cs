using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Models
{
    [Table("Lessons")]
    public class Lessons_Model
    {
        [Key]
        [Required]
        public int LessonId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Question_Model> Questions { get; set; }
    }
}
