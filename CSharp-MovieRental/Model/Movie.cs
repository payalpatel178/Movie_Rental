using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MovieRental
{
    public class Movie
    {
        private readonly ObservableListSource<BorrowHistory> borrowHistory = new ObservableListSource<BorrowHistory>();
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public decimal Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Synopsis { get; set; }
        public string ImageURL { get; set; }
        public int GenreId { get; set; } // we have a var with this name in Genre class
        public virtual Genre Genre { get; set; }
        public virtual ObservableListSource<BorrowHistory> BorrowHistory { get { return borrowHistory; } }
        //validation
        public bool IsValid()
        {
            return (this.Validate().Count() == 0);
        }

        public IEnumerable<string> Validate()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                yield return "Movie name is Mandatory.";
            }
            if (string.IsNullOrEmpty(this.Director))
            {
                yield return "Director's name is Mandatory.";
            }
            if (this.Rating > 10)
            {
                yield return "Rating must be between 0-10.";
            }
            if (this.Rating <= 0)
            {
                yield return "Rating must be between 0-10.";
            }
            if (this.Year > 3000)
            {
                yield return "Year is invalid.";
            }
            if (this.Year < 1800)
            {
                yield return "Year is less than 1800.";
            }
            if (string.IsNullOrEmpty(this.Synopsis))
            {
                yield return "Synopsis is Mandatory.";
            }

            /*
            if (!int.TryParse(Year, out int rrYear))
            {
                yield return "Year is Invalid";
            }
            if (Rating.GetType() != typeof(decimal))
            {
                yield return "Rating is Invalid";
            }
            if (Duration.GetType() != typeof(int))
            {
                yield return "Duration is Invalid";
            }
            */

        }
    }
}
