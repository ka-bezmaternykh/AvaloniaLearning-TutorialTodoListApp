using ReactiveUI;
using System;
using System.Reactive;
using TutorialTodoListApp.Models;

namespace TutorialTodoListApp.ViewModels
{
    internal class AddItemViewModel : ViewModelBase
    {
        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(
                () => new TodoItem { Description = Description },
                okEnabled);

            Cancel = ReactiveCommand.Create(() => { });
        }

        string description;
        public string Description {
            get => description;
            set => this.RaiseAndSetIfChanged(ref description, value);
        }

        public ReactiveCommand<Unit, TodoItem> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}
