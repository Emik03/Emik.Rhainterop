### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop').[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')

## RhaiException.From(Exception) Method

Factory method.

```csharp
public static Emik.Rhainterop.RhaiException From(System.Exception exception);
```
#### Parameters

<a name='Emik.Rhainterop.RhaiException.From(System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') to pass.

#### Returns
[RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException')  
The new [RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException'), or [exception](RhaiException.From(Exception).md#Emik.Rhainterop.RhaiException.From(System.Exception).exception 'Emik.Rhainterop.RhaiException.From(System.Exception).exception') if already a [RhaiException](RhaiException.md 'Emik.Rhainterop.RhaiException').