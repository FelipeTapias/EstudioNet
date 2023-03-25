using PruebasNet.Models;

namespace PruebasNet.Clases
{
    public class Linq
    {
        public Action<string, string> print = (prop, prop2) => Console.WriteLine($"{prop} - {prop2}");
        public Action<string, string, int> printMulti = (prop, prop2, prop3) => Console.WriteLine($"{prop} - {prop2} - {prop3}");

        public List<Composer> composers = new List<Composer>()
        {
            new Composer() { Id = 1, Name = "Serguéi Prokófiev", Song = "Dance of the Knights", Origin = "Soviético" },
            new Composer() { Id = 3, Name = "Gioacchino Rossini", Song = "El barbero de sevilla", Origin = "Italy" },
            new Composer() { Id = 2, Name = "Guiseppe Tartini", Song = "Devil's trill Sonata", Origin = "Italy" },
            new Composer() { Id = 4, Name = "Antonio Vivaldi", Song = "Four Seasons", Origin = "Venice" }
        };

        public List<Song> songs = new List<Song>()
        {
            new Song() { Id = 1, Name = "Dance of the Knights", PublicationYear = 1935 },
            new Song() { Id = 2, Name = "El barbero de sevilla", PublicationYear = 1815 },
            new Song() { Id = 3, Name = "Devil's trill Sonata", PublicationYear = 1713 },
            new Song() { Id = 4, Name = "Four Seasons", PublicationYear = 1725 }
        };
        
        // SELECT
        public void GetNames()
        {
            var composerInfo = from compose in composers
                                        select new { compose.Name, compose.Origin };

            foreach(var info in composerInfo)
                print(info.Name, info.Origin);
            
        }

        // WHERE
        public void GetOrigin()
        {
            var composerOrigin = from compose in composers
                                 where compose.Origin == "Italy" || (compose.Id % 2) == 0
                                 select new { compose.Name ,compose.Origin };

            foreach (var compose in composerOrigin)
                print(compose.Name, compose.Origin);

            
        }

        // WHERE
        public void GetSong(string song)
        {
            var composer = composers.Where(composer => composer.Song == song)
                .Select(composer => new
                {
                    composer.Name,
                    composer.Origin
                });
            foreach(var compose in composer)
                print(compose.Name, compose.Origin);
        }

        // ORDER BY
        public void getPairsId()
        {
            var composerOrigin = from compose in composers
                                 where (compose.Id % 2) == 0
                                 orderby compose.Name descending
                                 select new { compose.Name, compose.Origin };

            foreach (var compose in composerOrigin)
                print(compose.Name, compose.Origin);

        }

        // GROUP BY
        public void totalOrigins()
        {
            var origins = from compose in composers
                          group compose by compose.Origin into groupComposers
                          select new
                          {
                              Origin = groupComposers.Key,
                              Count = groupComposers.Count()
                          };
            foreach (var origin in origins)
                print(origin.Origin, origin.Count.ToString());
        }

        // JOIN
        public void ComposerAndSong()
        {
            var composerSongs = from compose in composers
                               join song in songs on compose.Song equals song.Name
                               select new 
                               {
                                   Compose = compose.Name,
                                   Song = compose.Song,
                                   PublicationYear = song.PublicationYear
                               };
            foreach(var info in composerSongs)
                printMulti(info.Compose, info.Song, info.PublicationYear);
               

        }
    }
}
