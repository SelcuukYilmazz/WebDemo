using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class ResultModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuizId { get; set; }

        public String Name { get; set; }

        public int Grade { get; set; }

        public ResultModel(int UserId, int QuizId, String Name, int Grade)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.QuizId = QuizId;
            this.Name = Name;
            this.Grade = Grade;

        }

    }
}
