using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int AvailableItem { get; set; }
        public int PendingPerson { get; set; }

        public List<VideoGame> VideoGemes { get; set; }

        public VideoGame()
        {
            VideoGemes = new List<VideoGame>
            {
                new VideoGame{Id = 1, Name = "Mostofa", Author = "John", AvailableItem = 2, PendingPerson=0 },
                new VideoGame{Id = 2, Name = "Double Dragon", Author = "John", AvailableItem = 2, PendingPerson=0 },
                new VideoGame{Id = 3, Name = "Mini Milisia", Author = "John", AvailableItem = 2, PendingPerson=0 },
                new VideoGame{Id = 4, Name = "Free Fire", Author = "John", AvailableItem = 2, PendingPerson=0 },
                new VideoGame{Id = 5, Name = "PUBG", Author = "John", AvailableItem = 2, PendingPerson=0 },
            };
        }

        public void AddGame(VideoGame game)
        {
            var id = VideoGemes.Count + 1;
            game.Id = id;

            VideoGemes.Add(game);
        }
    }
}
