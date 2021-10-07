using TodoList.ViewModels;
using Serilog;
using Serilog.Extensions.Logging;
using Microsoft.Extensions.Logging;

using MvvmCross.ViewModels;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace TodoList
{
    public class Setup : MvxWpfSetup<CoreApp>
    {
        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                // add more sinks here
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }
    }

    public class CoreApp : MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<TodoListViewModel>();
        }
    }

}
