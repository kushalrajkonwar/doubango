/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class AudioResampler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AudioResampler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AudioResampler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AudioResampler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_AudioResampler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public AudioResampler(uint nInFreq, uint nOutFreq, uint nFrameDuration, uint nChannels, uint nQuality) : this(tinyWRAPPINVOKE.new_AudioResampler(nInFreq, nOutFreq, nFrameDuration, nChannels, nQuality), true) {
  }

  public bool isValid() {
    bool ret = tinyWRAPPINVOKE.AudioResampler_isValid(swigCPtr);
    return ret;
  }

  public uint getOutputRequiredSizeInShort() {
    uint ret = tinyWRAPPINVOKE.AudioResampler_getOutputRequiredSizeInShort(swigCPtr);
    return ret;
  }

  public uint getInputRequiredSizeInShort() {
    uint ret = tinyWRAPPINVOKE.AudioResampler_getInputRequiredSizeInShort(swigCPtr);
    return ret;
  }

  public uint process(byte[] pInData, uint nInSizeInBytes, byte[] pOutData, uint nOutSizeInBytes) {
    uint ret = tinyWRAPPINVOKE.AudioResampler_process(swigCPtr, pInData, nInSizeInBytes, pOutData, nOutSizeInBytes);
    return ret;
  }

}

}