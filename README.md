![Build](https://github.com/sebagomez/k8s-cs-controller/workflows/Build/badge.svg)
[![NuGet](https://github.com/sebagomez/k8s-cs-controller/workflows/NuGet/badge.svg)](https://www.nuget.org/packages/Kubernetes.Controller.SDK/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Kubernetes.Controller.SDK.svg?label=NuGet%20downloads&color=success)](https://www.nuget.org/packages/Kubernetes.Controller.SDK/)

# Kubernetes Controller SDK for .NET

![](./res/K8sControllerSDK.png)

Inspired by [this post](https://blog.container-solutions.com/cloud-native-java-infrastructure-automation-with-kubernetes-operators) I thought the .NET community should also have an easy way of creating a Kubernetes Operator with their favorite languagge. ;)

So, here it is... (you can also find it at [NuGet](http://nuget.org/packages/Kubernetes.Controller.SDK))

I am pretty new on the internals of Kubernetes and this was a fun way to discover how the api and other resources work. I am I'm not saying this is a great/production-ready solutions. I am positive it is not, since it is my first approach to to the problem, but I wanted to see if it was possible and easy to do it.

Also based on the post from above I thought of doing a simple example, and created a `CustomResourceDefinition` to create Microsoft SQL Server databases.
You can take a look at the sample [here](./samples/mssql-db), maybe more examples will eventually develop, it depends on the traction of the project.

## How does it work?

I started writing how it works and I think the explanation got too complicated. Please head over to the MSSQLDB sample to understand how a real case works.

It basically uses the [KubernetesClient](https://github.com/kubernetes-client/csharp) to access the Kubernetes API, but seriously, take a look al the example provided to get a better understandong of how it works.

### [MSSQLDB](./samples/mssql-db)
