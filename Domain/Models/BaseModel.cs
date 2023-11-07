﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
