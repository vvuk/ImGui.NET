using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSizeCallbackData
    {
        public void* UserData;
        public float2 Pos;
        public float2 CurrentSize;
        public float2 DesiredSize;
    }
    public unsafe partial struct ImGuiSizeCallbackDataPtr
    {
        public ImGuiSizeCallbackData* NativePtr { get; }
        public ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiSizeCallbackData*)nativePtr;
        public static implicit operator ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiSizeCallbackData* (ImGuiSizeCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ref float2 Pos => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->Pos);
        public ref float2 CurrentSize => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->CurrentSize);
        public ref float2 DesiredSize => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->DesiredSize);
    }
}
