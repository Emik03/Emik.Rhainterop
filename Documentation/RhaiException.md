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
| [Parameter](RhaiException.Parameter.md 'Emik.Rhainterop.RhaiException.Parameter') | Gets the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') representing that one of the parameters was null. |
| [Return](RhaiException.Return.md 'Emik.Rhainterop.RhaiException.Return') | Gets the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') representing that one of the parameters was null. |

| Methods | |
| :--- | :--- |
| [From(string)](RhaiException.From(string).md 'Emik.Rhainterop.RhaiException.From(string)') | Factory method. |
| [From(Exception)](RhaiException.From(Exception).md 'Emik.Rhainterop.RhaiException.From(System.Exception)') | Factory method. |
