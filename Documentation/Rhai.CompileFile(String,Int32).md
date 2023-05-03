### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.CompileFile(string, int) Method

`eval` Function.

```csharp
public static Result<Emik.Rhainterop.AST,System.Exception> CompileFile(string? path, int length=1024);
```
#### Parameters

<a name='Emik.Rhainterop.Rhai.CompileFile(string,int).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path containing the script to execute.

<a name='Emik.Rhainterop.Rhai.CompileFile(string,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The size of the internally allocated buffer.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".