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

public partial class UpgradeType : Type {
  private HandleRef swigCPtr;

  internal UpgradeType(IntPtr cPtr, bool cMemoryOwn) : base(bwapiPINVOKE.UpgradeType_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UpgradeType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UpgradeType() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UpgradeType(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is UpgradeType)
      equal = (((UpgradeType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UpgradeType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UpgradeType obj1, UpgradeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UpgradeType obj1, UpgradeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UpgradeType() : this(bwapiPINVOKE.new_UpgradeType__SWIG_0(), true) {
  }

  public UpgradeType(int id) : this(bwapiPINVOKE.new_UpgradeType__SWIG_1(id), true) {
  }

  public string getName() {
    string ret = bwapiPINVOKE.UpgradeType_getName(swigCPtr);
    return ret;
  }

  public string c_str() {
    string ret = bwapiPINVOKE.UpgradeType_c_str(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bwapiPINVOKE.UpgradeType_getRace(swigCPtr), true);
    return ret;
  }

  public int mineralPrice(int level) {
    int ret = bwapiPINVOKE.UpgradeType_mineralPrice__SWIG_0(swigCPtr, level);
    return ret;
  }

  public int mineralPrice() {
    int ret = bwapiPINVOKE.UpgradeType_mineralPrice__SWIG_1(swigCPtr);
    return ret;
  }

  public int mineralPriceFactor() {
    int ret = bwapiPINVOKE.UpgradeType_mineralPriceFactor(swigCPtr);
    return ret;
  }

  public int gasPrice(int level) {
    int ret = bwapiPINVOKE.UpgradeType_gasPrice__SWIG_0(swigCPtr, level);
    return ret;
  }

  public int gasPrice() {
    int ret = bwapiPINVOKE.UpgradeType_gasPrice__SWIG_1(swigCPtr);
    return ret;
  }

  public int gasPriceFactor() {
    int ret = bwapiPINVOKE.UpgradeType_gasPriceFactor(swigCPtr);
    return ret;
  }

  public int upgradeTime(int level) {
    int ret = bwapiPINVOKE.UpgradeType_upgradeTime__SWIG_0(swigCPtr, level);
    return ret;
  }

  public int upgradeTime() {
    int ret = bwapiPINVOKE.UpgradeType_upgradeTime__SWIG_1(swigCPtr);
    return ret;
  }

  public int upgradeTimeFactor() {
    int ret = bwapiPINVOKE.UpgradeType_upgradeTimeFactor(swigCPtr);
    return ret;
  }

  public int maxRepeats() {
    int ret = bwapiPINVOKE.UpgradeType_maxRepeats(swigCPtr);
    return ret;
  }

  public UnitType whatUpgrades() {
    UnitType ret = new UnitType(bwapiPINVOKE.UpgradeType_whatUpgrades(swigCPtr), true);
    return ret;
  }

  public UnitType whatsRequired(int level) {
    UnitType ret = new UnitType(bwapiPINVOKE.UpgradeType_whatsRequired__SWIG_0(swigCPtr, level), true);
    return ret;
  }

  public UnitType whatsRequired() {
    UnitType ret = new UnitType(bwapiPINVOKE.UpgradeType_whatsRequired__SWIG_1(swigCPtr), true);
    return ret;
  }

  public UnitTypeSet whatUses() {
    UnitTypeSet ret = new UnitTypeSet(bwapiPINVOKE.UpgradeType_whatUses(swigCPtr), false);
    return ret;
  }

}

}
