## About this solution

This is a minimalist, non-layered startup solution with the ABP Framework. All the fundamental ABP modules are already installed.

## How to run

The application needs to a database. Run the following command in the `Sanbox.Main` directory:

````bash
dotnet run --migrate-database
````

This will create and seed the initial database. Then you can run the application with any IDE that supports .NET.

Happy coding..!


# Journaling

```
abp new Sanbox.Main -t app-nolayers -u mvc -d ef -dbms SQLite --no-random-port  --preview
```

## DB 

### Dev Db

```
sqlcmd -S GAMING-LABTOP\SQLEXPRESS01 -E
```
