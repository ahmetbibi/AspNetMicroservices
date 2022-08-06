# Some Useful Commands

## Docker
### General
- `docker ps` to see running containers 

### For Mongo DB
- `docker pull mongo` to pull Mongo DB image
- `docker run -d -p local's'-port-number:image's'-port-number --name container-name image-name` to run a Mongo db. Port number for default => 27017:27017. Image name => mongo
- `docker exec -it container-name /bin/bash` to go inside of the created container, and ti open the interactive terminal in it. `-it` means => interactive terminal.



## Terminal Commands
### Windows CMD/Power Shell (PS)
- `Get-Help Set-Location -Full` to get help info about Set-Location command in PS
- `Set-Location -Path C:\Folder-Name` to head to a folder in PS
- `cd` to change the directory
- `dir` to list the current directory content
- `cls` to clear command/PS screen
- `start` to run a file


### Linux Bash
- `ls` to list the current directory content
- `pw` to print the current working directory
- `rm -r` to delete files and directories
- `cd` to navigate between directories on your computer
- `mkdir` to create new directories
- `clear` to clear bash screen


## For Databases
### MongoDB
- `show dbs` to show databases
- `use database-name` to create/use a database
- `db.createCollection('collection-name')` to create a collection in the DB
- `db.collection-name.insertMany([{},{},...])` to insert multiple items under a collection
- `db.collection-name.find({}).pretty()` to see the objects in a collection
- `db.collection-name.remove({})` to remove objects from a collection
- `show collections` to show the collections in the DB
