# KritnerWebsite
Website in .netcore

My website, mostly used for exploring new tech and my own learning opportunities.  

## Requirements 

* docker
* docker-compose

## To run

### for dev
```cmd
cd .docker
docker-compose up -d
```

### for prod

```cmd
cd .docker
docker-compose -f docker-compose.yml up -d 
```

## To build
```cmd
docker build -t $(DOCKER_REGISTRY)/kritnerwebsite .
```