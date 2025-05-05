#EmployeeManagment
1-//Update the connection string in appsettings.json replace with your server name 
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EmployeeManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}


2-Apply database migrations:
dotnet ef database update

3-Run the backend:
command ==> dotnet run


#Frontend
1-npm install
2-install bootstrap 
3-npm install font-awesome
4-install sweetalert2 
5-install NgbPaginationModule 
6-install primeng

Run the frontend:
==>ng s -o

