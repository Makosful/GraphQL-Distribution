This project explores how to work with distributed GraphQL APIs.
The different ways of using the HotChocolate framework for this is seperated by branch.

This branch explores Schema Stitching, where the Gateway is responsible for querying the schemas from all the APIs it wants to integrate with.

```
Version 12.7.0

HotChocolate.Core
HotChocolate.Data
HotChocolate.Stitching
```

The three projects used in this use their own ports and are meant to be run simultaneously.

```
Gateway         5000
PersonService   5001
AddressService  5002
```