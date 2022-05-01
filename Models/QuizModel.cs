using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class QuizModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " Please Enter Title")]
        public String Title { get; set; }
        [Required(ErrorMessage = " Please Enter Text")]
        public String Text { get; set; }

        [Required(ErrorMessage = " Please Enter Question1")]
        public String Question1 { get; set; }

        [Required(ErrorMessage = " Please Enter Choice1_1")]
        public String Choice1_1 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice1_2")]
        public String Choice1_2 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice1_3")]
        public String Choice1_3 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice1_4")]
        public String Choice1_4 { get; set; }

        [Required(ErrorMessage = " Please Enter Question2")]
        public String Question2 { get; set; }

        [Required(ErrorMessage = " Please Enter Choice2_1")]
        public String Choice2_1 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice2_2")]
        public String Choice2_2 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice2_3")]
        public String Choice2_3 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice2_4")]
        public String Choice2_4 { get; set; }

        [Required(ErrorMessage = " Please Enter Question3")]
        public String Question3 { get; set; }

        [Required(ErrorMessage = " Please Enter Choice3_1")]
        public String Choice3_1 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice3_2")]
        public String Choice3_2 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice3_3")]
        public String Choice3_3 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice3_4")]
        public String Choice3_4 { get; set; }

        [Required(ErrorMessage = " Please Enter Question4")]
        public String Question4 { get; set; }

        [Required(ErrorMessage = " Please Enter Choice4_1")]
        public String Choice4_1 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice4_2")]
        public String Choice4_2 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice4_3")]
        public String Choice4_3 { get; set; }
        [Required(ErrorMessage = " Please Enter Choice4_4")]
        public String Choice4_4 { get; set; }

        [Required(ErrorMessage = " Please Enter Answer1")]
        public String Answer1 { get; set; }

        [Required(ErrorMessage = " Please Enter Answer2")]
        public String Answer2 { get; set; }

        [Required(ErrorMessage = " Please Enter Answer3")]
        public String Answer3 { get; set; }

        [Required(ErrorMessage = " Please Enter Answer4")]
        public String Answer4 { get; set; }

        public String Date { get; set; }

        public bool Completed { get; set; }
    }
}
