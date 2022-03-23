This project explores how to work with distributed GraphQL APIs.
The different ways of using the HotChocolate framework for this is seperated by branch.

This branch explores Schema Federation, where it is the responsibility of the APIs to make the Gateway aware of their schema. The nugets used for this branch are:

```
Version 12.7.0

HotChocolate.AspNetCore
HotChocolate.Data
HotChocolate.Stitching.Redis
```

Since this method requires a Redis server to allow for hot reloading of schemas, a `docker-compose.yaml` file is included to easily spin up a Redis instance by using the command `docker-compose up`.

The three projects used in this use their own ports and are meant to be run simultaneously.

```
Gateway         5000
PersonService   5001
AddressService  5002
```