using Microsoft.Extensions.DependencyInjection;
using Petconnect.Application.Services;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.DependencyInjection; 
public static class ApplicationModule {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services) {
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IAnimalService, AnimalService>();
        services.AddScoped<IChatService, ChatService>();
        services.AddScoped<ICommonUserService, CommonUserService>();
        services.AddScoped<IEvaluationService, EvaluationService>();
        services.AddScoped<IMessageService, MessageService>();
        services.AddScoped<IServiceCategoryService, ServiceCategoryService>();
        services.AddScoped<IServiceService, ServiceService>();
        services.AddScoped<IServiceProviderService, ServiceProviderService>();
        services.AddScoped<IServiceRequestService, ServiceRequestService>();
        services.AddScoped<ISpecieService, SpecieService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
