using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImFontConfig
    {
        public void* FontData;
        public int FontDataSize;
        public byte FontDataOwnedByAtlas;
        public int FontNo;
        public float SizePixels;
        public int OversampleH;
        public int OversampleV;
        public byte PixelSnapH;
        public float2 GlyphExtraSpacing;
        public float2 GlyphOffset;
        public ushort* GlyphRanges;
        public float GlyphMinAdvanceX;
        public float GlyphMaxAdvanceX;
        public byte MergeMode;
        public uint RasterizerFlags;
        public float RasterizerMultiply;
        public ushort EllipsisChar;
        public fixed byte Name[40];
        public ImFont* DstFont;
    }
    public unsafe partial struct ImFontConfigPtr
    {
        public ImFontConfig* NativePtr { get; }
        public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
        public ImFontConfigPtr(IntPtr nativePtr) => NativePtr = (ImFontConfig*)nativePtr;
        public static implicit operator ImFontConfigPtr(ImFontConfig* nativePtr) => new ImFontConfigPtr(nativePtr);
        public static implicit operator ImFontConfig* (ImFontConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontConfigPtr(IntPtr nativePtr) => new ImFontConfigPtr(nativePtr);
        public IntPtr FontData { get => (IntPtr)NativePtr->FontData; set => NativePtr->FontData = (void*)value; }
        public ref int FontDataSize => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->FontDataSize);
        public ref bool FontDataOwnedByAtlas => ref UnsafeUtilityEx.AsRef<bool>(&NativePtr->FontDataOwnedByAtlas);
        public ref int FontNo => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->FontNo);
        public ref float SizePixels => ref UnsafeUtilityEx.AsRef<float>(&NativePtr->SizePixels);
        public ref int OversampleH => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->OversampleH);
        public ref int OversampleV => ref UnsafeUtilityEx.AsRef<int>(&NativePtr->OversampleV);
        public ref bool PixelSnapH => ref UnsafeUtilityEx.AsRef<bool>(&NativePtr->PixelSnapH);
        public ref float2 GlyphExtraSpacing => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->GlyphExtraSpacing);
        public ref float2 GlyphOffset => ref UnsafeUtilityEx.AsRef<float2>(&NativePtr->GlyphOffset);
        public IntPtr GlyphRanges { get => (IntPtr)NativePtr->GlyphRanges; set => NativePtr->GlyphRanges = (ushort*)value; }
        public ref float GlyphMinAdvanceX => ref UnsafeUtilityEx.AsRef<float>(&NativePtr->GlyphMinAdvanceX);
        public ref float GlyphMaxAdvanceX => ref UnsafeUtilityEx.AsRef<float>(&NativePtr->GlyphMaxAdvanceX);
        public ref bool MergeMode => ref UnsafeUtilityEx.AsRef<bool>(&NativePtr->MergeMode);
        public ref uint RasterizerFlags => ref UnsafeUtilityEx.AsRef<uint>(&NativePtr->RasterizerFlags);
        public ref float RasterizerMultiply => ref UnsafeUtilityEx.AsRef<float>(&NativePtr->RasterizerMultiply);
        public ref ushort EllipsisChar => ref UnsafeUtilityEx.AsRef<ushort>(&NativePtr->EllipsisChar);
        public RangeAccessor<byte> Name => new RangeAccessor<byte>(NativePtr->Name, 40);
        public ImFontPtr DstFont => new ImFontPtr(NativePtr->DstFont);
        public void Destroy()
        {
            ImGuiNative.ImFontConfig_destroy(NativePtr);
        }
    }
}
