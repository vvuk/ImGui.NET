using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStyle
    {
        public float Alpha;
        public float2 WindowPadding;
        public float WindowRounding;
        public float WindowBorderSize;
        public float2 WindowMinSize;
        public float2 WindowTitleAlign;
        public ImGuiDir WindowMenuButtonPosition;
        public float ChildRounding;
        public float ChildBorderSize;
        public float PopupRounding;
        public float PopupBorderSize;
        public float2 FramePadding;
        public float FrameRounding;
        public float FrameBorderSize;
        public float2 ItemSpacing;
        public float2 ItemInnerSpacing;
        public float2 TouchExtraPadding;
        public float IndentSpacing;
        public float ColumnsMinSpacing;
        public float ScrollbarSize;
        public float ScrollbarRounding;
        public float GrabMinSize;
        public float GrabRounding;
        public float TabRounding;
        public float TabBorderSize;
        public ImGuiDir ColorButtonPosition;
        public float2 ButtonTextAlign;
        public float2 SelectableTextAlign;
        public float2 DisplayWindowPadding;
        public float2 DisplaySafeAreaPadding;
        public float MouseCursorScale;
        public byte AntiAliasedLines;
        public byte AntiAliasedFill;
        public float CurveTessellationTol;
        public float CircleSegmentMaxError;
        public float4 Colors_0;
        public float4 Colors_1;
        public float4 Colors_2;
        public float4 Colors_3;
        public float4 Colors_4;
        public float4 Colors_5;
        public float4 Colors_6;
        public float4 Colors_7;
        public float4 Colors_8;
        public float4 Colors_9;
        public float4 Colors_10;
        public float4 Colors_11;
        public float4 Colors_12;
        public float4 Colors_13;
        public float4 Colors_14;
        public float4 Colors_15;
        public float4 Colors_16;
        public float4 Colors_17;
        public float4 Colors_18;
        public float4 Colors_19;
        public float4 Colors_20;
        public float4 Colors_21;
        public float4 Colors_22;
        public float4 Colors_23;
        public float4 Colors_24;
        public float4 Colors_25;
        public float4 Colors_26;
        public float4 Colors_27;
        public float4 Colors_28;
        public float4 Colors_29;
        public float4 Colors_30;
        public float4 Colors_31;
        public float4 Colors_32;
        public float4 Colors_33;
        public float4 Colors_34;
        public float4 Colors_35;
        public float4 Colors_36;
        public float4 Colors_37;
        public float4 Colors_38;
        public float4 Colors_39;
        public float4 Colors_40;
        public float4 Colors_41;
        public float4 Colors_42;
        public float4 Colors_43;
        public float4 Colors_44;
        public float4 Colors_45;
        public float4 Colors_46;
        public float4 Colors_47;
    }
    public unsafe partial struct ImGuiStylePtr
    {
        public ImGuiStyle* NativePtr { get; }
        public ImGuiStylePtr(ImGuiStyle* nativePtr) => NativePtr = nativePtr;
        public ImGuiStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiStyle*)nativePtr;
        public static implicit operator ImGuiStylePtr(ImGuiStyle* nativePtr) => new ImGuiStylePtr(nativePtr);
        public static implicit operator ImGuiStyle* (ImGuiStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStylePtr(IntPtr nativePtr) => new ImGuiStylePtr(nativePtr);
        public ref float Alpha => ref UnsafeUtility.AsRef<float>(&NativePtr->Alpha);
        public ref float2 WindowPadding => ref UnsafeUtility.AsRef<float2>(&NativePtr->WindowPadding);
        public ref float WindowRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->WindowRounding);
        public ref float WindowBorderSize => ref UnsafeUtility.AsRef<float>(&NativePtr->WindowBorderSize);
        public ref float2 WindowMinSize => ref UnsafeUtility.AsRef<float2>(&NativePtr->WindowMinSize);
        public ref float2 WindowTitleAlign => ref UnsafeUtility.AsRef<float2>(&NativePtr->WindowTitleAlign);
        public ref ImGuiDir WindowMenuButtonPosition => ref UnsafeUtility.AsRef<ImGuiDir>(&NativePtr->WindowMenuButtonPosition);
        public ref float ChildRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->ChildRounding);
        public ref float ChildBorderSize => ref UnsafeUtility.AsRef<float>(&NativePtr->ChildBorderSize);
        public ref float PopupRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->PopupRounding);
        public ref float PopupBorderSize => ref UnsafeUtility.AsRef<float>(&NativePtr->PopupBorderSize);
        public ref float2 FramePadding => ref UnsafeUtility.AsRef<float2>(&NativePtr->FramePadding);
        public ref float FrameRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->FrameRounding);
        public ref float FrameBorderSize => ref UnsafeUtility.AsRef<float>(&NativePtr->FrameBorderSize);
        public ref float2 ItemSpacing => ref UnsafeUtility.AsRef<float2>(&NativePtr->ItemSpacing);
        public ref float2 ItemInnerSpacing => ref UnsafeUtility.AsRef<float2>(&NativePtr->ItemInnerSpacing);
        public ref float2 TouchExtraPadding => ref UnsafeUtility.AsRef<float2>(&NativePtr->TouchExtraPadding);
        public ref float IndentSpacing => ref UnsafeUtility.AsRef<float>(&NativePtr->IndentSpacing);
        public ref float ColumnsMinSpacing => ref UnsafeUtility.AsRef<float>(&NativePtr->ColumnsMinSpacing);
        public ref float ScrollbarSize => ref UnsafeUtility.AsRef<float>(&NativePtr->ScrollbarSize);
        public ref float ScrollbarRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->ScrollbarRounding);
        public ref float GrabMinSize => ref UnsafeUtility.AsRef<float>(&NativePtr->GrabMinSize);
        public ref float GrabRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->GrabRounding);
        public ref float TabRounding => ref UnsafeUtility.AsRef<float>(&NativePtr->TabRounding);
        public ref float TabBorderSize => ref UnsafeUtility.AsRef<float>(&NativePtr->TabBorderSize);
        public ref ImGuiDir ColorButtonPosition => ref UnsafeUtility.AsRef<ImGuiDir>(&NativePtr->ColorButtonPosition);
        public ref float2 ButtonTextAlign => ref UnsafeUtility.AsRef<float2>(&NativePtr->ButtonTextAlign);
        public ref float2 SelectableTextAlign => ref UnsafeUtility.AsRef<float2>(&NativePtr->SelectableTextAlign);
        public ref float2 DisplayWindowPadding => ref UnsafeUtility.AsRef<float2>(&NativePtr->DisplayWindowPadding);
        public ref float2 DisplaySafeAreaPadding => ref UnsafeUtility.AsRef<float2>(&NativePtr->DisplaySafeAreaPadding);
        public ref float MouseCursorScale => ref UnsafeUtility.AsRef<float>(&NativePtr->MouseCursorScale);
        public ref bool AntiAliasedLines => ref UnsafeUtility.AsRef<bool>(&NativePtr->AntiAliasedLines);
        public ref bool AntiAliasedFill => ref UnsafeUtility.AsRef<bool>(&NativePtr->AntiAliasedFill);
        public ref float CurveTessellationTol => ref UnsafeUtility.AsRef<float>(&NativePtr->CurveTessellationTol);
        public ref float CircleSegmentMaxError => ref UnsafeUtility.AsRef<float>(&NativePtr->CircleSegmentMaxError);
        public RangeAccessor<float4> Colors => new RangeAccessor<float4>(&NativePtr->Colors_0, 48);
        public void Destroy()
        {
            ImGuiNative.ImGuiStyle_destroy(NativePtr);
        }
        public void ScaleAllSizes(float scale_factor)
        {
            ImGuiNative.ImGuiStyle_ScaleAllSizes(NativePtr, scale_factor);
        }
    }
}
