# Automation Testing in Containers

This project was created as sample playground for doing automated UI testing with Selenium inside of a container.  There are three projects to make up a complete system.  
- react-node-app: This is a basic node.js app with one api
- react-client-app: This is a basic React app with three pages.  One of which connects to the react-node-app
- core-xunit-app: This is a basic dotnet core xunit test project with four tests
---
## How To

### Run Docker Compose
```
docker-compose up
```
NOTE: The compose file should standup all three projects plus Selenium Chrome Standalone instance and run all four tests again this instance


