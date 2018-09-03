# docker build -t kritner/kritnerwebsite .
# docker run -d -p 5000:5000 -e PORT=5000 kritner/kritnerwebsite
# docker push kritner/kritnerwebsite

FROM kritner/builddotnetcore:dnc2.1.401-v1-node
WORKDIR /app

# Copy everything to prep for build
COPY . ./

WORKDIR src/KritnerWebsite.Web

# Publish code
RUN dotnet publish -c Release -o out
CMD ASPNETCORE_URLS=http://*:$PORT dotnet out/KritnerWebsite.Web.dll