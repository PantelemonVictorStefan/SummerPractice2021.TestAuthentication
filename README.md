# SummerPractice2021.TestAuthentication

#INSTALL

Create a database
Update connection string in appsettings.json
run the migration ("update-database")


#HOW TO USE

Register an user (password must contain all sorts of letters, numbers and symbols, Password69! will do :3 )
Login action will(if success) return an object containing a token and expiration date. Click the Authorize button from above and paste the token from the response in the following format: Bearer [tokenFromTheResponse]

There are two endpoints for the weatherForecast, one is secured for authenticated users, the other is for users with the "Admin" role.

You can create the "Admin" role by calling the roles api.

You can assign a role based on the username and role id.

Note* If you assign a role, you should login again and use the updated token.


Resources:

https://www.c-sharpcorner.com/article/authentication-and-authorization-in-asp-net-5-with-jwt-and-swagger/
