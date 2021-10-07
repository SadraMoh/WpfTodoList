using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace TodoList.Views
{
    /// <summary>
    /// Interaction logic for TodoListView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(TodoListView))]
    public partial class TodoListView : MvxWpfView
    {
        public TodoListView()
        {
            InitializeComponent();
        }
    }
}
