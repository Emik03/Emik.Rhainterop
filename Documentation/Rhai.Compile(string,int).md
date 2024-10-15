### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.Compile(string, int) Method

`eval` Function.

```csharp
public static Emik.Results.Result<Emik.Rhainterop.AST,Emik.Rhainterop.RhaiException> Compile(string? script, int length=1024);
```
#### Parameters

<a name='Emik.Rhainterop.Rhai.Compile(string,int).script'></a>

`script` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The script to execute.

<a name='Emik.Rhainterop.Rhai.Compile(string,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The size of the internally allocated buffer.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[AST](AST.md 'Emik.Rhainterop.AST')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".