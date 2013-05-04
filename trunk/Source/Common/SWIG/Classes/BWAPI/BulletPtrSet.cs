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

public partial class BulletPtrSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<Bullet>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BulletPtrSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BulletPtrSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BulletPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_BulletPtrSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<Bullet> Values {
    get {
      System.Collections.Generic.ICollection<Bullet> values = new System.Collections.Generic.List<Bullet>();
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
 
  public bool Contains(Bullet item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Bullet[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Bullet[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Bullet> keyList = new System.Collections.Generic.List<Bullet>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Bullet currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Bullet> System.Collections.Generic.IEnumerable<Bullet>.GetEnumerator() {
    return new BulletPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new BulletPtrSetEnumerator(this);
  }

  public BulletPtrSetEnumerator GetEnumerator() {
    return new BulletPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BulletPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Bullet>
  {
    private BulletPtrSet collectionRef;
    private System.Collections.Generic.IList<Bullet> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BulletPtrSetEnumerator(BulletPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Bullet>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Bullet Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( Bullet)currentObject;
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
        Bullet currentKey = keyCollection[currentIndex];
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
  

  public BulletPtrSet() : this(bwapiPINVOKE.new_BulletPtrSet__SWIG_0(), true) {
  }

  public BulletPtrSet(BulletPtrSet other) : this(bwapiPINVOKE.new_BulletPtrSet__SWIG_1(BulletPtrSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.BulletPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.BulletPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.BulletPtrSet_Clear(swigCPtr);
  }

  public Bullet getitem(Bullet key) {
    IntPtr cPtr = bwapiPINVOKE.BulletPtrSet_getitem(swigCPtr, Bullet.getCPtr(key));
    Bullet ret = (cPtr == IntPtr.Zero) ? null : new Bullet(cPtr, false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Bullet key) {
    bool ret = bwapiPINVOKE.BulletPtrSet_ContainsKey(swigCPtr, Bullet.getCPtr(key));
    return ret;
  }

  public void Add(Bullet key) {
    bwapiPINVOKE.BulletPtrSet_Add(swigCPtr, Bullet.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Bullet key) {
    bool ret = bwapiPINVOKE.BulletPtrSet_Remove(swigCPtr, Bullet.getCPtr(key));
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.BulletPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Bullet get_next_key(IntPtr swigiterator) {
    IntPtr cPtr = bwapiPINVOKE.BulletPtrSet_get_next_key(swigCPtr, swigiterator);
    Bullet ret = (cPtr == IntPtr.Zero) ? null : new Bullet(cPtr, false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
