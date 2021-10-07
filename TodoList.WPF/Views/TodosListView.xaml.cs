using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using TodoList.Core.ViewModels;

namespace TodoList.WPF.Views
{
    /// <summary>
    /// Interaction logic for TodosListView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(TodoListViewModel))]
    public partial class TodosListView : MvxWpfView
    {
        public TodosListView()
        {
            InitializeComponent();
        }
    }
}
