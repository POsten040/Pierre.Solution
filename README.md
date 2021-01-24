# _Pierre's Bakery_

#### _DATE 01.15.2021_

#### By _**Patrick Osten**_

![](ReadMeAssets/recording.gif)

## Description
- This application was made as part of the Epicodus Coding bootcamp coursework.
- It allows the owner of a certain special bakery to sell different Treats that have various Flavors. You can view all Flavors and Treats, all Treats of a certain Flavor and vice versa. Double chocolate Croissant? Yes. Doughnuts with M&M sprinkles? You bet. Buttery Bacon Bonets? Stay hungry my friend.

## Setup/Installation Requirements

<details>

Software Requirements
* An internet browser of your choice
* A code editor; I used [VsCode](https://code.visualstudio.com/download)
* [MySql Workbench](https://dev.mysql.com/downloads/workbench/)
* [.NET Core 2.2](https://dotnet.microsoft.com/download)

Open by Downloading or Cloning
* Navigate to <Pierre.Solution/Pierre>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository with `git clone `

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main project directory (Pierre.Solution/`Pierre`). 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=posten-pierre;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

</details>

## Launching the Application
* Navigate to Pierre.Solution/Pierre and type `dotnet restore` into the terminal
* Then, in the same project folder, type `dotnet ef database update` to create the database. 
* To open in your browser type `dotnet run` 

## User Stories
<details>

| User Stories                                                                                                                                                                                                                                                               |   |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---|
| The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.                                                                                                                                            |   |
| There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on. |   |
| A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.)                                                                                                            
</details>
<br>

## Known Bugs

-none 1/24/21

## Support and contact details

Patrick Osten at <posten.coding@gmail.com> 

## Technologies Used

* [Identity](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity/)
* C#
* Razor
* [Entity Framework Core 2.2.6](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)
* [MySql Workbench](https://dev.mysql.com/downloads/workbench/)
* [.NET Core](https://dotnet.microsoft.com/download)
* Coffee

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Patrick Osten_**
