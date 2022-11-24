using System.Collections.Generic;

namespace MovieDataStorageCourseProject
{
    public struct FilmFilter
    {
        private List<string> genres;
        private List<string> countries;

        public string NamePart { get; set; }
        public int DurationFrom { get; set; }
        public int DurationTo { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }

        public static FilmFilter Empty => new FilmFilter();

        public FilmFilter(string namePart = "", int durationFrom = 1, int durationTo = 600, int yearFrom = 1900, int yearTo = 2030)
        {
            genres = new List<string>();
            countries = new List<string>();

            NamePart = namePart;
            DurationFrom = durationFrom;
            DurationTo = durationTo;
            YearFrom = yearFrom;
            YearTo = yearTo;
        }

        public void AddGenre(string genre) => genres.Add(genre);
        public void ClearGenres() => genres.Clear();
        public void AddCountry(string country) => countries.Add(country);
        public void ClearCountries() => countries.Clear();
    }
}
