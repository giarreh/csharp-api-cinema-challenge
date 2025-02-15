﻿using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

        public List<ScreeningDTO>? Screenings { get; set; }
    }
}
