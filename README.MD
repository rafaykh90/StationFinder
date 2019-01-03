# Station Finder

This is a simple application build with .Net Core 2.2 and React for the Client Side.

# Features!
  - Provides the most suitable Station near the device location (x, y) by calculating the Power with respect to the Station. 
  - A link station’s power can be calculated: power = (reach - device's distance from linkstation)^2. if distance > reach, power = 0
  - Front-end Client App uses Webpack for Production builds. The CSS and Javascript files are minified for the Production builds at deployment

# Requirements
- .Net Core 2.2 SDk - Runtime
- NPM v8.x.x
- VS Code/Visual Studio (Editor of your liking - Preferred Visual Studio, easy to run Tests)

# How To Run
- Clone the repo `git clone https://github.com/rafaykh90/StationFinder.git`
- Run `cd StationFinder/`
- Run `dotnet restore`
- then `dotnet run -p NordCTask/NordCTask.csproj` - This will take some time due to npm package installation when running for the first time (Builds and run the project)

##### Alternatively
- Clone the repo `git clone https://github.com/rafaykh90/StationFinder.git`
- Run `cd StationFinder/`
- Run `./run.sh`

# Project Structure
- NordCTask - This is the .Net Core Application main project which is to be run. Contains the React Client App as well as the Back-end API
- NordCTask.Models - Contains the data models used in the main project
- NordCTask.Services - Contains the StationFinderService which has been sparated from the main project to be used as a buisiness logic. In bigger projects inpendent microservices can be implemented this way
- NordCTask.Test - Contains xUnit Tests including Unit tests for the calculation logic and Integration tests for the service. 

# Deployed Version
The app is deployed to Azure and can be accessed with the URL https://station-finder-01.azurewebsites.net/. 