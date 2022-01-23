using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStudy.Model
{
    public class MoviesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Director { get; set; }

        public DateTime PublishTime { get; set; }

        public List<string> Actors { get; set; }

        public int CountryId { get; set; }

        public bool IsWatched { get; set; } 
    }
}
