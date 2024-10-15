### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.EvalFile<T>(Span<byte>, string) Method

`eval` Function.

```csharp
public static Emik.Results.Result<T,Emik.Rhainterop.RhaiException> EvalFile<T>(System.Span<byte> buffer, string? path)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(System.Span_byte_,string).T'></a>

`T`

The type of the resulting type, [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') can be used much like `rhai::Dynamic` in Rust.
#### Parameters

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(System.Span_byte_,string).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The buffer to mutate.

<a name='Emik.Rhainterop.Rhai.EvalFile_T_(System.Span_byte_,string).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path containing the script to execute.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[T](Rhai.EvalFile{T}(Span{Byte},string).md#Emik.Rhainterop.Rhai.EvalFile_T_(System.Span_byte_,string).T 'Emik.Rhainterop.Rhai.EvalFile<T>(System.Span<byte>, string).T')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".