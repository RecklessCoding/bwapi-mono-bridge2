/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWTA {

using System;
using System.Runtime.InteropServices;

class bwtaPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport(""+importdll+"", EntryPoint="SWIGRegisterExceptionCallbacks_bwta")]
    public static extern void SWIGRegisterExceptionCallbacks_bwta(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport(""+importdll+"", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_bwta")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_bwta(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_bwta(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_bwta(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(bwtaPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(bwtaPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport(""+importdll+"", EntryPoint="SWIGRegisterStringCallback_bwta")]
    public static extern void SWIGRegisterStringCallback_bwta(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_bwta(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static bwtaPINVOKE() {
  }


#if CLIENT
  private const string importdll = "bwapi-native.dll";
#else
  private const string importdll = "__Internal";
#endif 
  


  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getPosition")]
  public static extern IntPtr BaseLocation_getPosition(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getTilePosition")]
  public static extern IntPtr BaseLocation_getTilePosition(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getRegion")]
  public static extern IntPtr BaseLocation_getRegion(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_minerals")]
  public static extern int BaseLocation_minerals(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_gas")]
  public static extern int BaseLocation_gas(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getMinerals")]
  public static extern IntPtr BaseLocation_getMinerals(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getStaticMinerals")]
  public static extern IntPtr BaseLocation_getStaticMinerals(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getGeysers")]
  public static extern IntPtr BaseLocation_getGeysers(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getGroundDistance")]
  public static extern double BaseLocation_getGroundDistance(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_getAirDistance")]
  public static extern double BaseLocation_getAirDistance(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_isIsland")]
  public static extern bool BaseLocation_isIsland(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_isMineralOnly")]
  public static extern bool BaseLocation_isMineralOnly(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocation_isStartLocation")]
  public static extern bool BaseLocation_isStartLocation(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_BaseLocation")]
  public static extern void delete_BaseLocation(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Chokepoint_getRegions")]
  public static extern IntPtr Chokepoint_getRegions(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Chokepoint_getSides")]
  public static extern IntPtr Chokepoint_getSides(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Chokepoint_getCenter")]
  public static extern IntPtr Chokepoint_getCenter(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Chokepoint_getWidth")]
  public static extern double Chokepoint_getWidth(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_Chokepoint")]
  public static extern void delete_Chokepoint(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_Polygon__SWIG_0")]
  public static extern IntPtr new_Polygon__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_Polygon__SWIG_1")]
  public static extern IntPtr new_Polygon__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_getArea")]
  public static extern double Polygon_getArea(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_getPerimeter")]
  public static extern double Polygon_getPerimeter(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_getCenter")]
  public static extern IntPtr Polygon_getCenter(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_isInside")]
  public static extern bool Polygon_isInside(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_getNearestPoint")]
  public static extern IntPtr Polygon_getNearestPoint(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_getHoles")]
  public static extern IntPtr Polygon_getHoles(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_holes_set")]
  public static extern void Polygon_holes_set(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_holes_get")]
  public static extern IntPtr Polygon_holes_get(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_Polygon")]
  public static extern void delete_Polygon(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_getPolygon")]
  public static extern IntPtr Region_getPolygon(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_getCenter")]
  public static extern IntPtr Region_getCenter(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_getChokepoints")]
  public static extern IntPtr Region_getChokepoints(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_getBaseLocations")]
  public static extern IntPtr Region_getBaseLocations(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_isReachable")]
  public static extern bool Region_isReachable(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Region_getReachableRegions")]
  public static extern IntPtr Region_getReachableRegions(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_Region")]
  public static extern void delete_Region(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_readMap")]
  public static extern void readMap();

  [DllImport(""+importdll+"", EntryPoint="CSharp_analyze")]
  public static extern void analyze();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getRegions")]
  public static extern IntPtr getRegions();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getChokepoints")]
  public static extern IntPtr getChokepoints();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getBaseLocations")]
  public static extern IntPtr getBaseLocations();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getStartLocations")]
  public static extern IntPtr getStartLocations();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getUnwalkablePolygons")]
  public static extern IntPtr getUnwalkablePolygons();

  [DllImport(""+importdll+"", EntryPoint="CSharp_getStartLocation")]
  public static extern IntPtr getStartLocation(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getRegion__SWIG_0")]
  public static extern IntPtr getRegion__SWIG_0(int jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getRegion__SWIG_1")]
  public static extern IntPtr getRegion__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getRegion__SWIG_2")]
  public static extern IntPtr getRegion__SWIG_2(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestChokepoint__SWIG_0")]
  public static extern IntPtr getNearestChokepoint__SWIG_0(int jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestChokepoint__SWIG_1")]
  public static extern IntPtr getNearestChokepoint__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestChokepoint__SWIG_2")]
  public static extern IntPtr getNearestChokepoint__SWIG_2(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestBaseLocation__SWIG_0")]
  public static extern IntPtr getNearestBaseLocation__SWIG_0(int jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestBaseLocation__SWIG_1")]
  public static extern IntPtr getNearestBaseLocation__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestBaseLocation__SWIG_2")]
  public static extern IntPtr getNearestBaseLocation__SWIG_2(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestUnwalkablePolygon__SWIG_0")]
  public static extern IntPtr getNearestUnwalkablePolygon__SWIG_0(int jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestUnwalkablePolygon__SWIG_1")]
  public static extern IntPtr getNearestUnwalkablePolygon__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestUnwalkablePosition")]
  public static extern IntPtr getNearestUnwalkablePosition(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_isConnected__SWIG_0")]
  public static extern bool isConnected__SWIG_0(int jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport(""+importdll+"", EntryPoint="CSharp_isConnected__SWIG_1")]
  public static extern bool isConnected__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getGroundDistance")]
  public static extern double getGroundDistance(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getNearestTilePosition")]
  public static extern IntPtr getNearestTilePosition(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getGroundDistances")]
  public static extern IntPtr getGroundDistances(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getGroundDistanceMap")]
  public static extern void getGroundDistanceMap(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getGroundWalkDistanceMap")]
  public static extern void getGroundWalkDistanceMap(int jarg1, int jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getShortestPath__SWIG_0")]
  public static extern IntPtr getShortestPath__SWIG_0(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_getShortestPath__SWIG_1")]
  public static extern IntPtr getShortestPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RectangleArrayDouble__SWIG_0")]
  public static extern IntPtr new_RectangleArrayDouble__SWIG_0(uint jarg1, uint jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RectangleArrayDouble__SWIG_1")]
  public static extern IntPtr new_RectangleArrayDouble__SWIG_1(uint jarg1, uint jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RectangleArrayDouble__SWIG_2")]
  public static extern IntPtr new_RectangleArrayDouble__SWIG_2(uint jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RectangleArrayDouble__SWIG_3")]
  public static extern IntPtr new_RectangleArrayDouble__SWIG_3();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RectangleArrayDouble__SWIG_4")]
  public static extern IntPtr new_RectangleArrayDouble__SWIG_4(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_RectangleArrayDouble")]
  public static extern void delete_RectangleArrayDouble(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_getWidth")]
  public static extern uint RectangleArrayDouble_getWidth(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_getHeight")]
  public static extern uint RectangleArrayDouble_getHeight(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_getItem")]
  public static extern double RectangleArrayDouble_getItem(HandleRef jarg1, uint jarg2, uint jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_getItemSafe")]
  public static extern double RectangleArrayDouble_getItemSafe(HandleRef jarg1, uint jarg2, uint jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_setItem")]
  public static extern void RectangleArrayDouble_setItem(HandleRef jarg1, uint jarg2, uint jarg3, HandleRef jarg4);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_resize")]
  public static extern void RectangleArrayDouble_resize(HandleRef jarg1, uint jarg2, uint jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_printToFile")]
  public static extern void RectangleArrayDouble_printToFile(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_saveToFile")]
  public static extern void RectangleArrayDouble_saveToFile(HandleRef jarg1, string jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_setTo")]
  public static extern void RectangleArrayDouble_setTo(HandleRef jarg1, double jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RectangleArrayDouble_setBorderTo")]
  public static extern void RectangleArrayDouble_setBorderTo(HandleRef jarg1, double jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_BaseLocationPtrSet__SWIG_0")]
  public static extern IntPtr new_BaseLocationPtrSet__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_BaseLocationPtrSet__SWIG_1")]
  public static extern IntPtr new_BaseLocationPtrSet__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_size")]
  public static extern uint BaseLocationPtrSet_size(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_empty")]
  public static extern bool BaseLocationPtrSet_empty(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_Clear")]
  public static extern void BaseLocationPtrSet_Clear(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_getitem")]
  public static extern IntPtr BaseLocationPtrSet_getitem(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_ContainsKey")]
  public static extern bool BaseLocationPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_Add")]
  public static extern void BaseLocationPtrSet_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_Remove")]
  public static extern bool BaseLocationPtrSet_Remove(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_create_iterator_begin")]
  public static extern IntPtr BaseLocationPtrSet_create_iterator_begin(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_BaseLocationPtrSet_get_next_key")]
  public static extern IntPtr BaseLocationPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_BaseLocationPtrSet")]
  public static extern void delete_BaseLocationPtrSet(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RegionPtrSet__SWIG_0")]
  public static extern IntPtr new_RegionPtrSet__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RegionPtrSet__SWIG_1")]
  public static extern IntPtr new_RegionPtrSet__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_size")]
  public static extern uint RegionPtrSet_size(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_empty")]
  public static extern bool RegionPtrSet_empty(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_Clear")]
  public static extern void RegionPtrSet_Clear(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_getitem")]
  public static extern IntPtr RegionPtrSet_getitem(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_ContainsKey")]
  public static extern bool RegionPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_Add")]
  public static extern void RegionPtrSet_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_Remove")]
  public static extern bool RegionPtrSet_Remove(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_create_iterator_begin")]
  public static extern IntPtr RegionPtrSet_create_iterator_begin(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrSet_get_next_key")]
  public static extern IntPtr RegionPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_RegionPtrSet")]
  public static extern void delete_RegionPtrSet(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_ChokepointPtrSet__SWIG_0")]
  public static extern IntPtr new_ChokepointPtrSet__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_ChokepointPtrSet__SWIG_1")]
  public static extern IntPtr new_ChokepointPtrSet__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_size")]
  public static extern uint ChokepointPtrSet_size(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_empty")]
  public static extern bool ChokepointPtrSet_empty(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_Clear")]
  public static extern void ChokepointPtrSet_Clear(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_getitem")]
  public static extern IntPtr ChokepointPtrSet_getitem(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_ContainsKey")]
  public static extern bool ChokepointPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_Add")]
  public static extern void ChokepointPtrSet_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_Remove")]
  public static extern bool ChokepointPtrSet_Remove(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_create_iterator_begin")]
  public static extern IntPtr ChokepointPtrSet_create_iterator_begin(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_ChokepointPtrSet_get_next_key")]
  public static extern IntPtr ChokepointPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_ChokepointPtrSet")]
  public static extern void delete_ChokepointPtrSet(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_PolygonPtrSet__SWIG_0")]
  public static extern IntPtr new_PolygonPtrSet__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_PolygonPtrSet__SWIG_1")]
  public static extern IntPtr new_PolygonPtrSet__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_size")]
  public static extern uint PolygonPtrSet_size(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_empty")]
  public static extern bool PolygonPtrSet_empty(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_Clear")]
  public static extern void PolygonPtrSet_Clear(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_getitem")]
  public static extern IntPtr PolygonPtrSet_getitem(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_ContainsKey")]
  public static extern bool PolygonPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_Add")]
  public static extern void PolygonPtrSet_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_Remove")]
  public static extern bool PolygonPtrSet_Remove(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_create_iterator_begin")]
  public static extern IntPtr PolygonPtrSet_create_iterator_begin(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonPtrSet_get_next_key")]
  public static extern IntPtr PolygonPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_PolygonPtrSet")]
  public static extern void delete_PolygonPtrSet(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Clear")]
  public static extern void PolygonVector_Clear(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Add")]
  public static extern void PolygonVector_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_size")]
  public static extern uint PolygonVector_size(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_capacity")]
  public static extern uint PolygonVector_capacity(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_reserve")]
  public static extern void PolygonVector_reserve(HandleRef jarg1, uint jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_PolygonVector__SWIG_0")]
  public static extern IntPtr new_PolygonVector__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_PolygonVector__SWIG_1")]
  public static extern IntPtr new_PolygonVector__SWIG_1(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_PolygonVector__SWIG_2")]
  public static extern IntPtr new_PolygonVector__SWIG_2(int jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_getitemcopy")]
  public static extern IntPtr PolygonVector_getitemcopy(HandleRef jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_getitem")]
  public static extern IntPtr PolygonVector_getitem(HandleRef jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_setitem")]
  public static extern void PolygonVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_AddRange")]
  public static extern void PolygonVector_AddRange(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_GetRange")]
  public static extern IntPtr PolygonVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Insert")]
  public static extern void PolygonVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_InsertRange")]
  public static extern void PolygonVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_RemoveAt")]
  public static extern void PolygonVector_RemoveAt(HandleRef jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_RemoveRange")]
  public static extern void PolygonVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Repeat")]
  public static extern IntPtr PolygonVector_Repeat(HandleRef jarg1, int jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Reverse__SWIG_0")]
  public static extern void PolygonVector_Reverse__SWIG_0(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_Reverse__SWIG_1")]
  public static extern void PolygonVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_PolygonVector_SetRange")]
  public static extern void PolygonVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_PolygonVector")]
  public static extern void delete_PolygonVector(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RegionPtrRegionPtrPair__SWIG_0")]
  public static extern IntPtr new_RegionPtrRegionPtrPair__SWIG_0();

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RegionPtrRegionPtrPair__SWIG_1")]
  public static extern IntPtr new_RegionPtrRegionPtrPair__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_new_RegionPtrRegionPtrPair__SWIG_2")]
  public static extern IntPtr new_RegionPtrRegionPtrPair__SWIG_2(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrRegionPtrPair_first_set")]
  public static extern void RegionPtrRegionPtrPair_first_set(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrRegionPtrPair_first_get")]
  public static extern IntPtr RegionPtrRegionPtrPair_first_get(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrRegionPtrPair_second_set")]
  public static extern void RegionPtrRegionPtrPair_second_set(HandleRef jarg1, HandleRef jarg2);

  [DllImport(""+importdll+"", EntryPoint="CSharp_RegionPtrRegionPtrPair_second_get")]
  public static extern IntPtr RegionPtrRegionPtrPair_second_get(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_delete_RegionPtrRegionPtrPair")]
  public static extern void delete_RegionPtrRegionPtrPair(HandleRef jarg1);

  [DllImport(""+importdll+"", EntryPoint="CSharp_Polygon_SWIGUpcast")]
  public static extern IntPtr Polygon_SWIGUpcast(IntPtr jarg1);
}

}
