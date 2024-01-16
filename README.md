# ProductMicroserviceRepo
This is part of the final project for the DevOps course. It is a simple microservice, which returns an array of products. It was written using C# and it is configured to listen on port 30217. It is used in the angular frontend to provide some data. The repo contains a dockerfile for building the image. It also contains a manifest file that should be used when launched using Kubernetes.
The workflow involves a pipeline that tests using Snyk and Sonarcloud, builds the image and then sends it to the Docker hub.
