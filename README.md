# SubmissionAPI – Docker Usage Guide

This project contains a .NET API that can be run fully inside Docker. There are two ways to run it:
 - locally
 - with docker (pull or build docker image)

## 🚀 Build and run docker container

### 1. Build the Docker image

Make sure you are in the `SubmissionAPI` directory:

1) Build docker
```bash
docker build -t submission-api .
```

2) Run docker
```bash
docker run -e ASPNETCORE_ENVIRONMENT=Development -p 8080:8080 submission-api
```
Docker is running on port 8080. You can access swagger on `http:localhost:8080/swagger`.

## 🚀 Pull and run docker container

1) Pull docker image
```bash
docker pull egorpichugin/submission-api
```

2) Run docker
```bash
docker run -e ASPNETCORE_ENVIRONMENT=Development -p 8080:8080 submission-api
```