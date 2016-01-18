#define MCG_WINRT_SUPPORTED
using Mcg.System;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;


// -----------------------------------------------------------------------------------------------------------
// 
// WARNING: THIS SOURCE FILE IS FOR 32-BIT BUILDS ONLY!
// 
// MCG GENERATED CODE
// 
// This C# source file is generated by MCG and is added into the application at compile time to support interop features.
// 
// It has three primary components:
// 
// 1. Public type definitions with interop implementation used by this application including WinRT & COM data structures and P/Invokes.
// 
// 2. The 'McgInterop' class containing marshaling code that acts as a bridge from managed code to native code.
// 
// 3. The 'McgNative' class containing marshaling code and native type definitions that call into native code and are called by native code.
// 
// -----------------------------------------------------------------------------------------------------------
// 
// warning CS0067: The event 'event' is never used
#pragma warning disable 67
// warning CS0169: The field 'field' is never used
#pragma warning disable 169
// warning CS0649: Field 'field' is never assigned to, and will always have its default value 0
#pragma warning disable 649
// warning CS1591: Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// warning CS0108 'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.
#pragma warning disable 108
// warning CS0114 'member1' hides inherited member 'member2'.  To make the current method override that implementation, add the override keyword. Otherwise add the new keyword.
#pragma warning disable 114
// warning CS0659 'type' overrides Object.Equals but does not override GetHashCode.
#pragma warning disable 659
// warning CS0465 Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?
#pragma warning disable 465
// warning CS0028 'function declaration' has the wrong signature to be an entry point
#pragma warning disable 28
// warning CS0162 Unreachable code Detected
#pragma warning disable 162
// warning CS0628 new protected member declared in sealed class
#pragma warning disable 628

namespace System.Runtime.InteropServices.WindowsRuntime
{
	// Specialization: GetMany,string
	public static class ListToVectorAdapter 
	{
	    // T GetAt(uint index)
	    public static T GetAt<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        uint index)
	    {
	        EnsureIndexInt32(index);

	        try
	        {
	            return _this[(int)index];
	        }
	        catch (System.ArgumentOutOfRangeException ex)
	        {
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // uint Size { get }
	    public static uint get_Size<T>(
	        global::System.Collections.Generic.IList<T> _this
	        )
	    {
	        return (uint)_this.Count;
	    }

	    // IVectorView<T> GetView()
	    public static global::System.Collections.Generic.IReadOnlyList<T> GetView<T>(
	        global::System.Collections.Generic.IList<T> _this
	        )
	    {
	        //Contract.Assert(_this != null);

	        // Note: This list is not really read-only - you could QI for a modifiable
	        // list.  We gain some perf by doing this.  We believe this is acceptable.
	        global::System.Collections.Generic.IReadOnlyList<T> roList = _this as global::System.Collections.Generic.IReadOnlyList<T>;
	        if (roList == null)
	        {
	            roList = new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(_this);
	        }
	        return roList;
	    }

	    // bool IndexOf(T value, out uint index)
	    public static bool IndexOf<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        T value,
	        out uint index)
	    {
	        int ind = _this.IndexOf(value);

	        if (-1 == ind)
	        {
	            index = 0;
	            return false;
	        }

	        index = (uint)ind;
	        return true;
	    }

	    // void SetAt(uint index, T value)
	    public static void SetAt<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        uint index,
	        T value)
	    {
	        EnsureIndexInt32(index);

	        try
	        {
	            _this[(int)index] = value;
	        }
	        catch (System.ArgumentOutOfRangeException ex)
	        {
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // void InsertAt(uint index, T value)
	    public static void InsertAt<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        uint index,
	        T value)
	    {

	        // Inserting at an index one past the end of the list is equivalent to appending
	        // so we need to ensure that we're within (0, count + 1).
	        EnsureIndexInt32(index);

	        try
	        {
	            _this.Insert((int)index, value);
	        }
	        catch (System.ArgumentOutOfRangeException ex)
	        {
	            // Change error code to match what WinRT expects
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // void RemoveAt(uint index)
	    public static void RemoveAt<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        uint index)
	    {
	        EnsureIndexInt32(index);

	        try
	        {
	            _this.RemoveAt((int)index);
	        }
	        catch (System.ArgumentOutOfRangeException ex)
	        {
	            // Change error code to match what WinRT expects
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // void Append(T value)
	    public static void Append<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        T value)
	    {
	        _this.Add(value);
	    }

	    // void RemoveAtEnd()
	    public static void RemoveAtEnd<T>(
	        global::System.Collections.Generic.IList<T> _this)
	    {
	        uint size = (uint)_this.Count;
	        
	        if (size == 0)
	        {
	            InvalidOperationException ex = new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_CannotRemoveFromEmptyCollection));

	            // Change error code to match what WinRT expects
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw ex;
	        }

	        RemoveAt<T>(_this, size - 1);
	    }

	    // void Clear()
	    public static void Clear<T>(
	        global::System.Collections.Generic.IList<T> _this)
	    {
	        _this.Clear();
	    }

	    // uint GetMany(uint startIndex, T[] items)
	    public static uint GetMany<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        uint startIndex,
	        T[] items)
	    {
	        return GetManyHelper<T>(_this, startIndex, items);
	    }

