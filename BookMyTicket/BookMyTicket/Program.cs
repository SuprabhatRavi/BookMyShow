using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using PetaPoco;
using SimpleInjector;
using SimpleInjector.Lifestyles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

Container container = new Container();
container.Options.DefaultLifestyle = Lifestyle.Scoped;
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

builder.Services.AddSimpleInjector(container, options =>
{
    options.AddAspNetCore()
    .AddControllerActivation();
});

//container.Register<IBookMyTicketServices,BookMyTicketServices>();
container.Register<IBookingServices,BookingServices>();
container.Register<IMovieGenreServices,MovieGenreServices>();
container.Register<IMovieServices,MovieServices>();
container.Register<ISeatServices,SeatServices>();
container.Register<IShowServices,ShowServices>();
container.Register<IUsersServices,UsersServices>();

container.Register<Database>(() => new Database("Data Source=LAPTOP-S0V1BVRJ;Initial Catalog=BookMyTicket;Integrated Security=True", "System.Data.SqlClient"), Lifestyle.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Services.UseSimpleInjector(container);

app.Run();
