using System;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewsApp.Models
{
	public class Review
	{
        [Key]
		public int Id { get; set; }

        [Required]
		public string MovieName { get; set; }

        [Required]
		public string Message { get; set; }

        public Review()
        {
        }

        public Review(int id, string movieName, string message)
        {
            Id = id;
            MovieName = movieName;
            Message = message;
        }
    }
}