	    // @TODO - Weird shared CCW support that I don't really understand. Get rid of this.
	    public static uint GetMany_string(
	        global::System.Collections.Generic.IList<string> _this,
	        uint startIndex,
	        string[] items)
	    {
	        return GetManyHelper<string>(_this, startIndex, items);
	    }

	    // void ReplaceAll(T[] items)
	    public static void ReplaceAll<T>(
	        global::System.Collections.Generic.IList<T> _this,
	        T[] items)
	    {
	        _this.Clear();

	        if (items != null)
	        {
	            for (int i = 0; i < items.Length; i ++)
	            {
	                _this.Add(items[i]);
	            }
	        }
	    }

	    // Helpers:

	    private static void EnsureIndexInt32(uint index)
	    {
	        // We use '<=' and not '<' becasue Int32.MaxValue == index would imply
	        // that Size > Int32.MaxValue:
	        if (((uint)System.Int32.MaxValue) <= index)
	        {
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index_BOUNDS();
	        }
	    }

	    private static uint GetManyHelper<T>(global::System.Collections.Generic.IList<T> sourceList, uint startIndex, T[] items)
	    {
	        int count = sourceList.Count;

	        // Calling GetMany with a start index equal to the size of the list should always
	        // return 0 elements, regardless of the input item size
	        if (startIndex == count)
	        {
	            return 0;
	        }

	        if(startIndex > (uint)count)
	        {
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index_BOUNDS();
	        }

	        EnsureIndexInt32(startIndex);

	        if (items == null)
	        {
	            return 0;
	        }

	        uint itemCount = global::System.Math.Min((uint)items.Length, (uint) count - startIndex);
	        
	        for (uint i = 0; i < itemCount; ++i)
	        {
	            items[i] = sourceList[(int)(i + startIndex)];
	        }

	        return itemCount;
	    }
	}

	public static class EnumerableToIterableAdapter 
	{
	    public static global::Windows.Foundation.Collections.IIterator<T> First<T>(global::System.Collections.Generic.IEnumerable<T> _this)
	    {
	        return new EnumeratorToIteratorAdapter<T>(_this.GetEnumerator());
	    }
	}

	public sealed class IteratorToEnumeratorAdapter<T> : global::System.Collections.Generic.IEnumerator<T>
	{
	    private global::Windows.Foundation.Collections.IIterator<T> m_iterator;
	    private bool m_hadCurrent;
	    private T m_current;
	    private bool m_isInitialized;

	    internal IteratorToEnumeratorAdapter(global::Windows.Foundation.Collections.IIterator<T> iterator)
	    {
	        //Contract.Requires(iterator != null);
	        m_iterator = iterator;
	        m_hadCurrent = true;
	        m_isInitialized = false;
	    }

	    public T Current
	    {
	        get
	        {
	            // The enumerator has not been advanced to the first element yet.
	            if (!m_isInitialized)
	            {
	                throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumNotStarted));
	            }

	            // The enumerator has reached the end of the collection
	            if (!m_hadCurrent)
	            {
	                throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumEnded));
	            }
	            
	            return m_current;
	        }
	    }

	    object global::System.Collections.IEnumerator.Current
	    {
	        get
	        {
	            // The enumerator has not been advanced to the first element yet.
	            if (!m_isInitialized)
	            {
	                throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumNotStarted));
	            }
	            
	            // The enumerator has reached the end of the collection
	            if (!m_hadCurrent)
	            {
	                throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumEnded));
	            }
	            
	            return m_current;
	        }
	    }
	    
	    public bool MoveNext()
	    {
	        // If we've passed the end of the iteration, IEnumerable<T> should return false, while
	        // IIterable will fail the interface call
	        if (!m_hadCurrent)
	        {
	            return false;
	        }

	        // IIterators start at index 0, rather than -1.  If this is the first call, we need to just
	        // check HasCurrent rather than actually moving to the next element
	        try
	        {
	            if (!m_isInitialized)
	            {
	                m_hadCurrent = m_iterator.get_HasCurrent();
	                m_isInitialized = true;
	            }
	            else
	            {
	                m_hadCurrent = m_iterator.MoveNext();
	            }

	            // We want to save away the current value for two reasons:
	            //  1. Accessing .Current is cheap on other iterators, so having it be a property which is a
	            //     simple field access preserves the expected performance characteristics (as opposed to
	            //     triggering a COM call every time the property is accessed)
	            //
	            //  2. This allows us to preserve the same semantics as generic collection iteration when iterating
	            //     beyond the end of the collection - namely that Current continues to return the last value
	            //     of the collection
	            if (m_hadCurrent)
	            {
	                m_current = m_iterator.get_Current();
	            }
	        }
	        catch (System.Exception ex)
	        {
	            // Translate E_CHANGED_STATE into an InvalidOperationException for an updated enumeration
	            if (global::McgInterop.McgHelpers.__HResults.E_CHANGED_STATE == ex.HResult)
	            {
	                throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumFailedVersion));
	            }

	            throw;
	        }

	        return m_hadCurrent;
	    }

	    public void Reset()
	    {
	        throw new NotSupportedException();
	    }

	    public void Dispose()
	    {
	    }
	}


	// Specialization: GetMany,string
	public static class ReadOnlyListToVectorViewAdapter 
	{
	    // T GetAt(uint index)
	    public static T GetAt<T>(
	        global::System.Collections.Generic.IReadOnlyList<T> _this,
	        uint index)
	    {
	        EnsureIndexInt32(index);

	        try
	        {
	            return _this[(int)index];
	        }
	        catch (System.ArgumentOutOfRangeException ex)
	        {
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // uint Size { get }
	    public static uint get_Size<T>(global::System.Collections.Generic.IReadOnlyCollection<T> _this)
	    { 
	        return (uint)_this.Count;
	    }

	    // bool IndexOf(T value, out uint index)
	    public static bool IndexOf<T>(
	        global::System.Collections.Generic.IReadOnlyList<T> _this, 
	        T value, 
	        out uint index)
	    {
	        int max = _this.Count;

	        for (int i = 0; i < max; i++)
	        {
	            if (global::System.Runtime.InteropServices.McgMarshal.ComparerEquals<T>(value, _this[i]))
	            {
	                index = (uint) i;
	                return true;
	            }
	        }

	        index = 0;
	        return false;
	    }

	    // uint GetMany(uint startIndex, T[] items)
	    public static uint GetMany<T>(global::System.Collections.Generic.IReadOnlyList<T> _this, 
	        uint startIndex, 
	        T[] items)
	    {
	        return GetManyHelper<T>(_this, startIndex, items);
	    }

	    // @TODO - Weird shared CCW support that I don't really understand. Get rid of this.
	    public static uint GetMany_string(global::System.Collections.Generic.IReadOnlyList<string> _this,
	        uint startIndex,
	        string[] items)
	    {
	        return GetManyHelper<string>(_this, startIndex, items);
	    }

	    private static uint GetManyHelper<T>(global::System.Collections.Generic.IReadOnlyList<T> _this,
	        uint startIndex,
	        T[] items)
	    {
	        int count = _this.Count;

	        // REX spec says "calling GetMany with startIndex equal to the length of the vector 
	        // (last valid index + 1) and any specified capacity will succeed and return zero actual
	        // elements".
	        if (startIndex == count)
	            return 0;

	        if (startIndex > (uint)count)
	        {
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index_BOUNDS();
	        }

	        EnsureIndexInt32(startIndex);

	        if (items == null)
	        {
	            return 0;
	        }

	        uint itemCount = global::System.Math.Min((uint)items.Length, (uint)count - startIndex);

	        for (uint i = 0; i < itemCount; ++i)
	        {
	            items[i] = _this[(int)(i + startIndex)];
	        }

	        return itemCount;
	    }

	    #region Helpers

	    private static void EnsureIndexInt32(uint index)
	    {
	        // We use '<=' and not '<' because Int32.MaxValue == index would imply
	        // that Size > Int32.MaxValue:
	        if (((uint)System.Int32.MaxValue) <= index)
	        {
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index_BOUNDS();
	        }
	    }

	    #endregion Helpers
	}

	public static class ReadOnlyDictionaryToMapViewAdapter 
	{
	    // V Lookup(K key)
	    public static V Lookup<K, V>(global::System.Collections.Generic.IReadOnlyDictionary<K,V> _this, K key)
	    {
	        try
	        {
	            return _this[key];
	        }
	        catch (KeyNotFoundException ex)
	        {
	            // Change error code to match what WinRT expects
	            McgMarshal.SetExceptionErrorCode(ex, global::McgInterop.McgHelpers.__HResults.E_BOUNDS);
	            throw;
	        }
	    }

	    // uint Size { get }
	    public static uint get_Size<K,V>(global::System.Collections.Generic.IReadOnlyDictionary<K, V> _this)
	    {
	        return (uint)_this.Count;
	    }

	    // bool HasKey(K key)
	    public static bool HasKey<K, V>(
	        global::System.Collections.Generic.IReadOnlyDictionary<K,V> _this,
	        K key)
	    {
	        return _this.ContainsKey(key);
	    }

	    // void Split(out IReadOnlyDictionary<K, V> first, out IReadOnlyDictionary<K, V> second)
	    public static void Split<K, V>(global::System.Collections.Generic.IReadOnlyDictionary<K, V> _this,
	        out global::System.Collections.Generic.IReadOnlyDictionary<K, V> first,
	        out global::System.Collections.Generic.IReadOnlyDictionary<K, V> second)
	    {
	        if (_this.Count < 2)
	        {
	            first = null;
	            second = null;
	            return;
	        }

	        ConstantSplittableMap<K, V> splittableMap = _this as ConstantSplittableMap<K, V>;

	        if (splittableMap == null)
	            splittableMap = new ConstantSplittableMap<K, V>(_this);

	        splittableMap.Split(out first, out second);
	    }
	}

	// Note: One day we may make these return IReadOnlyCollection<T>
	public sealed class ReadOnlyDictionaryKeyCollection<TKey, TValue> : global::System.Collections.Generic.IEnumerable<TKey>
	{
	    private readonly global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary;

	    public ReadOnlyDictionaryKeyCollection(System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary)
	    {
	        if (dictionary == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_dictionary(); 

	        this.dictionary = dictionary;
	    }

	    /*
	    public void CopyTo(TKey[] array, int index)
	    {
	        if (array == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_array();
	        if (index < 0)
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index();
	        if (array.Length <= index && this.Count > 0)
	            throw new ArgumentException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_IndexOutOfArrayBounds));
	        if (array.Length - index < dictionary.Count)
	            throw new ArgumentException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_InsufficientSpaceToCopyCollection));

	        int i = index;
	        foreach (KeyValuePair<TKey, TValue> mapping in dictionary)
	        {
	            array[i++] = mapping.Key;
	        }
	    }
	        
	    public int Count {
	        get { return dictionary.Count; }
	    }

	    public bool Contains(TKey item)
	    {
	        return dictionary.ContainsKey(item);
	    }
	    */

	    global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	    {
	        return ((System.Collections.Generic.IEnumerable<TKey>)this).GetEnumerator();
	    }

	    public global::System.Collections.Generic.IEnumerator<TKey> GetEnumerator()
	    {
	        return new ReadOnlyDictionaryKeyEnumerator<TKey, TValue>(dictionary);
	    }
	}  // public class ReadOnlyDictionaryKeyCollection<TKey, TValue>


	internal sealed class ReadOnlyDictionaryKeyEnumerator<TKey, TValue> : global::System.Collections.Generic.IEnumerator<TKey>
	{
	    private readonly global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary;
	    private global::System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumeration;

	    public ReadOnlyDictionaryKeyEnumerator(System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary)
	    {
	        if (dictionary == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_dictionary(); 

	        this.dictionary = dictionary;
	        this.enumeration = dictionary.GetEnumerator();
	    }

	    void global::System.IDisposable.Dispose()
	    {
	        enumeration.Dispose();
	    }

	    public bool MoveNext()
	    {
	        return enumeration.MoveNext();
	    }

	    global::System.Object global::System.Collections.IEnumerator.Current
	    {
	        get { return ((System.Collections.Generic.IEnumerator<TKey>)this).Current; }
	    }

	    public TKey Current
	    {
	        get { return enumeration.Current.Key; }
	    }

	    public void Reset()
	    {
	        enumeration = dictionary.GetEnumerator();
	    }
	}  // class ReadOnlyDictionaryKeyEnumerator<TKey, TValue>


	internal sealed class ReadOnlyDictionaryValueCollection<TKey, TValue> : global::System.Collections.Generic.IEnumerable<TValue>
	{
	    private readonly global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary;

	    public ReadOnlyDictionaryValueCollection(System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary)
	    {
	        if (dictionary == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_dictionary(); 

	        this.dictionary = dictionary;
	    }

	    /*
	    public void CopyTo(TValue[] array, int index)
	    {
	        if (array == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_array();
	        if (index < 0)
	            throw global::McgInterop.Helpers.NewException_ArgumentOutOfRangeException_index();
	        if (array.Length <= index && this.Count > 0)
	            throw new ArgumentException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_IndexOutOfArrayBounds));
	        if (array.Length - index < dictionary.Count)
	            throw new ArgumentException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_InsufficientSpaceToCopyCollection));

	        int i = index;
	        foreach (KeyValuePair<TKey, TValue> mapping in dictionary)
	        {
	            array[i++] = mapping.Value;
	        }
	    }

	    public int Count {
	        get { return dictionary.Count; }
	    }

	    public bool Contains(TValue item)
	    {
	        EqualityComparer<TValue> comparer = EqualityComparer<TValue>.Default;
	        foreach (TValue value in this)
	            if (comparer.Equals(item, value))
	                return true;
	        return false;
	    }
	    */

	    global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	    {
	        return ((System.Collections.Generic.IEnumerable<TValue>)this).GetEnumerator();
	    }

	    public global::System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
	    {
	        return new ReadOnlyDictionaryValueEnumerator<TKey, TValue>(dictionary);
	    }
	}  // public class ReadOnlyDictionaryValueCollection<TKey, TValue>


	internal sealed class ReadOnlyDictionaryValueEnumerator<TKey, TValue> : global::System.Collections.Generic.IEnumerator<TValue>
	{
	    private readonly global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary;
	    private global::System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumeration;

	    public ReadOnlyDictionaryValueEnumerator(System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary)
	    {
	        if (dictionary == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_dictionary(); 

	        this.dictionary = dictionary;
	        this.enumeration = dictionary.GetEnumerator();
	    }

	    void global::System.IDisposable.Dispose()
	    {
	        enumeration.Dispose();
	    }

	    public bool MoveNext()
	    {
	        return enumeration.MoveNext();
	    }

	    global::System.Object global::System.Collections.IEnumerator.Current
	    {
	        get { return ((System.Collections.Generic.IEnumerator<TValue>)this).Current; }
	    }

	    public TValue Current
	    {
	        get { return enumeration.Current.Value; }
	    }

	    public void Reset()
	    {
	        enumeration = dictionary.GetEnumerator();
	    }
	}  // class ReadOnlyDictionaryValueEnumerator<TKey, TValue>


	internal sealed class ConstantSplittableMap<TKey, TValue> : global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, global::System.Collections.Generic.IComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
	{
	    // Comparing key only
	    public int Compare(global::System.Collections.Generic.KeyValuePair<TKey, TValue> x, global::System.Collections.Generic.KeyValuePair<TKey, TValue> y)
	    {
	        return global::System.Collections.Generic.Comparer<TKey>.Default.Compare(x.Key, y.Key);
	    }

	    private readonly global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] items;
	    private readonly int firstItemIndex;
	    private readonly int lastItemIndex;

	    internal ConstantSplittableMap(global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> data)
	    {
	        if (data == null)
	            throw global::McgInterop.Helpers.NewException_ArgumentNullException_data();

	        int count = data.Count;

	        this.lastItemIndex = count - 1;

	        items = new global::System.Collections.Generic.KeyValuePair<TKey, TValue>[count];

	        int i = 0;

	        foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> kv in data)
	        {
	            items[i++] = kv;
	        }

	        global::System.Array.Sort(items, 0, items.Length, this);
	    }

	    private ConstantSplittableMap(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] items, global::System.Int32 firstItemIndex, global::System.Int32 lastItemIndex)
	    {
	        this.items = items;
	        this.firstItemIndex = firstItemIndex;
	        this.lastItemIndex = lastItemIndex;
	    }
	    
	    public int Count
	    {
	        get
	        {
	            return lastItemIndex - firstItemIndex + 1;
	        }
	    }
	    
	    // [CLSCompliant(false)]
	    public uint Size
	    {
	        get
	        {
	            return (System.UInt32)(lastItemIndex - firstItemIndex + 1);
	        }
	    }
	    
	    public TValue Lookup(TKey key)
	    {
	        int index = Find(ref key);

	        if (index < 0)
	        {
	            throw new KeyNotFoundException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_KeyNotFound));
	        }

	        return items[index].Value;
	    }
	    
	    public bool HasKey(TKey key)
	    {
	        return Find(ref key) >= 0;
	    }

	    global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	    {
	        return this.GetEnumerator();
	    }

	    public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
	    {
	        return new IKeyValuePairEnumerator(this.items, this.firstItemIndex, this.lastItemIndex);
	    }

	    public void Split(out global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> firstPartition, out global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> secondPartition)
	    {
	        if (Count < 2)
	        {
	            firstPartition = null;
	            secondPartition = null;
	            return;
	        }

	        int pivot = (int)(((long)firstItemIndex + (long)lastItemIndex) / (long)2);

	        firstPartition = new ConstantSplittableMap<TKey, TValue>(items, firstItemIndex, pivot);
	        secondPartition = new ConstantSplittableMap<TKey, TValue>(items, pivot + 1, lastItemIndex);
	    }

	    //#region IReadOnlyDictionary members

	    int Find(ref TKey key)
	    {
	        global::System.Collections.Generic.KeyValuePair<TKey, TValue> searchKey = new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(key, default(TValue));
	        
	        return global::System.Array.BinarySearch(items, firstItemIndex, Count, searchKey, this);
	    }

	    public bool ContainsKey(TKey key)
	    {
	        return Find(ref key) >= 0;
	    }

	    public bool TryGetValue(TKey key, out TValue value)
	    {
	        int index = Find(ref key);

	        if (index < 0)
	        {
	            value = default(TValue);
	            return false;
	        }

	        value = items[index].Value;
	        return true;
	    }

	    public TValue this[TKey key]
	    {
	        get
	        {
	            return Lookup(key);
	        }
	    }

	    public global::System.Collections.Generic.IEnumerable<TKey> Keys
	    {
	        get
	        {
	            throw global::McgInterop.Helpers.NewException_NotImplementedException_NYI();
	        }
	    }

	    public global::System.Collections.Generic.IEnumerable<TValue> Values
	    {
	        get
	        {
	            throw global::McgInterop.Helpers.NewException_NotImplementedException_NYI();
	        }
	    }

	    //#endregion IReadOnlyDictionary members

	    #region IKeyValuePair Enumerator

	    internal class IKeyValuePairEnumerator : global::System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>
	    {
	        private global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] _array;
	        private int _start;
	        private int _end;
	        private int _current;

	        internal IKeyValuePairEnumerator(System.Collections.Generic.KeyValuePair<TKey, TValue>[] items, int first, int end)
	        {
	            //Contract.Requires(items != null);
	            //Contract.Requires(first >= 0);
	            //Contract.Requires(end >= 0);
	            //Contract.Requires(first < items.Length);
	            //Contract.Requires(end < items.Length);

	            _array = items;
	            _start = first;
	            _end = end;
	            _current = _start - 1;
	        }

	        public bool MoveNext()
	        {
	            if (_current < _end)
	            {
	                _current++;
	                return true;
	            }

	            return false;
	        }

	        public global::System.Collections.Generic.KeyValuePair<TKey, TValue> Current
	        {
	            get
	            {
	                if (_current < _start) throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumNotStarted));
	                if (_current > _end)   throw new InvalidOperationException(global::Mcg.System.SR.GetString(global::Mcg.System.SR.Excep_EnumEnded));
	                //return new CLRIKeyValuePairImpl<TKey, TValue>(ref _array[_current]);
	                return _array[_current];
	            }
	        }

	        object global::System.Collections.IEnumerator.Current
	        {
	            get
	            {
	                return Current;
	            }
	        }

	        void global::System.Collections.IEnumerator.Reset()
	        {
	            _current = _start - 1;
	        }

	        public void Dispose()
	        {
	        }
	    }

	    #endregion IKeyValuePair Enumerator

	}  // internal ConstantSplittableMap<TKey, TValue>
}

