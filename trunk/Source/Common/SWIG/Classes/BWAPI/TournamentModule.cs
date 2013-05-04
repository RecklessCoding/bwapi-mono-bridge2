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

public partial class TournamentModule : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TournamentModule(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TournamentModule obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TournamentModule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_TournamentModule(swigCPtr);
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
    if (obj is TournamentModule)
      equal = (((TournamentModule)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(TournamentModule obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(TournamentModule obj1, TournamentModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(TournamentModule obj1, TournamentModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public TournamentModule() : this(bwapiPINVOKE.new_TournamentModule(), true) {
  }

  public virtual bool onAction(int actionType, SWIGTYPE_p_void parameter) {
    bool ret = bwapiPINVOKE.TournamentModule_onAction__SWIG_0(swigCPtr, actionType, SWIGTYPE_p_void.getCPtr(parameter));
    return ret;
  }

  public virtual bool onAction(int actionType) {
    bool ret = bwapiPINVOKE.TournamentModule_onAction__SWIG_1(swigCPtr, actionType);
    return ret;
  }

  public virtual void onFirstAdvertisement() {
    bwapiPINVOKE.TournamentModule_onFirstAdvertisement(swigCPtr);
  }

}

}
