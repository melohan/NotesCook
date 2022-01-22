# NotesCook
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-4EA94B?style=flat-square&logo=mongodb&logoColor=white)

![GitHub last commit](https://img.shields.io/github/last-commit/melohan/NotesCook?style=flat-square)
![GitHub contributors](https://img.shields.io/github/contributors/melohan/NotesCook?style=flat-square)
![GitHub issues](https://img.shields.io/github/issues/melohan/NotesCook?style=flat-square)

## Authors
- [Ohan Mélodie](https://github.com/melohan)
- [Dubuis Hélène](https://github.com/HDubuis)
- [Gauthier Théo](https://github.com/TGACPNV)

## About the project
!Cook or  «Not/Notes Cook» is a recipe notepad app designed to be used on a smartphone.
The purpose of this application is to save a recipe, its ingredients and its preparation steps.

The search will be done through a tag system, making it easy to find and consult a recipe.

## Table of contents

1. [Technical documentation](#1-technical-documentation)
2. [Built with](#2-built-with)
3. [Installation](#3-installation)
4. [Database configuration](#4-database-configuration)
5. [Environnement Configuration](#5-environnement-configuration)


### 1 Technical documentation
More details about project structure dans files: [technical documentation](documentation/technical/technical_documentation.md).

### 2 Build with

- C# .Net 4.8.4084.0
- [MongoDb 5.0.5](https://www.mongodb.com/try/download/database-tools)
- [Composer 2.1.14](https://getcomposer.org/download/)

## Setting up Dev

### 3 Installation
``` shell
git clone https://github.com/melohan/NotesCook.git
cd NotesCook
git checkout develop
```

### 4 Database configuration

Without import,`NotesCook` database and the collection `recipes` will be created at the first added recipe.

You can start the application with example data:
1) In MongoDB compass, create database `NotesCook` with `recipes` collection. 
2) Import example file in `/documentation/database/recipes.json`


### 5 Environnement Configuration

> Our development environment is Microsoft Visual Studio 2019.
- .Net Desktop environnment
- Nuget package manager

#### VS 2019 issues 
> Here we describe the configurations or resolutions of issues encountered during installation.

#### NuGet Package Offline packages
1) Go to `Tools -> Options -> NuGet Package Manager -> Package Sources`
2) Add with (+) a new package source
3) Update the added package source as follow: `Name:  nuget.org`, `Source: https://api.nuget.org/v3/index.json`
4) Save

#### Can't download MongoDB driver  
Download MongoDB.Drive Nuget package [here](https://www.nuget.org/packages/MongoDB.Driver/).




