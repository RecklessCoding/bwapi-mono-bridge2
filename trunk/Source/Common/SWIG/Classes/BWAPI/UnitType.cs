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

public partial class UnitType : Type {
  private HandleRef swigCPtr;

  internal UnitType(IntPtr cPtr, bool cMemoryOwn) : base(bwapiPINVOKE.UnitType_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitType() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitType(swigCPtr);
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
    if (obj is UnitType)
      equal = (((UnitType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitType obj1, UnitType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitType obj1, UnitType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitType() : this(bwapiPINVOKE.new_UnitType__SWIG_0(), true) {
  }

  public UnitType(int id) : this(bwapiPINVOKE.new_UnitType__SWIG_1(id), true) {
  }

  public string getName() {
    string ret = bwapiPINVOKE.UnitType_getName(swigCPtr);
    return ret;
  }

  public string c_str() {
    string ret = bwapiPINVOKE.UnitType_c_str(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bwapiPINVOKE.UnitType_getRace(swigCPtr), true);
    return ret;
  }

  public UnitTypeIntPair whatBuilds() {
    UnitTypeIntPair ret = new UnitTypeIntPair(bwapiPINVOKE.UnitType_whatBuilds(swigCPtr), true);
    return ret;
  }

  public UnitTypeIntMap requiredUnits() {
    UnitTypeIntMap ret = new UnitTypeIntMap(bwapiPINVOKE.UnitType_requiredUnits(swigCPtr), false);
    return ret;
  }

  public TechType requiredTech() {
    TechType ret = new TechType(bwapiPINVOKE.UnitType_requiredTech(swigCPtr), true);
    return ret;
  }

  public TechType cloakingTech() {
    TechType ret = new TechType(bwapiPINVOKE.UnitType_cloakingTech(swigCPtr), true);
    return ret;
  }

  public TechTypeSet abilities() {
    TechTypeSet ret = new TechTypeSet(bwapiPINVOKE.UnitType_abilities(swigCPtr), false);
    return ret;
  }

  public UpgradeTypeSet upgrades() {
    UpgradeTypeSet ret = new UpgradeTypeSet(bwapiPINVOKE.UnitType_upgrades(swigCPtr), false);
    return ret;
  }

  public UpgradeType armorUpgrade() {
    UpgradeType ret = new UpgradeType(bwapiPINVOKE.UnitType_armorUpgrade(swigCPtr), true);
    return ret;
  }

  public int maxHitPoints() {
    int ret = bwapiPINVOKE.UnitType_maxHitPoints(swigCPtr);
    return ret;
  }

  public int maxShields() {
    int ret = bwapiPINVOKE.UnitType_maxShields(swigCPtr);
    return ret;
  }

  public int maxEnergy() {
    int ret = bwapiPINVOKE.UnitType_maxEnergy(swigCPtr);
    return ret;
  }

  public int armor() {
    int ret = bwapiPINVOKE.UnitType_armor(swigCPtr);
    return ret;
  }

  public int mineralPrice() {
    int ret = bwapiPINVOKE.UnitType_mineralPrice(swigCPtr);
    return ret;
  }

  public int gasPrice() {
    int ret = bwapiPINVOKE.UnitType_gasPrice(swigCPtr);
    return ret;
  }

  public int buildTime() {
    int ret = bwapiPINVOKE.UnitType_buildTime(swigCPtr);
    return ret;
  }

  public int supplyRequired() {
    int ret = bwapiPINVOKE.UnitType_supplyRequired(swigCPtr);
    return ret;
  }

  public int supplyProvided() {
    int ret = bwapiPINVOKE.UnitType_supplyProvided(swigCPtr);
    return ret;
  }

  public int spaceRequired() {
    int ret = bwapiPINVOKE.UnitType_spaceRequired(swigCPtr);
    return ret;
  }

  public int spaceProvided() {
    int ret = bwapiPINVOKE.UnitType_spaceProvided(swigCPtr);
    return ret;
  }

  public int buildScore() {
    int ret = bwapiPINVOKE.UnitType_buildScore(swigCPtr);
    return ret;
  }

  public int destroyScore() {
    int ret = bwapiPINVOKE.UnitType_destroyScore(swigCPtr);
    return ret;
  }

  public UnitSizeType size() {
    UnitSizeType ret = new UnitSizeType(bwapiPINVOKE.UnitType_size(swigCPtr), true);
    return ret;
  }

  public int tileWidth() {
    int ret = bwapiPINVOKE.UnitType_tileWidth(swigCPtr);
    return ret;
  }

  public int tileHeight() {
    int ret = bwapiPINVOKE.UnitType_tileHeight(swigCPtr);
    return ret;
  }

  public int dimensionLeft() {
    int ret = bwapiPINVOKE.UnitType_dimensionLeft(swigCPtr);
    return ret;
  }

  public int dimensionUp() {
    int ret = bwapiPINVOKE.UnitType_dimensionUp(swigCPtr);
    return ret;
  }

  public int dimensionRight() {
    int ret = bwapiPINVOKE.UnitType_dimensionRight(swigCPtr);
    return ret;
  }

  public int dimensionDown() {
    int ret = bwapiPINVOKE.UnitType_dimensionDown(swigCPtr);
    return ret;
  }

  public int seekRange() {
    int ret = bwapiPINVOKE.UnitType_seekRange(swigCPtr);
    return ret;
  }

  public int sightRange() {
    int ret = bwapiPINVOKE.UnitType_sightRange(swigCPtr);
    return ret;
  }

  public WeaponType groundWeapon() {
    WeaponType ret = new WeaponType(bwapiPINVOKE.UnitType_groundWeapon(swigCPtr), true);
    return ret;
  }

  public int maxGroundHits() {
    int ret = bwapiPINVOKE.UnitType_maxGroundHits(swigCPtr);
    return ret;
  }

  public WeaponType airWeapon() {
    WeaponType ret = new WeaponType(bwapiPINVOKE.UnitType_airWeapon(swigCPtr), true);
    return ret;
  }

  public int maxAirHits() {
    int ret = bwapiPINVOKE.UnitType_maxAirHits(swigCPtr);
    return ret;
  }

  public double topSpeed() {
    double ret = bwapiPINVOKE.UnitType_topSpeed(swigCPtr);
    return ret;
  }

  public int acceleration() {
    int ret = bwapiPINVOKE.UnitType_acceleration(swigCPtr);
    return ret;
  }

  public int haltDistance() {
    int ret = bwapiPINVOKE.UnitType_haltDistance(swigCPtr);
    return ret;
  }

  public int turnRadius() {
    int ret = bwapiPINVOKE.UnitType_turnRadius(swigCPtr);
    return ret;
  }

  public bool canProduce() {
    bool ret = bwapiPINVOKE.UnitType_canProduce(swigCPtr);
    return ret;
  }

  public bool canAttack() {
    bool ret = bwapiPINVOKE.UnitType_canAttack(swigCPtr);
    return ret;
  }

  public bool canMove() {
    bool ret = bwapiPINVOKE.UnitType_canMove(swigCPtr);
    return ret;
  }

  public bool isFlyer() {
    bool ret = bwapiPINVOKE.UnitType_isFlyer(swigCPtr);
    return ret;
  }

  public bool regeneratesHP() {
    bool ret = bwapiPINVOKE.UnitType_regeneratesHP(swigCPtr);
    return ret;
  }

  public bool isSpellcaster() {
    bool ret = bwapiPINVOKE.UnitType_isSpellcaster(swigCPtr);
    return ret;
  }

  public bool hasPermanentCloak() {
    bool ret = bwapiPINVOKE.UnitType_hasPermanentCloak(swigCPtr);
    return ret;
  }

  public bool isInvincible() {
    bool ret = bwapiPINVOKE.UnitType_isInvincible(swigCPtr);
    return ret;
  }

  public bool isOrganic() {
    bool ret = bwapiPINVOKE.UnitType_isOrganic(swigCPtr);
    return ret;
  }

  public bool isMechanical() {
    bool ret = bwapiPINVOKE.UnitType_isMechanical(swigCPtr);
    return ret;
  }

  public bool isRobotic() {
    bool ret = bwapiPINVOKE.UnitType_isRobotic(swigCPtr);
    return ret;
  }

  public bool isDetector() {
    bool ret = bwapiPINVOKE.UnitType_isDetector(swigCPtr);
    return ret;
  }

  public bool isResourceContainer() {
    bool ret = bwapiPINVOKE.UnitType_isResourceContainer(swigCPtr);
    return ret;
  }

  public bool isResourceDepot() {
    bool ret = bwapiPINVOKE.UnitType_isResourceDepot(swigCPtr);
    return ret;
  }

  public bool isRefinery() {
    bool ret = bwapiPINVOKE.UnitType_isRefinery(swigCPtr);
    return ret;
  }

  public bool isWorker() {
    bool ret = bwapiPINVOKE.UnitType_isWorker(swigCPtr);
    return ret;
  }

  public bool requiresPsi() {
    bool ret = bwapiPINVOKE.UnitType_requiresPsi(swigCPtr);
    return ret;
  }

  public bool requiresCreep() {
    bool ret = bwapiPINVOKE.UnitType_requiresCreep(swigCPtr);
    return ret;
  }

  public bool isTwoUnitsInOneEgg() {
    bool ret = bwapiPINVOKE.UnitType_isTwoUnitsInOneEgg(swigCPtr);
    return ret;
  }

  public bool isBurrowable() {
    bool ret = bwapiPINVOKE.UnitType_isBurrowable(swigCPtr);
    return ret;
  }

  public bool isCloakable() {
    bool ret = bwapiPINVOKE.UnitType_isCloakable(swigCPtr);
    return ret;
  }

  public bool isBuilding() {
    bool ret = bwapiPINVOKE.UnitType_isBuilding(swigCPtr);
    return ret;
  }

  public bool isAddon() {
    bool ret = bwapiPINVOKE.UnitType_isAddon(swigCPtr);
    return ret;
  }

  public bool isFlyingBuilding() {
    bool ret = bwapiPINVOKE.UnitType_isFlyingBuilding(swigCPtr);
    return ret;
  }

  public bool isNeutral() {
    bool ret = bwapiPINVOKE.UnitType_isNeutral(swigCPtr);
    return ret;
  }

  public bool isHero() {
    bool ret = bwapiPINVOKE.UnitType_isHero(swigCPtr);
    return ret;
  }

  public bool isPowerup() {
    bool ret = bwapiPINVOKE.UnitType_isPowerup(swigCPtr);
    return ret;
  }

  public bool isBeacon() {
    bool ret = bwapiPINVOKE.UnitType_isBeacon(swigCPtr);
    return ret;
  }

  public bool isFlagBeacon() {
    bool ret = bwapiPINVOKE.UnitType_isFlagBeacon(swigCPtr);
    return ret;
  }

  public bool isSpecialBuilding() {
    bool ret = bwapiPINVOKE.UnitType_isSpecialBuilding(swigCPtr);
    return ret;
  }

  public bool isSpell() {
    bool ret = bwapiPINVOKE.UnitType_isSpell(swigCPtr);
    return ret;
  }

  public bool producesLarva() {
    bool ret = bwapiPINVOKE.UnitType_producesLarva(swigCPtr);
    return ret;
  }

  public bool isMineralField() {
    bool ret = bwapiPINVOKE.UnitType_isMineralField(swigCPtr);
    return ret;
  }

  public bool canBuildAddon() {
    bool ret = bwapiPINVOKE.UnitType_canBuildAddon(swigCPtr);
    return ret;
  }

}

}
