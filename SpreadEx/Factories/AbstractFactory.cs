using Microsoft.Extensions.DependencyInjection;
using SpreadEx.Model;

namespace SpreadEx.Factories
{
    public static class AbstractFactory
    {
        public static void AddWidgetFactory(this IServiceCollection services)
        {
            services.AddTransient<IWidget, Rectangle>();
            services.AddTransient<IWidget, Square>();
            services.AddTransient<IWidget, Ellipse>();
            services.AddTransient<IWidget, Circle>();
            services.AddTransient<IWidget, TextBox>();
            services.AddSingleton<Func<IEnumerable<IWidget>>>
                (x => () => x.GetService<IEnumerable<IWidget>>()!);
            services.AddSingleton<IWidgetFactory, WidgetFactory>();
        }
    }
}
