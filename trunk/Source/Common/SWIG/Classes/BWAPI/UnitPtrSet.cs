/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class UnitPtrSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<Unit>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitPtrSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitPtrSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitPtrSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<Unit> Values {
    get {
      System.Collections.Generic.ICollection<Unit> values = new System.Collections.Generic.List<Unit>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(Unit item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Unit[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Unit[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Unit> keyList = new System.Collections.Generic.List<Unit>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Unit currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Unit> System.Collections.Generic.IEnumerable<Unit>.GetEnumerator() {
    return new UnitPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new UnitPtrSetEnumerator(this);
  }

  public UnitPtrSetEnumerator GetEnumerator() {
    return new UnitPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Unit>
  {
    private UnitPtrSet collectionRef;
    private System.Collections.Generic.IList<Unit> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnitPtrSetEnumerator(UnitPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Unit>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Unit Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( Unit)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        Unit currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public UnitPtrSet() : this(bwapiPINVOKE.new_UnitPtrSet__SWIG_0(), true) {
  }

  public UnitPtrSet(UnitPtrSet other) : this(bwapiPINVOKE.new_UnitPtrSet__SWIG_1(UnitPtrSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.UnitPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.UnitPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.UnitPtrSet_Clear(swigCPtr);
  }

  public Unit getitem(Unit key) {
    IntPtr cPtr = bwapiPINVOKE.UnitPtrSet_getitem(swigCPtr, Unit.getCPtr(key));
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Unit key) {
    bool ret = bwapiPINVOKE.UnitPtrSet_ContainsKey(swigCPtr, Unit.getCPtr(key));
    return ret;
  }

  public void Add(Unit key) {
    bwapiPINVOKE.UnitPtrSet_Add(swigCPtr, Unit.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Unit key) {
    bool ret = bwapiPINVOKE.UnitPtrSet_Remove(swigCPtr, Unit.getCPtr(key));
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.UnitPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Unit get_next_key(IntPtr swigiterator) {
    IntPtr cPtr = bwapiPINVOKE.UnitPtrSet_get_next_key(swigCPtr, swigiterator);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
