﻿
namespace API.DTOs
{
    public class VolumeDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public byte[] CoverImage { get; set; }
        public int Pages { get; set; }
        public int PagesRead { get; set; }
    }
}