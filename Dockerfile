FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /Hackaton/ChillMap

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
CMD dotnet AspNetCoreHerokuDocker.dll