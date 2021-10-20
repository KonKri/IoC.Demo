using IoC.Demo.StringManipulation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Use AddStringManipulationService to add the service and provide its options.
builder.Services.AddStringManipulation(options =>
{
    // try commenting the following lines to check if an exception will be thrown.
    options.Prefix = "PREF";
    options.Suffix = "SUFF";
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
