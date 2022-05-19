namespace TodolistApp.Model
{
    public class Todo
    {
      public int id   { get; set; }
        public string? content { get; set; }
        public bool isDone { get; set; } = false;
    }
}
