# IoC.Demo
This solution is a PoC for developing services to be used in .NET projects, using Dependency Injection.

## Getting Started
This demo solution was developed using .NET 6.
Ready to be run out of the box to test its functionality.

- **IoC.Demo.Api** Represents an API project in which we are injecting the new service.
- **IoC.Demo.StringManipulation** Represents the new service that we want to inject. 
The implemented demonstrative functionality focuses on manipulating strings by adding a *prefix* and a *suffix*.

### Call ```.AddStringManipulation()``` to initialize the service.
Users have to configure the service with the prefix and suffix combo they need.
Such configuration can be seen in the example below:

```
builder.Services.AddStringManipulation(options =>
{
    options.Prefix = "PREF";
    options.Suffix = "SUFF";
});
```

If one option or both of them is not defined, a ```StringManipulationException```
is thrown at runtime (initialization time).

Get the injected service by the example below:
```
private readonly IStringManipulationService _charManipulatorService;

public StringController(IStringManipulationService charManipulatorService)
{
    _charManipulatorService = charManipulatorService;
}
```

### Call ```.ManipulateStr(ref string phrase)``` to manipulate a ```string```
Please note that the parameter provided in the method is a reference which means the result of the manipulation will affect the variable given.
Here is an example controller's action:
```
[HttpGet(Name = "Manipulate String with prefix and suffix")]
public IActionResult Get([FromQuery] string phrase = "The quick fox jumps over the lazy dog")
{
    // manipulate existing phrase.
    _charManipulatorService.ManipulateStr(ref phrase);

    return Ok(phrase);
}
```

Of course the result will be **"PREFThe quick fox jumps over the lazy dogSUFF"**.
