# APSI-database

## Database schema generation - code first (.NET Core 5.0)

Tables in database are created from data model written in C#. If you want to add new table, just create new class and add it to AppDbContext as DbSet. Types and fields names are automatically mapped to fields in table. Relations are created automatically for instance if Idea has list of Costs its automatically one-to-many. User have list of SocialGroups and SocialGroups have list of users so it's mapped to many-to-many. 

In order to seed database, run console application.

Required:

* Visual Studio Code
* .NET 5.0 SDK
* `dotnet tool install --global dotnet-ef`

How to change database schema:

1. Open repository in Visual Studio Code
1. Change data model and make sure AppDbContext is updated if tables were added or deleted
1. To add new migration reflecting changes on db schema from last migration run in console: `dotnet-ef migrations add MigrationName`
1. To update database run in console: `dotnet-ef database update`
1. Commit changes!