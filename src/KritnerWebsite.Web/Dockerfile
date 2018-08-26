# docker build -t kritnerwebsite .
# docker run -d -p 80:5000 -p 443:5001 kritnerwebsite

FROM kritner/builddotnetcore:dnc2.1-v1-node
WORKDIR /app

# Using 5000 for http, 5001 for https
EXPOSE 5000 5001

# Copy everything to prep for build
COPY . ./

# Publish code
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/KritnerWebsite.Web.dll"]