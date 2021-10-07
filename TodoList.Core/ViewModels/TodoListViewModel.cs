using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Models;

namespace TodoList.Core.ViewModels
{
    public class TodoListViewModel : MvxViewModel
    {
        private ObservableCollection<Todo> _todos = new ObservableCollection<Todo>();

        public ObservableCollection<Todo> Todos
        {
            get { return _todos; }
            set { SetProperty(ref _todos, value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

    }
}
