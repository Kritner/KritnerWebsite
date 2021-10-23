# docker build -t kritner/kritnerwebsite .
# docker run -d -p 5000:5000 kritner/kritnerwebsite
# docker push kritner/kritnerwebsite

# Runner image - Runtime + node for ng serve
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
RUN apt-get update \
    && apt-get -y upgrade \
    && apt-get -y dist-upgrade \
    && apt-get install -y gnupg \
    && apt-get install -y sudo

# Builder image - SDK + node for angular building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
RUN apt-get update \
    && apt-get -y upgrade \
    && apt-get -y dist-upgrade \
    && apt-get install -y gnupg \
    && apt-get install -y sudo \
    && curl -sL deb.nodesource.com/setup_14.x | sudo -E bash - \
    && apt-get install -y nodejs

WORKDIR /src

# Copy only the csproj file(s), as the restore operation can be cached, 
# only "doing the restore again" if dependencies change.
COPY ["./src/KritnerWebsite.Web/KritnerWebsite.Web.csproj", "src/KritnerWebsite.Web/KritnerWebsite.Web.csproj"]

# Run the restore on the main csproj file
RUN dotnet restore "src/KritnerWebsite.Web/KritnerWebsite.Web.csproj"

# Contains the angular related dependencies, similar to csproj above result is cachable.
COPY ["./src/KritnerWebsite.Web/ClientApp/package.json", "src/KritnerWebsite.Web/ClientApp/package.json"]

# Install the NPM packages
RUN cd src/KritnerWebsite.Web/ClientApp \
    && npm install

# Copy the actual files that will need building
COPY ["src/KritnerWebsite.Web/", "src/KritnerWebsite.Web"]

WORKDIR /src/src/KritnerWebsite.Web

# Build the .net source, don't restore (as that is its own cachable layer)
RUN dotnet build -c Release -o /app --no-restore
 
FROM build AS publish

# Perform a publish on the build code without rebuilding/restoring. Put it in /app
# RUN dotnet publish -c Release -o /app --no-restore --no-build
RUN dotnet publish -c Release -o /app --no-restore

# The runnable image/code
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KritnerWebsite.Web.dll"]
