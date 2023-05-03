### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop')

## RhaiException Class

An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') for Rhai compiler or runtime errors.

```csharp
public sealed class RhaiException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; RhaiException

| Properties | |
| :--- | :--- |
| [Buffer](RhaiException.Buffer.md 'Emik.Rhainterop.RhaiException.Buffer') | Gets the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') given when the buffer is too small to fit the value. |
| [Null](RhaiException.Null.md 'Emik.Rhainterop.RhaiException.Null') | Gets the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') representing that one of the parameters was null. |

| Methods | |
| :--- | :--- |
| [From(string)](RhaiException.From(String).md 'Emik.Rhainterop.RhaiException.From(string)') | Factory method. |
