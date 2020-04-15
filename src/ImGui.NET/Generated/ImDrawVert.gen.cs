using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawVert
    {
        public float2 pos;
        public float2 uv;
        public uint col;
    }
    public unsafe partial struct ImDrawVertPtr
    {
        public ImDrawVert* NativePtr { get; }
        public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
        public ImDrawVertPtr(IntPtr nativePtr) => NativePtr = (ImDrawVert*)nativePtr;
        public static implicit operator ImDrawVertPtr(ImDrawVert* nativePtr) => new ImDrawVertPtr(nativePtr);
        public static implicit operator ImDrawVert* (ImDrawVertPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawVertPtr(IntPtr nativePtr) => new ImDrawVertPtr(nativePtr);
        public ref float2 pos => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->pos);
        public ref float2 uv => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->uv);
        public ref uint col => ref UnsafeUtilityEx.AsRef<uint>(&NativePtr->col);
    }
}
