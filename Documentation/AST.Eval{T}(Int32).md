### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[AST](AST.md 'Emik.Rhainterop.AST')

## AST.Eval<T>(int) Method

`eval` Function.

```csharp
public Result<T,System.Exception> Eval<T>(int length=1024);
```
#### Type parameters

<a name='Emik.Rhainterop.AST.Eval_T_(int).T'></a>

`T`

The type of the resulting type, [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') can be used much like `rhai::Dynamic` in Rust.
#### Parameters

<a name='Emik.Rhainterop.AST.Eval_T_(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The size of the internally allocated buffer.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".