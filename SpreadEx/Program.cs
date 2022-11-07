// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpreadEx.Factories;
using SpreadEx.Service;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((cxt, services) =>
    {
        services.AddWidgetFactory();
        services.AddSingleton<IDrawWidget, DrawWidget>();
    })
    .Build();

var drawingService = ActivatorUtilities.CreateInstance<DrawWidget>(host.Services);

drawingService.DrawRectangle(10, 10, 30, 40);
drawingService.DrawSquare(15, 30, 35);
drawingService.DrawEllipse(100, 150, 300, 200);
drawingService.DrawCircle(1, 1, 300);
drawingService.DrawTextbox(5, 5, 200, 100, "sample text");

drawingService.PrintWidgets();

// new service to clear state
drawingService = ActivatorUtilities.CreateInstance<DrawWidget>(host.Services);

drawingService.PrintWidgets();
