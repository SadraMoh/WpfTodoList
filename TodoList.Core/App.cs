using MvvmCross;
using MvvmCross.ViewModels;
using TodoList.Core.ViewModels;

namespace TodoList.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<TodoListViewModel>();
        }
    }
}
