﻿using System.Collections.Generic;

namespace Chinook.Data.DataModels
{
    public sealed class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }

        public ICollection<PlaylistTrack> PlaylistTracks { get; set; } = new HashSet<PlaylistTrack>();
    }
}
