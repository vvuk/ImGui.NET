using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawCmd
    {
        public uint ElemCount;
        public float4 ClipRect;
        public IntPtr TextureId;
        public uint VtxOffset;
        public uint IdxOffset;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
    public unsafe partial struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
        public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new ImDrawCmdPtr(nativePtr);
        public ref uint ElemCount => ref UnsafeUtilityEx.AsRef<uint>(&NativePtr->ElemCount);
        public ref float4 ClipRect => ref UnsafeUtilityEx.AsRef<float4>(&NativePtr->ClipRect);
        public ref IntPtr TextureId => ref UnsafeUtilityEx.AsRef<IntPtr>(&NativePtr->TextureId);
        public ref uint VtxOffset => ref UnsafeUtilityEx.AsRef<uint>(&NativePtr->VtxOffset);
        public ref uint IdxOffset => ref UnsafeUtilityEx.AsRef<uint>(&NativePtr->IdxOffset);
        public ref IntPtr UserCallback => ref UnsafeUtilityEx.AsRef<IntPtr>(&NativePtr->UserCallback);
        public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImDrawCmd_destroy(NativePtr);
        }
    }
}
