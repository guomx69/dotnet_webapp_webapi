dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.16

 <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.16">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>

<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="6.0.8" />
<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL.Design" Version="1.0.2" />
<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite" Version="6.0.8" />

 docker-compose  -f installPostGIS.yml up //to start postgis datbase;

//add the following before call dotnet ef;
builder.Services.AddDbContext<AppDbContext>(opt=>
          opt.UseNpgsql(builder.Configuration.GetConnectionString("DbApiServer"), pt=>pt.UseNetTopologySuite()));

 dotnet ef migrations add initial --verbose
//check if postgis extension is enable or not. PostGIS is installed, should be available, but not, so run the 
//following code before running the update database;
SELECT * FROM pg_available_extensions;
CREATE EXTENSION postgis ;

dotnet ef datbase update

INSERT INTO public."Properties"
(address, "size", "sizeUnit", price, "isRentOnly", "isCommercial", "name", "isOwner", point, "imageUrls")
VALUES('meter', 230, '21823 Barton Park Ln',2340, false, false, 'abc', false, ST_GeomFromText('POINT( -95.74083 29.72213)',4326),'{}');