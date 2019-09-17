# _Business API_

#### _A C# MVC based API that allows the user to add and  retrieve data about local businesses. , August 23, 2019_

#### By _**Aaron Whang**_

## Description

_This program was created for the TenthFriday project assigned to the students of Epicodus Seattle May 28th class. This is a web API that will allow the user to add business information into a database and be able to view, edit or delete them. 

## Setup/Installation Requirements

* _clone repository off of Github_
* _go to parent directory using terminal for Mac, git.bash for Windows_
* _type dotnet ef migrations add InitialCreate_
* _type dotnet ef database update_
* _type in 'dotnet watch run' to run the program_

##

* _ http://localhost:5000/api/shops/ -will add new business object. the object is organized to require Name(string), Type(string), PRange(Int) and Comment(string).
* _http://localhost:5000/api/shops/{shopId} -will show the shop by ID. User may call a GET, PUT and DELETE on this controller.
* _http://localhost:5000/api/shops/random -will return random object within the api JSON
* _ http://localhost:5000/swagger/ will show the swagger UI
* _ http://localhost:5000/swagger/v1/swagger.json to view the Swagger specification.



## Known Bugs




## Support and contact details

_For any questions about the website, code or content, please contact me at tlbhibiki@gmail.com_

## Technologies Used

_Written in C# MVC
_Swagger

### License

_All code are created and owned by Aaron Whang_

Copyright (c) 2019 **_Aaron Whang_**
