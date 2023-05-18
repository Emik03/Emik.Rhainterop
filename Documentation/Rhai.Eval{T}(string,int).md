### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[Rhai](Rhai.md 'Emik.Rhainterop.Rhai')

## Rhai.Eval<T>(string, int) Method

`eval` Function.

```csharp
public static Emik.Results.Result<T,Emik.Rhainterop.RhaiException> Eval<T>(string? script, int length=1024)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Rhainterop.Rhai.Eval_T_(string,int).T'></a>

`T`

The type of the resulting type, [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') can be used much like `rhai::Dynamic` in Rust.
#### Parameters

<a name='Emik.Rhainterop.Rhai.Eval_T_(string,int).script'></a>

`script` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The script to execute.

<a name='Emik.Rhainterop.Rhai.Eval_T_(string,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The size of the internally allocated buffer.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[T](Rhai.Eval{T}(string,int).md#Emik.Rhainterop.Rhai.Eval_T_(string,int).T 'Emik.Rhainterop.Rhai.Eval<T>(string, int).T')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
The resulting type from the expression given, or a runtime error from Rhai.

### Remarks
  
Or "How to Shoot Yourself in the Foot even Easier".