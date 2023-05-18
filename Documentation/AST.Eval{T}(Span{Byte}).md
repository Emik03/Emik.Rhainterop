### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[AST](AST.md 'Emik.Rhainterop.AST')

## AST.Eval<T>(Span<byte>) Method

`eval` Function.

```csharp
public Emik.Results.Result<T,Emik.Rhainterop.RhaiException> Eval<T>(System.Span<byte> buffer)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Rhainterop.AST.Eval_T_(System.Span_byte_).T'></a>

`T`

The type of the resulting type, [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') can be used much like `rhai::Dynamic` in Rust.
#### Parameters

<a name='Emik.Rhainterop.AST.Eval_T_(System.Span_byte_).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The buffer to mutate.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[T](AST.Eval{T}(Span{Byte}).md#Emik.Rhainterop.AST.Eval_T_(System.Span_byte_).T 'Emik.Rhainterop.AST.Eval<T>(System.Span<byte>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".