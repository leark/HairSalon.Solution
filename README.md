# Eau Claire's Hair Salon

#### By _Seung Lee_

#### _A simple website that lets a user manage a number of stylists and clients._

## Technologies Used

* _C#_
* _Razor_
* _HTML_
* _CSS_
* _Bootstrap_
* _MySQL_
* _Entity_

## Description

A simple website where a user can add stylists and clients. Per stylists and clients, the website keeps track of their phone numbers. For clients, the website also tracks which stylist they belong to. Stylists and clients can be deleted. Stylists or clients can be searched by their name.

## Setup/Installation Requirements

_Requires console application such as Git Bash, Terminal, or PowerShell_
_Requires MySQL and MySQL Workbench to be installed_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/HairSalon.Solution.git``

3. Run the command

    ``cd HairSalon.Solution``

* You should now have a folder `HairSalon.Solution` with the following structure.
    <pre>HairSalon.Solution
    └── HairSalon
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        └── Startup.cs</pre>

4. Add a file named appsettings.json in the following location 

    <pre>HairSalon.Solution
    └── HairSalon
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        ├── Startup.cs
        └── <strong>appsettings.json</strong></pre>

5. Copy and paste below JSON text in appsettings.json.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=seung_lee;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"
  }
}
```

6. Replace [YOUR-USERNAME-HERE] with your MySQL username.

7. Replace [YOUR-PASSWORD-HERE] with your MySQL password.

8. Import seung_lee.sql file in the root directory to MySQL Workbench. Instructions on how to import a database is [here](https://dev.mysql.com/doc/workbench/en/wb-admin-export-import-management.html)

<strong>To Run</strong>

Navigate to the following directory in the console
    <pre>HairSalon.Solution
    └── <strong>HairSalon</strong></pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``


This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _No known issues_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee




