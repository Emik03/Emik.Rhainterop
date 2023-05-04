### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[AST](AST.md 'Emik.Rhainterop.AST')

## AST.Eval<T>(Span<byte>) Method

`eval` Function.

```csharp
public Result<T,System.Exception> Eval<T>(System.Span<byte> buffer);
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
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".