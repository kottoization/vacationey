# Vacationey
 
Fictional company Vacationey is a travel agency.
This project is a user-friendly webpage providing functionality for this brand.
Potential client can search for the perfect offer in a desired location.

![image](Back-end/wwwroot/images/icons/logo.png)

## Backend

### Technologies

- Visual Studio 2022
- .NET 6.0
- Entity Framework Core
</br>

### Instalation

Install necessary packages, they can be found in Dependencies -> Packages in project structure
Use Tools -> NuGet Package Manager -> Manage Nuget Packages for Solution
</br>

### Database

- SQLITE

Provide correct connection string in appsettings.json file, add:

    "ConnectionStrings": {
        "SL-Connection": "Data Source=database.db;"
    }

and adjust Program.cs, providing adequate DbContext options:

    builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SL-Connection")));

In Visual Studio Run Tools -> NuGet Package Manager -> Package Manager Console and type:
* enable-migartions
* add-migration test_migration
* update-database

You can also use different database provider, adjusting your connection string and builder.Services DbContext options

#### Entity Framework
Database is created with Code First approach using Entity Framework Core
DbContext model has a simple structure - four models with relations one-to-many:
<ul>
<li>Country</li>
<li>City</li>
<li>Hotel</li>
<li>Offer</li>
</ul>


Run project on your localhost through visual studio and find the best holidays for you

![image](Back-end/wwwroot/images/demo/home_page.png)
</br>

### Authentication 

User has an option to login, register and logout provided by AspNetCore.Identity
Views for these actions were modified to enhance user experience
Registered user can modify databse - edit, create and delete entities

![image](Back-end/wwwroot/images/demo/login_page.png)
</br>

## Pages

This action displays offers in databse.
Offer page as well as other pages supports filtering and is paginated

![image](Back-end/wwwroot/images/demo/offer_page.png)
</br>

## Filters

Through fiters you can specify your requirements and query databse

![image](Back-end/wwwroot/images/demo/filters.png)
</br>

## CRUD

All entities' controllers support CRUD operations - create, read, update, delete
</br>

## Routing

Webpage has a very intuitive layout, can be easily navigated through with buttons
Default routing: /Controller = Home/Action = Index/?id
Controllers:
* Home
* Offer
* Hotel
* City
* Country

Index action uses parameters for filtering database
Edit, Delete, Details views require id of the entity as a parameter
ex.:
* Hotel/Edit/12
* Offer/Index?countrySearch=Spain&page=1

# Frontend
</br>

Frontend was build using css and javascript
External libraries:
* JQuery
* Bootstrap
