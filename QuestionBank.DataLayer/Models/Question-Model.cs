using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Models
{
    [Table("Questions")]
    public class Question_Model
    {
        [Key]
        public int QuestionId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Question { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        [Required]
        public QuestionType_Model QuestionType { get; set; }
        
        public int DifficultyId { get; set; }
        [ForeignKey("DifficultyId")]
        [Required]
        public QuestionDifficulty_Model QuestionDifficulty { get; set; }


        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        [Required]
        public Lessons_Model Lesson { get; set; }

        public virtual ICollection<QuestionOptions> QuestionOptions { get; set; }
    }
}
