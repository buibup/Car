# code first

## migrations
	dotnet ef migrations add Initial -s ..\Car.Api\ -o Migrations -c ApplicationDbContext

## update database
	dotnet ef -s ..\Car.Api\ database update -c ApplicationDbContext