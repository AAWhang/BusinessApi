# BusinessApi

#### Placeholder info until I can make a proper README.
#### To make use of this API, download, go to the master directory and type these two commands.
##### dotnet ef migrations add Initial
##### dotnet ef database update
#### http://localhost:5000/api/shops/ -will add new business object. the object is organized to require Name(string), Type(string), PRange(Int) and Comment(string).
#### http://localhost:5000/api/shops/{shopId} -will show the shop by ID. User may call a GET, PUT and DELETE on this controller.
#### http://localhost:5000/api/shops/random -will return random object within the api JSON

#### http://localhost:5000/swagger/ will show the swagger UI
#### http://localhost:5000/swagger/v1/swagger.json to view the Swagger specification.
