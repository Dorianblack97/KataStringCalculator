using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataStringCalculator.IOC
{
    public class Container
    {
        public static T GetService<T>() => CreateHostBuilder().Services.GetService<T>();

        private static IHost CreateHostBuilder() =>
            Host
            .CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
                services
                    .AddSingleton<ICalculator, Calculator>()
                    .AddSingleton<IValidator>(_ =>
                    {
                        var NumberLimitValidator = new NumberLimitValidator();
                        NumberLimitValidator.SetNext(new NotNegativeValidator());
                        return NumberLimitValidator;
                    }
                    )
                ).Build();
    }
}
