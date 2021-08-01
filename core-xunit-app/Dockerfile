FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /tests
COPY . .
#COPY ["core-xunit-app.csproj", "/"]
RUN dotnet restore "core-xunit-app.csproj"
#COPY . .
# RUN dotnet test