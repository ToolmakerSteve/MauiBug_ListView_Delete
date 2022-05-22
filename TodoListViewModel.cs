using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp3
{
    public class TodoListViewModel : BindableObject
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>
            {
                //test
                new TodoItem("todo 1", false),
                new TodoItem("todo 2", true),
                new TodoItem("todo 3", true),
            };
        }

        string newTodoText = string.Empty;
        public string NewTodoText
        {
            get { return newTodoText; }
            set
            {
                if (value == newTodoText) return;
                newTodoText = value;
                OnPropertyChanged();
            }

        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoText, false));

            //clear entry and refocus
            NewTodoText = string.Empty;
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(Object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}

