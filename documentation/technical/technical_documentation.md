# Technical documentation

## Database design document:
- [UML]()

### Files and directories

| Directories |Information|
|---|---|
|`src/App`|Main directory|
|`src/App/Forms`|All the forms of the application are present in this directory organized by operations: `show`, `create`, `search`.|
|`src/App/Models`|All the models used in this application can be found in this directory.|
|`src/App/Database`|Everything related to database operations can be found in this directory.|


### Models

Models are in `src/App/Models` directory. They're implemented as follows:

| Models |Role|
|---|---|
|`Model.cs`|Parent model, it is an abstract class that uses CRUD methods provided by `src/App/Database/DB.cs`|
|`Recipe.cs`|Main object in this project, it contains list of `Step`, `Ingredient`, `Tag` objects.  The creation, deletion or modification of these objects are done by the instance of this class. Database collection `recipes`is linked to its structure.|
|`Tag.cs`, `Ingredient.cs`, `Step.cs`|Class representing the recipes sub objects, the MongoDB private identifier are defined in their constructors.|


