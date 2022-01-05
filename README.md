# !Cook 
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-4EA94B?style=flat-square&logo=mongodb&logoColor=white)

![GitHub contributors](https://img.shields.io/github/contributors/melohan/NotesCook?style=flat-square)


## Table of contents

1. [Prerequisites](#prerequisites)
    1. [Built with](#build-with)
2. [Setting up Dev](#setting-up-dev)
    1. [Installation](#installation)
    2. [Configuration](#configuration)
    3. [Run project](#run-project)

## Prerequisites

### Build with

- .Net 4.8.4084.0
- MongoDb 5.0.5
- Composer 2.1.14
- npm 8.1.2

## Setting up Dev

### Installation

``` shell
git clone https://github.com/melohan/NotesCook.git
cd NotesCook
git checkout develop
```

### Configuration

1) Rename `.env.exemple` to `.env`
2) Set these constants `DB_` according to your database access
4) Create a database with the name priki, you can run the following
   command: `CREATE SCHEMA IF NOT EXISTS priki DEFAULT CHARACTER SET utf8;`
5) Generate database `php artisan migrate:fresh --seed`

### Run Project

Execute this laravel command: `php artisan serve`
