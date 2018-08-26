# docker build -t kritner/kritnerwebsite .
# docker run -d -p 80:5000 -p 443:5001 kritner/kritnerwebsite
# docker push kritner/kritnerwebsite

FROM kritner/builddotnetcore:dnc2.1.401-v1-node
WORKDIR /app

# Using 5000 for http, 5001 for https
EXPOSE 5000 5001

# Copy everything to prep for build
COPY . ./

WORKDIR src/KritnerWebsite.Web

# Publish code
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/KritnerWebsite.Web.dll"]