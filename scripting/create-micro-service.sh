#!/bin/sh
# this script will create a brand new C# micro-service! Wooo, exciting!

# check that at least 1 argument (the service name) is passed
if [ -z "$1" ]
then
  # if no argument was passed, exit the script with the following messages
  echo "Usage: sh create-micro-service.sh serviceName"
  echo "Please provide the name of the service"
  exit -1
fi

# set coloring for the console output
CYAN='\033[0;36m'
ORANGE='\033[0;33m'
NC='\033[0m' # No color

# assign the first argument to the '$serviceName' variable
serviceName=$1
echo -e "${CYAN}>>> creating new microservice: ${ORANGE}$serviceName${CYAN}...${NC}"

# create a new folder and open it
mkdir $serviceName
cd $serviceName

# create a new .NET solution
dotnet new sln

# create a new C# Web API project and add it to the solution
dotnet new webapi --language C# --name $serviceName.Core
dotnet sln add $serviceName.Core

# create a new C# tests project
dotnet new xunit --language C# --name $serviceName.Tests
dotnet sln add $serviceName.Tests

# restore packages and build the microservice
dotnet restore
dotnet build

# display the newly created files and open them in Visual Studio Code
echo -e "${CYAN}>>> microservice created: ${ORANGE}$serviceName${CYAN}! Opening in VS Code...${NC}"
code .
