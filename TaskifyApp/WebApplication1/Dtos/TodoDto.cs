﻿namespace TaskifyAPI.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int Status { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }

    }
}
