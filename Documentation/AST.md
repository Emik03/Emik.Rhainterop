### [Emik.Rhainterop](Emik.Rhainterop.md 'Emik.Rhainterop')

## AST Class

Represents a key for a previously computed abstract syntax tree.

```csharp
public sealed class AST :
System.ICloneable,
System.IComparable,
System.IComparable<Emik.Rhainterop.AST>,
System.Collections.IComparer,
System.Collections.Generic.IComparer<Emik.Rhainterop.AST>,
System.IConvertible,
System.IDisposable,
System.IEquatable<Emik.Rhainterop.AST>,
System.Collections.IEqualityComparer,
System.Collections.Generic.IEqualityComparer<Emik.Rhainterop.AST>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AST

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[AST](AST.md 'Emik.Rhainterop.AST')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer'), [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[AST](AST.md 'Emik.Rhainterop.AST')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1'), [System.IConvertible](https://docs.microsoft.com/en-us/dotnet/api/System.IConvertible 'System.IConvertible'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[AST](AST.md 'Emik.Rhainterop.AST')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEqualityComparer 'System.Collections.IEqualityComparer'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[AST](AST.md 'Emik.Rhainterop.AST')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

### Remarks
  
This type implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to dispose the syntax tree when it is out of use.  
If this type isn't disposed, the abstract syntax tree will remain in memory for the rest of the session.

| Properties | |
| :--- | :--- |
| [Id](AST.Id.md 'Emik.Rhainterop.AST.Id') | Gets the key value used to get the [AST](AST.md 'Emik.Rhainterop.AST') that represents this in Rust. |

| Methods | |
| :--- | :--- |
| [~AST()](AST.Finalize.md 'Emik.Rhainterop.AST.~AST()') | Finalizes an instance of the [AST](AST.md 'Emik.Rhainterop.AST') class. |
| [Eval&lt;T&gt;(int)](AST.Eval{T}(Int32).md 'Emik.Rhainterop.AST.Eval<T>(int)') | `eval` Function. |
| [Eval&lt;T&gt;(Span&lt;byte&gt;)](AST.Eval{T}(Span{Byte}).md 'Emik.Rhainterop.AST.Eval<T>(System.Span<byte>)') | `eval` Function. |

| Operators | |
| :--- | :--- |
| [operator ==(AST, AST)](AST.op_Equality(AST,AST).md 'Emik.Rhainterop.AST.op_Equality(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if two [AST](AST.md 'Emik.Rhainterop.AST') instances are equal. |
| [operator &gt;(AST, AST)](AST.op_GreaterThan(AST,AST).md 'Emik.Rhainterop.AST.op_GreaterThan(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if one [AST](AST.md 'Emik.Rhainterop.AST') is greater than another. |
| [operator &gt;=(AST, AST)](AST.op_GreaterThanOrEqual(AST,AST).md 'Emik.Rhainterop.AST.op_GreaterThanOrEqual(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if one [AST](AST.md 'Emik.Rhainterop.AST') is greater or equal than another. |
| [implicit operator ulong(AST)](AST.UInt64(AST).md 'Emik.Rhainterop.AST.op_Implicit ulong(Emik.Rhainterop.AST)') | Implicitly calls [Id](AST.Id.md 'Emik.Rhainterop.AST.Id'). |
| [operator !=(AST, AST)](AST.op_Inequality(AST,AST).md 'Emik.Rhainterop.AST.op_Inequality(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if two [AST](AST.md 'Emik.Rhainterop.AST') instances are unequal. |
| [operator &lt;(AST, AST)](AST.op_LessThan(AST,AST).md 'Emik.Rhainterop.AST.op_LessThan(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if one [AST](AST.md 'Emik.Rhainterop.AST') is less than another. |
| [operator &lt;=(AST, AST)](AST.op_LessThanOrEqual(AST,AST).md 'Emik.Rhainterop.AST.op_LessThanOrEqual(Emik.Rhainterop.AST, Emik.Rhainterop.AST)') | Determines if one [AST](AST.md 'Emik.Rhainterop.AST') is less or equal than another. |
