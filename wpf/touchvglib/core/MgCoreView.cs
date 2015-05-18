//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace touchvg.core {

public class MgCoreView : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgCoreView(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgCoreView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCoreView() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCoreView(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static MgCoreView fromHandle(int h) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgCoreView_fromHandle(h);
    MgCoreView ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgCoreView(cPtr, false);
    return ret;
  }

  public int toHandle() {
    int ret = touchvgPINVOKE.MgCoreView_toHandle(swigCPtr);
    return ret;
  }

  public virtual void release() {
    touchvgPINVOKE.MgCoreView_release(swigCPtr);
  }

  public virtual void addRef() {
    touchvgPINVOKE.MgCoreView_addRef(swigCPtr);
  }

  public virtual int viewDataHandle() {
    int ret = touchvgPINVOKE.MgCoreView_viewDataHandle(swigCPtr);
    return ret;
  }

  public virtual int viewAdapterHandle() {
    int ret = touchvgPINVOKE.MgCoreView_viewAdapterHandle(swigCPtr);
    return ret;
  }

  public virtual int backDoc() {
    int ret = touchvgPINVOKE.MgCoreView_backDoc(swigCPtr);
    return ret;
  }

  public virtual int backShapes() {
    int ret = touchvgPINVOKE.MgCoreView_backShapes(swigCPtr);
    return ret;
  }

  public virtual int acquireFrontDoc() {
    int ret = touchvgPINVOKE.MgCoreView_acquireFrontDoc__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual int acquireFrontDoc(int playh) {
    int ret = touchvgPINVOKE.MgCoreView_acquireFrontDoc__SWIG_1(swigCPtr, playh);
    return ret;
  }

  public static void releaseDoc(int doc) {
    touchvgPINVOKE.MgCoreView_releaseDoc(doc);
  }

  public virtual int acquireDynamicShapes() {
    int ret = touchvgPINVOKE.MgCoreView_acquireDynamicShapes(swigCPtr);
    return ret;
  }

  public static void releaseShapes(int shapes) {
    touchvgPINVOKE.MgCoreView_releaseShapes(shapes);
  }

  public virtual bool isDrawing() {
    bool ret = touchvgPINVOKE.MgCoreView_isDrawing(swigCPtr);
    return ret;
  }

  public virtual bool isZooming() {
    bool ret = touchvgPINVOKE.MgCoreView_isZooming(swigCPtr);
    return ret;
  }

  public virtual bool isStopping() {
    bool ret = touchvgPINVOKE.MgCoreView_isStopping(swigCPtr);
    return ret;
  }

  public virtual int stopDrawing(bool stop) {
    int ret = touchvgPINVOKE.MgCoreView_stopDrawing__SWIG_0(swigCPtr, stop);
    return ret;
  }

  public virtual int stopDrawing() {
    int ret = touchvgPINVOKE.MgCoreView_stopDrawing__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool isUndoRecording() {
    bool ret = touchvgPINVOKE.MgCoreView_isUndoRecording(swigCPtr);
    return ret;
  }

  public virtual bool isRecording() {
    bool ret = touchvgPINVOKE.MgCoreView_isRecording(swigCPtr);
    return ret;
  }

  public virtual bool isPlaying() {
    bool ret = touchvgPINVOKE.MgCoreView_isPlaying(swigCPtr);
    return ret;
  }

  public virtual bool isPaused() {
    bool ret = touchvgPINVOKE.MgCoreView_isPaused(swigCPtr);
    return ret;
  }

  public virtual int getRecordTick(bool forUndo, int curTick) {
    int ret = touchvgPINVOKE.MgCoreView_getRecordTick(swigCPtr, forUndo, curTick);
    return ret;
  }

  public virtual bool isUndoLoading() {
    bool ret = touchvgPINVOKE.MgCoreView_isUndoLoading(swigCPtr);
    return ret;
  }

  public virtual bool canUndo() {
    bool ret = touchvgPINVOKE.MgCoreView_canUndo(swigCPtr);
    return ret;
  }

  public virtual bool canRedo() {
    bool ret = touchvgPINVOKE.MgCoreView_canRedo(swigCPtr);
    return ret;
  }

  public virtual int getRedoIndex() {
    int ret = touchvgPINVOKE.MgCoreView_getRedoIndex(swigCPtr);
    return ret;
  }

  public virtual int getRedoCount() {
    int ret = touchvgPINVOKE.MgCoreView_getRedoCount(swigCPtr);
    return ret;
  }

  public int getPlayingTick(int curTick) {
    int ret = touchvgPINVOKE.MgCoreView_getPlayingTick(swigCPtr, curTick);
    return ret;
  }

  public virtual int getFrameTick() {
    int ret = touchvgPINVOKE.MgCoreView_getFrameTick(swigCPtr);
    return ret;
  }

  public virtual int getFrameFlags() {
    int ret = touchvgPINVOKE.MgCoreView_getFrameFlags(swigCPtr);
    return ret;
  }

  public virtual int getFrameIndex() {
    int ret = touchvgPINVOKE.MgCoreView_getFrameIndex(swigCPtr);
    return ret;
  }

  public virtual bool isPressDragging() {
    bool ret = touchvgPINVOKE.MgCoreView_isPressDragging(swigCPtr);
    return ret;
  }

  public virtual bool isDrawingCommand() {
    bool ret = touchvgPINVOKE.MgCoreView_isDrawingCommand(swigCPtr);
    return ret;
  }

  public virtual bool isCommand(string name) {
    bool ret = touchvgPINVOKE.MgCoreView_isCommand(swigCPtr, name);
    return ret;
  }

  public void getCommand(MgStringCallback c) {
    touchvgPINVOKE.MgCoreView_getCommand(swigCPtr, MgStringCallback.getCPtr(c));
  }

  public virtual bool setCommand(string name, string arg1) {
    bool ret = touchvgPINVOKE.MgCoreView_setCommand__SWIG_0(swigCPtr, name, arg1);
    return ret;
  }

  public virtual bool setCommand(string name) {
    bool ret = touchvgPINVOKE.MgCoreView_setCommand__SWIG_1(swigCPtr, name);
    return ret;
  }

  public virtual bool switchCommand() {
    bool ret = touchvgPINVOKE.MgCoreView_switchCommand(swigCPtr);
    return ret;
  }

  public virtual bool doContextAction(int action) {
    bool ret = touchvgPINVOKE.MgCoreView_doContextAction(swigCPtr, action);
    return ret;
  }

  public virtual void clearCachedData() {
    touchvgPINVOKE.MgCoreView_clearCachedData(swigCPtr);
  }

  public virtual int addShapesForTest(int n) {
    int ret = touchvgPINVOKE.MgCoreView_addShapesForTest__SWIG_0(swigCPtr, n);
    return ret;
  }

  public virtual int addShapesForTest() {
    int ret = touchvgPINVOKE.MgCoreView_addShapesForTest__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual int getShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getShapeCount__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual int getShapeCount(int doc) {
    int ret = touchvgPINVOKE.MgCoreView_getShapeCount__SWIG_1(swigCPtr, doc);
    return ret;
  }

  public virtual int getUnlockedShapeCount(int type) {
    int ret = touchvgPINVOKE.MgCoreView_getUnlockedShapeCount__SWIG_0(swigCPtr, type);
    return ret;
  }

  public virtual int getUnlockedShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getUnlockedShapeCount__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual int getVisibleShapeCount(int type) {
    int ret = touchvgPINVOKE.MgCoreView_getVisibleShapeCount__SWIG_0(swigCPtr, type);
    return ret;
  }

  public virtual int getVisibleShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getVisibleShapeCount__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual int getChangeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getChangeCount(swigCPtr);
    return ret;
  }

  public virtual int getDrawCount() {
    int ret = touchvgPINVOKE.MgCoreView_getDrawCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeType() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeType(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeID() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeID(swigCPtr);
    return ret;
  }

  public virtual int getSelectedHandle() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedHandle(swigCPtr);
    return ret;
  }

  public virtual void getSelectedShapeIDs(Ints ids) {
    touchvgPINVOKE.MgCoreView_getSelectedShapeIDs(swigCPtr, Ints.getCPtr(ids));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setSelectedShapeIDs(Ints ids) {
    touchvgPINVOKE.MgCoreView_setSelectedShapeIDs(swigCPtr, Ints.getCPtr(ids));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void clear() {
    touchvgPINVOKE.MgCoreView_clear(swigCPtr);
  }

  public virtual bool loadFromFile(string vgfile, bool readOnly) {
    bool ret = touchvgPINVOKE.MgCoreView_loadFromFile__SWIG_0(swigCPtr, vgfile, readOnly);
    return ret;
  }

  public virtual bool loadFromFile(string vgfile) {
    bool ret = touchvgPINVOKE.MgCoreView_loadFromFile__SWIG_1(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool saveToFile(int doc, string vgfile, bool pretty) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_0(swigCPtr, doc, vgfile, pretty);
    return ret;
  }

  public virtual bool saveToFile(int doc, string vgfile) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_1(swigCPtr, doc, vgfile);
    return ret;
  }

  public bool saveToFile(string vgfile, bool pretty) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_2(swigCPtr, vgfile, pretty);
    return ret;
  }

  public bool saveToFile(string vgfile) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_3(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool loadShapes(MgStorage s, bool readOnly) {
    bool ret = touchvgPINVOKE.MgCoreView_loadShapes__SWIG_0(swigCPtr, MgStorage.getCPtr(s), readOnly);
    return ret;
  }

  public virtual bool loadShapes(MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_loadShapes__SWIG_1(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public virtual bool saveShapes(int doc, MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_saveShapes__SWIG_0(swigCPtr, doc, MgStorage.getCPtr(s));
    return ret;
  }

  public bool saveShapes(MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_saveShapes__SWIG_1(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public void getContent(int doc, MgStringCallback c) {
    touchvgPINVOKE.MgCoreView_getContent__SWIG_0(swigCPtr, doc, MgStringCallback.getCPtr(c));
  }

  public void getContent(MgStringCallback c) {
    touchvgPINVOKE.MgCoreView_getContent__SWIG_1(swigCPtr, MgStringCallback.getCPtr(c));
  }

  public virtual void freeContent() {
    touchvgPINVOKE.MgCoreView_freeContent(swigCPtr);
  }

  public virtual bool setContent(string content, bool readOnly) {
    bool ret = touchvgPINVOKE.MgCoreView_setContent__SWIG_0(swigCPtr, content, readOnly);
    return ret;
  }

  public virtual bool setContent(string content) {
    bool ret = touchvgPINVOKE.MgCoreView_setContent__SWIG_1(swigCPtr, content);
    return ret;
  }

  public virtual bool zoomToInitial() {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToInitial(swigCPtr);
    return ret;
  }

  public virtual bool zoomToExtent(float margin) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToExtent__SWIG_0(swigCPtr, margin);
    return ret;
  }

  public virtual bool zoomToExtent() {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToExtent__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool zoomToModel(float x, float y, float w, float h, float margin) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToModel__SWIG_0(swigCPtr, x, y, w, h, margin);
    return ret;
  }

  public virtual bool zoomToModel(float x, float y, float w, float h) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToModel__SWIG_1(swigCPtr, x, y, w, h);
    return ret;
  }

  public virtual bool zoomPan(float dxPixel, float dyPixel, bool adjust) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomPan__SWIG_0(swigCPtr, dxPixel, dyPixel, adjust);
    return ret;
  }

  public virtual bool zoomPan(float dxPixel, float dyPixel) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomPan__SWIG_1(swigCPtr, dxPixel, dyPixel);
    return ret;
  }

  public virtual GiContext getContext(bool forChange) {
    GiContext ret = new GiContext(touchvgPINVOKE.MgCoreView_getContext(swigCPtr, forChange), false);
    return ret;
  }

  public virtual void setContext(int mask) {
    touchvgPINVOKE.MgCoreView_setContext__SWIG_0(swigCPtr, mask);
  }

  public virtual bool getShapeFlag(int sid, int bit) {
    bool ret = touchvgPINVOKE.MgCoreView_getShapeFlag(swigCPtr, sid, bit);
    return ret;
  }

  public virtual bool setShapeFlag(int sid, int bit, bool on) {
    bool ret = touchvgPINVOKE.MgCoreView_setShapeFlag(swigCPtr, sid, bit, on);
    return ret;
  }

  public virtual void setContext(GiContext ctx, int mask, int apply) {
    touchvgPINVOKE.MgCoreView_setContext__SWIG_1(swigCPtr, GiContext.getCPtr(ctx), mask, apply);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setContextEditing(bool editing) {
    touchvgPINVOKE.MgCoreView_setContextEditing(swigCPtr, editing);
  }

  public virtual int addImageShape(string name, float width, float height) {
    int ret = touchvgPINVOKE.MgCoreView_addImageShape__SWIG_0(swigCPtr, name, width, height);
    return ret;
  }

  public virtual int addImageShape(string name, float xc, float yc, float w, float h, int tag) {
    int ret = touchvgPINVOKE.MgCoreView_addImageShape__SWIG_1(swigCPtr, name, xc, yc, w, h, tag);
    return ret;
  }

  public virtual bool hasImageShape(int doc) {
    bool ret = touchvgPINVOKE.MgCoreView_hasImageShape(swigCPtr, doc);
    return ret;
  }

  public virtual bool getImageSize(Floats info, int sid) {
    bool ret = touchvgPINVOKE.MgCoreView_getImageSize(swigCPtr, Floats.getCPtr(info), sid);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int findShapeByImageID(int doc, string name) {
    int ret = touchvgPINVOKE.MgCoreView_findShapeByImageID(swigCPtr, doc, name);
    return ret;
  }

  public virtual int findShapeByTag(int doc, int tag) {
    int ret = touchvgPINVOKE.MgCoreView_findShapeByTag(swigCPtr, doc, tag);
    return ret;
  }

  public virtual int traverseImageShapes(int doc, MgFindImageCallback c) {
    int ret = touchvgPINVOKE.MgCoreView_traverseImageShapes(swigCPtr, doc, MgFindImageCallback.getCPtr(c));
    return ret;
  }

  public virtual bool getViewModelBox(Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getViewModelBox(swigCPtr, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getModelBox(Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getModelBox__SWIG_0(swigCPtr, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getModelBox(Floats box, int shapeId) {
    bool ret = touchvgPINVOKE.MgCoreView_getModelBox__SWIG_1(swigCPtr, Floats.getCPtr(box), shapeId);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getHandlePoint(Floats xy, int shapeId, int index) {
    bool ret = touchvgPINVOKE.MgCoreView_getHandlePoint(swigCPtr, Floats.getCPtr(xy), shapeId, index);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getDisplayExtent(Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getDisplayExtent__SWIG_0(swigCPtr, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getDisplayExtent(int doc, int gs, Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getDisplayExtent__SWIG_1(swigCPtr, doc, gs, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBoundingBox(Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getBoundingBox__SWIG_0(swigCPtr, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBoundingBox(Floats box, int shapeId) {
    bool ret = touchvgPINVOKE.MgCoreView_getBoundingBox__SWIG_1(swigCPtr, Floats.getCPtr(box), shapeId);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBoundingBox(int doc, int gs, Floats box, int shapeId) {
    bool ret = touchvgPINVOKE.MgCoreView_getBoundingBox__SWIG_2(swigCPtr, doc, gs, Floats.getCPtr(box), shapeId);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool displayToModel(Floats d) {
    bool ret = touchvgPINVOKE.MgCoreView_displayToModel(swigCPtr, Floats.getCPtr(d));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int importSVGPath(int shapes, int sid, string d) {
    int ret = touchvgPINVOKE.MgCoreView_importSVGPath(swigCPtr, shapes, sid, d);
    return ret;
  }

  public virtual int exportSVGPath(int shapes, int sid, string buf, int size) {
    int ret = touchvgPINVOKE.MgCoreView_exportSVGPath(swigCPtr, shapes, sid, buf, size);
    return ret;
  }

  public bool exportSVGPath2(MgStringCallback c, int shapes, int sid) {
    bool ret = touchvgPINVOKE.MgCoreView_exportSVGPath2(swigCPtr, MgStringCallback.getCPtr(c), shapes, sid);
    return ret;
  }

  public static readonly int kMgSquare = touchvgPINVOKE.MgCoreView_kMgSquare_get();
  public static readonly int kMgClosed = touchvgPINVOKE.MgCoreView_kMgClosed_get();
  public static readonly int kMgFixedLength = touchvgPINVOKE.MgCoreView_kMgFixedLength_get();
  public static readonly int kMgFixedSize = touchvgPINVOKE.MgCoreView_kMgFixedSize_get();
  public static readonly int kMgRotateDisnable = touchvgPINVOKE.MgCoreView_kMgRotateDisnable_get();
  public static readonly int kMgLocked = touchvgPINVOKE.MgCoreView_kMgLocked_get();
  public static readonly int kMgNoSnap = touchvgPINVOKE.MgCoreView_kMgNoSnap_get();
  public static readonly int kMgNoAction = touchvgPINVOKE.MgCoreView_kMgNoAction_get();
  public static readonly int kMgNoClone = touchvgPINVOKE.MgCoreView_kMgNoClone_get();
  public static readonly int kMgHideContent = touchvgPINVOKE.MgCoreView_kMgHideContent_get();
  public static readonly int kMgNoDel = touchvgPINVOKE.MgCoreView_kMgNoDel_get();
  public static readonly int kMgCanSelLocked = touchvgPINVOKE.MgCoreView_kMgCanSelLocked_get();
  public static readonly int kMgNotAddRel = touchvgPINVOKE.MgCoreView_kMgNotAddRel_get();
  public static readonly int kMgNotShowSnap = touchvgPINVOKE.MgCoreView_kMgNotShowSnap_get();
  public static readonly int kMgCanAddVertex = touchvgPINVOKE.MgCoreView_kMgCanAddVertex_get();

}

}
