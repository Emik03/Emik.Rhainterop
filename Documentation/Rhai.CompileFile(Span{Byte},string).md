### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.CompileFile(Span<byte>, string) Method

`eval` Function.

```csharp
public static Emik.Results.Result<Emik.Rhainterop.AST,Emik.Rhainterop.RhaiException> CompileFile(System.Span<byte> buffer, string? path);
```
#### Parameters

<a name='Emik.Rhainterop.Rhai.CompileFile(System.Span_byte_,string).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The buffer to mutate.

<a name='Emik.Rhainterop.Rhai.CompileFile(System.Span_byte_,string).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path containing the script to execute.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[AST](AST.md 'Emik.Rhainterop.AST')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".