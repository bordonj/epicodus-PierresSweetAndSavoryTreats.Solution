## Pierre's Sweet and Savory Treats

#### _Pierre's Sweet and Savory Treats- 08/13/21 - Code Review012_

#### By _**Jennifer Bordon**_
## Description
This is an application with user authentication and a many-to-nany relationship. The features include:

- User authentication
  - a user can log in and log out
  - only logged in users have a create, update, and delete functionality
  - all users have a read functionality
- Many-to-many relationship between `Treat`s and `Flavor`s
  - treat can have many flavors 
    - e.g., sweet, savory, spicy, creamy
  - flavor can have many treats
    - e.g., "sweet" flavor can include chocolate croissants, cheesecake, etc
- Splash page
  - lists all treats and flavors
  - Users can click on an individual treat/flavor to see all the treats/flavors that belong to it

## Technologies Used

* _C#_
* _MySQL_
* _MySQL Workbench_
* _.NET 5 SDK_
* _Git BASH_
* _ASP .NET CORE MVC_
* _Entity Framework Core_
* _Identity_

## Setup/Installation Requirements

1. Download or clone `https://github.com/bordonj/epicodus-PierresSweetAndSavoryTreats.Solution` to your local machine

2. Open terminal and navigate to the `epicodus-PierresSweetAndSavoryTreats.Solution` of the directory

3. In the the `Bakery` directory, install dependencies by running command:
`$ dotnet restore`

4. Create your database- this can be done by using Migrations
  - first, you'll need to create an appsettings.json file in the `Bakery` directory
    - add the following code to the file:
```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database={first_last};uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to replace `{first_last}` `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}` with the appropriate terms.
- for `{first_last}`, this refers to the database or schema
  - make sure to replace this input with what you decide to name the schema/database
- for `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}`, this refers to your username and password for MySQL
- NOTE: usually the username is `root`

- NOTE: _Do not include the curly brackets in your code snippet of appsettings.json_

  - in order to use a migration, first make sure you download "dotnet ef" tool by running `dotnet tool install --global dotnet-ef --version 3.0.0`
  - next make sure you are in the `Bakery` directory, and run `dotnet ef migrations add Initial`
    - this will create a new `Migrations` folder in the root of that directory
  - Finally, to apply the migration, run `dotnet ef database update`
    - this will actually create the database in MySQL so you don't have to manually create it yourself!


5. In order to see the website in the browser, make sure you've navigated to the `Bakery` diretory
  - run the code `dotnet run`
6. View the website by entering `localhost:5000/` in the url of your browser/client 

## Bugs

_No known bugs at this time. But if any found, please contact me so I can fix them._

## License

_MIT_

_Copyright (c) 2021 Jennifer Bordon_


## Contact Information

_jennifer.bordon@gmail.com_