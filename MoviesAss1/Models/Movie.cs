using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesAss1.Models
{
    public enum Country
    {
        USA,
        England,
        Egypt,
        France,
        Italy
    }

    public class Movie
    {
        public int id { set; get; }
        [Required]
        [Display(Name = "Movie Title")]
        public string name { set; get; }
        [Display(Name = "Main Actor")]
        public string mainActor { set; get; }
        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime releaseDate { set; get; }
        [Display(Name = "Website")]
        public string website { set; get; }
        [Display(Name = "Country")]
        public Country countryId { set; get; }

        //Constructors
        Movie(int _id, string _name, string _mainActor, DateTime _releaseDate, string _website, Country _countryId)
        {
            id = _id;
            name = _name;
            mainActor = _mainActor;
            releaseDate = _releaseDate;
            website = _website;
            countryId = _countryId;
        }

        public Movie()
        {
            id = idCounter++;
        }


        //Add movie
        public static void AddMovie (Movie newMovie)
        {
            MovieList.Add(newMovie);
        }

        // Test Data
        static Movie Sharknado = new Movie(0, "Sharknado", "Tara Reid", new DateTime(2013, 11, 7), "https://www.rottentomatoes.com/m/sharknado_2013", 0);
        static Movie Sharknado2 = new Movie(0, "Sharknado 2: The Second One", "Tara Reid", new DateTime(2014, 10, 7), "https://www.rottentomatoes.com/m/sharknado_2_the_second_one", 0);
        public static List<Movie> MovieList = new List<Movie>() { Sharknado, Sharknado2 };
        static public int idCounter = 2;



    }

}
