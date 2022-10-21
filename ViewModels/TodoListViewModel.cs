using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TutorialTodoListApp.Models;

namespace TutorialTodoListApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}
