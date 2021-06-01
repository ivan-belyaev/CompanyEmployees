# CompanyEmployees

# Description

Company Employees WEB API<br>
From CMD run<br>
dotnet dev-certs https --clean<br>
dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\companyemployees.pfx -p awesomepass<br>
dotnet dev-certs https --trust<br>
As administrator perform<br>
setx SECRET "SecretKey" /M and uncomment Environment.GetEnvironmentVariable("SECRET"); in ServiceExtentions.cs, AuthenticationManager.cs<br>

# Features

- [x] ASP.NET Core 3.1
- [x] DataBase PostgreSQL with Pgadmin
- [x] Repository Pattern
- [x] AutoMapper
- [x] Global Error Handling
- [x] GET, POST, PUT, PATCH, DETELE, OPTIONS
- [x] Asynchronous code
- [x] Action Filters
- [x] Paging
- [x] Filtering
- [x] Searching
- [x] Sorting
- [x] HATEOAS
- [x] Versioning
- [x] Caching
- [x] Rate Limiting
- [x] JWT
- [x] SWAGGER