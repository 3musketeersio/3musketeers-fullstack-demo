# Customer API Azure Function

## API List

| Methods       | API            | Payload                               |
| ------------- | -------------  | -------------------------------------| 
| GET           | /api/customers | None                                  |
| POST          | /api/customer  | {firstname: "Anh", lastname: "Nguyen"}|

# Run locally

Install azure-function-core-tools. More information can be found [here](https://github.com/Azure/azure-functions-core-tools) 
```
brew tap azure/functions
brew install azure-functions-core-tools@3
```

Run:
```
func start
```
