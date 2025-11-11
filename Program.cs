using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLParser.Services;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Migrations;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// all the repository is required and injected 
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();
builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();




// all the Types is registerd here  and injected in the servecies container 
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<CategoryType>();
builder.Services.AddTransient<ReservationType>();
builder.Services.AddTransient<ReviewType>();
builder.Services.AddTransient<UserType>();


// all the queries are registerd here , and injected in the service conatainer
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<CategoryQuery>();
builder.Services.AddTransient<ReservationQuery>();
builder.Services.AddTransient<ReviewQuery>();
builder.Services.AddTransient<UserQuery>();
builder.Services.AddTransient<RootQuery>();

// all the mutations are added here , and injected in the servecies container 
builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<CategoryMutation>();
builder.Services.AddTransient<ReservationMutation>();
builder.Services.AddTransient<ReviewMutation>();
builder.Services.AddTransient<UserMutation>();
builder.Services.AddTransient<RootMutation>();


// all the types are registered here , under servecies 
builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<CategoryInputType>();
builder.Services.AddTransient<ReservationInputType>();
builder.Services.AddTransient<ReviewInputType>();
builder.Services.AddTransient<UserInputType>();


// Register the RootSchema as the implementation for ISchema.
// This schema wires together all queries and mutations for the GraphQL endpoint.
builder.Services.AddTransient<ISchema, RootSchema>();



// Configure GraphQL.NET to use the registered schema and System.Text.Json for serialization.
// AddAutoSchema automatically builds the schema from the registered ISchema.
builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());



// Register the EF Core DbContext with SQL Server provider.
// The connection string is pulled from appsettings.json using the key "GraphQLDbContextConnection".
builder.Services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDbContextConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Enable the GraphiQL UI at the /graphql endpoint.
// This provides a browser-based IDE for testing GraphQL queries and mutations.
app.UseGraphiQl("/graphql");

// Activate the GraphQL endpoint using the registered ISchema.
// This handles incoming GraphQL requests and routes them through your schema.
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
