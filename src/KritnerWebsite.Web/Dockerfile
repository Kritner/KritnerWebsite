# docker build -t kritnerwebsite .
# docker run -d -p 80:5000 -p 443:5001 kritnerwebsite

FROM microsoft/dotnet:2.1-sdk
WORKDIR /app
EXPOSE 5000 5001

# Copy and build everything
COPY . ./

# Setup the environment with npm
RUN apt-get update \
    && apt-get -y upgrade \
    && apt-get -y dist-upgrade \
    && apt-get install -y gnupg \
    && apt-get install -y sudo \
    && curl -sL deb.nodesource.com/setup_10.x | sudo -E bash - \
    && apt-get install -y nodejs

# Publish code
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/KritnerWebsite.Web.dll"]