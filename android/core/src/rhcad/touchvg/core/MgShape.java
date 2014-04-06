/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package rhcad.touchvg.core;

public class MgShape extends MgObject {
  private long swigCPtr;

  protected MgShape(long cPtr, boolean cMemoryOwn) {
    super(touchvgJNI.MgShape_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgShape obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        throw new UnsupportedOperationException("C++ destructor does not have public access");
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public static int Type() {
    return touchvgJNI.MgShape_Type();
  }

  public MgShape cloneShape() {
    long cPtr = touchvgJNI.MgShape_cloneShape(swigCPtr, this);
    return (cPtr == 0) ? null : new MgShape(cPtr, false);
  }

  public GiContext context() {
    return new GiContext(touchvgJNI.MgShape_context(swigCPtr, this), false);
  }

  public void setContext(GiContext ctx, int mask) {
    touchvgJNI.MgShape_setContext__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, mask);
  }

  public void setContext(GiContext ctx) {
    touchvgJNI.MgShape_setContext__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx);
  }

  public MgBaseShape shape() {
    long cPtr = touchvgJNI.MgShape_shape(swigCPtr, this);
    return (cPtr == 0) ? null : new MgBaseShape(cPtr, false);
  }

  public MgBaseShape shapec() {
    long cPtr = touchvgJNI.MgShape_shapec(swigCPtr, this);
    return (cPtr == 0) ? null : new MgBaseShape(cPtr, false);
  }

  public boolean hasFillColor() {
    return touchvgJNI.MgShape_hasFillColor(swigCPtr, this);
  }

  public boolean draw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    return touchvgJNI.MgShape_draw(swigCPtr, this, mode, GiGraphics.getCPtr(gs), gs, GiContext.getCPtr(ctx), ctx, segment);
  }

  public boolean save(MgStorage s) {
    return touchvgJNI.MgShape_save(swigCPtr, this, MgStorage.getCPtr(s), s);
  }

  public boolean load(MgShapeFactory factory, MgStorage s) {
    return touchvgJNI.MgShape_load(swigCPtr, this, MgShapeFactory.getCPtr(factory), factory, MgStorage.getCPtr(s), s);
  }

  public int getID() {
    return touchvgJNI.MgShape_getID(swigCPtr, this);
  }

  public MgShapes getParent() {
    long cPtr = touchvgJNI.MgShape_getParent(swigCPtr, this);
    return (cPtr == 0) ? null : new MgShapes(cPtr, false);
  }

  public void setParent(MgShapes p, int sid) {
    touchvgJNI.MgShape_setParent(swigCPtr, this, MgShapes.getCPtr(p), p, sid);
  }

  public int getTag() {
    return touchvgJNI.MgShape_getTag(swigCPtr, this);
  }

  public void setTag(int tag) {
    touchvgJNI.MgShape_setTag(swigCPtr, this, tag);
  }

  public void copy(MgObject src) {
    touchvgJNI.MgShape_copy(swigCPtr, this, MgObject.getCPtr(src), src);
  }

  public boolean equals(MgObject src) {
    return touchvgJNI.MgShape_equals(swigCPtr, this, MgObject.getCPtr(src), src);
  }

  public boolean isKindOf(int type) {
    return touchvgJNI.MgShape_isKindOf(swigCPtr, this, type);
  }

}
