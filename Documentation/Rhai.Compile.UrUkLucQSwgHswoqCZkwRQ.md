### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.Compile(Span<byte>, string) Method

`eval` Function.

```csharp
public static Result<Emik.Rhainterop.AST,System.Exception> Compile(System.Span<byte> buffer, string? script);
```
#### Parameters

<a name='Emik.Rhainterop.Rhai.Compile(System.Span_byte_,string).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The buffer to mutate.

<a name='Emik.Rhainterop.Rhai.Compile(System.Span_byte_,string).script'></a>

`script` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The script to execute.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".