using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawData
    {
        public byte Valid;
        public ImDrawList** CmdLists;
        public int CmdListsCount;
        public int TotalIdxCount;
        public int TotalVtxCount;
        public float2 DisplayPos;
        public float2 DisplaySize;
        public float2 FramebufferScale;
    }
    public unsafe partial struct ImDrawDataPtr
    {
        public ImDrawData* NativePtr { get; }
        public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
        public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new ImDrawDataPtr(nativePtr);
        public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new ImDrawDataPtr(nativePtr);
        public ref bool Valid => ref UnsafeUtilityEx.AsRef<bool>(&NativePtr->Valid);
        public IntPtr CmdLists { get => (IntPtr)NativePtr->CmdLists; set => NativePtr->CmdLists = (ImDrawList**)value; }
        public ref int CmdListsCount => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->CmdListsCount);
        public ref int TotalIdxCount => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->TotalIdxCount);
        public ref int TotalVtxCount => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->TotalVtxCount);
        public ref float2 DisplayPos => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->DisplayPos);
        public ref float2 DisplaySize => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->DisplaySize);
        public ref float2 FramebufferScale => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->FramebufferScale);
        public void Clear()
        {
            ImGuiNative.ImDrawData_Clear(NativePtr);
        }
        public void DeIndexAllBuffers()
        {
            ImGuiNative.ImDrawData_DeIndexAllBuffers(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawData_destroy(NativePtr);
        }
        public void ScaleClipRects(float2 fb_scale)
        {
            ImGuiNative.ImDrawData_ScaleClipRects(NativePtr, fb_scale);
        }
    }
}
