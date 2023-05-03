### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.EvalFile<T>(string, int) Method

`eval` Function.

```csharp
public static Result<T,System.Exception> EvalFile<T>(string? path, int length=1024);
```
#### Type parameters

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(string,int).T'></a>

`T`

The type of the resulting type, [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') can be used much like `rhai::Dynamic` in Rust.
#### Parameters

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(string,int).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path containing the script to execute.

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(string,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The size of the internally allocated buffer.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".