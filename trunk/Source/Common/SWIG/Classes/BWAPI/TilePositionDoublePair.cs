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

public partial class TilePositionDoublePair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionDoublePair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionDoublePair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionDoublePair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_TilePositionDoublePair(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is TilePositionDoublePair)
      equal = (((TilePositionDoublePair)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(TilePositionDoublePair obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(TilePositionDoublePair obj1, TilePositionDoublePair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(TilePositionDoublePair obj1, TilePositionDoublePair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public TilePositionDoublePair() : this(bwapiPINVOKE.new_TilePositionDoublePair__SWIG_0(), true) {
  }

  public TilePositionDoublePair(TilePosition t, double u) : this(bwapiPINVOKE.new_TilePositionDoublePair__SWIG_1(TilePosition.getCPtr(t), u), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public TilePositionDoublePair(TilePositionDoublePair p) : this(bwapiPINVOKE.new_TilePositionDoublePair__SWIG_2(TilePositionDoublePair.getCPtr(p)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public TilePosition first {
    set {
      bwapiPINVOKE.TilePositionDoublePair_first_set(swigCPtr, TilePosition.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.TilePositionDoublePair_first_get(swigCPtr);
      TilePosition ret = (cPtr == IntPtr.Zero) ? null : new TilePosition(cPtr, false);
      return ret;
    } 
  }

  public double second {
    set {
      bwapiPINVOKE.TilePositionDoublePair_second_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiPINVOKE.TilePositionDoublePair_second_get(swigCPtr);
      return ret;
    } 
  }

}

}
