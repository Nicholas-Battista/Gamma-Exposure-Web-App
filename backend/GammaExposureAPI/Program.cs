var builder = WebApplication.CreateBuilder(args);

   // Add services to the container.
   builder.Services.AddControllers();
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen();

   // Add CORS
   builder.Services.AddCors(options =>
   {
       options.AddPolicy("AllowReactApp",
           builder => builder.WithOrigins("http://localhost:3000")
                             .AllowAnyMethod()
                             .AllowAnyHeader());
   });

   var app = builder.Build();

   // Configure the HTTP request pipeline.
   if (app.Environment.IsDevelopment())
   {
       app.UseSwagger();
       app.UseSwaggerUI();
   }
   else
   {
       app.UseHttpsRedirection();
   }

   app.UseCors("AllowReactApp");

   app.UseAuthorization();

   app.MapControllers();

   app.Run();