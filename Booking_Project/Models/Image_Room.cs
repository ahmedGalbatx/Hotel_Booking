﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_Project.Models
{
    public class Image_Room
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        [Column(TypeName = "[] byte ")]
        public string ImageURL { get; set; }
        [MaxLength(1000)]
        public string Description { get; set;}
    }
}
