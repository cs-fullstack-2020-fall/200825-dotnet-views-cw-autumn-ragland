# 200825-dotnet-views-cw
## Game Collection app with Razor

### Set Up
- Create a new .NET MVC app called `GameCollection` using the .NET CLI
- Run the application without debugging
- View the application in the browser
- Create a new postman request collection for the application

### Assignment
- Create a `Gamers` controller that extends the base Controller class

- Create a `Gamer` class in `Models` with the following properties:
`GamerId` int
`GamerFirstName` string
`GamerLastName` string

- Create a `VideoGame` class in `Models` with the following properties:
`VideoGameId` int
`VideoGameName` string
`VideoGameDescription` string
`VideoGamePlatform` string

- Create stub data list of Gamers in controller by adding 3 Gamers of your choosing to a List<Gamer> called `GamersList`

## ViewModels
- Create a new `ViewModels` folder
- In the `ViewModels` folder create a new View Model called `GamerGameCollection` with the following properties:
`Gamer` Gamer
`VideoGames` List<VideoGame>
  
## GamerInfo Endpoint
- Add an action to the `Gamers` controller called `GamerInfo` that accepts an int Gamer ID 
- Add a corresponding view of the same name in the `Views` folder
- In the controller action, find the gamer in the list of stub data and pass the id passsed in, and the matching (if a match) Gamer first name, Gamer last name to the view using `ViewData[]`
- In the corresponding view use conditional rendering to display the Gamer properties or the HTML `Gamer was not found for ID [WHATEVERID]`

## GamerCollection Endpoint
- Add an action to the `Gamers` controller called `GamerCollection` that accepts an int movie ID 
- Add a corresponding view of the same name in the `Views` folder that will render the Gamer details and a list of Games from a `GamerDetailsModel` instance
- In the action, create a new `GamerDetailsModel`
- Create a new `Gamer` and add it to the `GamerDetailsModel`
- Create a List of 3 video games and add the List to the `GamerDetailsModel`
- Render the corresponding view by passing in the ViewModel

## User Interface
- Modify the navigation bar to add links for `Display Gamer 1` and `Game Collection Details'
  - `Display Gamer 1` link should use the `GamerInfo` endpoint to display the Gamer with ID == 1
  - `Game Collection Details` link should use the `GamerCollection` endpoint to display the Gamer info and the video gamesin their collection
