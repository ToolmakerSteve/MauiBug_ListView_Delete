namespace MauiApp3
{
    public class TodoItem
    {
        public TodoItem(string todoText, bool complete)
        {
            TodoText = todoText;
            Complete = complete;
        }

        public bool Complete { get; set; }
        public string TodoText { get; }
    }
}