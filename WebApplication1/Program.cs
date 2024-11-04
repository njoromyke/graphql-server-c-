using WebApplication1.Mutations;
using WebApplication1.Query;
using WebApplication1.Subscriptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions()
    .AddMutationType<Mutations>()
    .AddMutationConventions();

var app = builder.Build();

app.UseWebSockets();

app.MapGraphQL();

app.Run();
