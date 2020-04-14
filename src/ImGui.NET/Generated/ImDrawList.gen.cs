using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Mathematics;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawList
    {
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
        public ImVector VtxBuffer;
        public ImDrawListFlags Flags;
        public IntPtr _Data;
        public byte* _OwnerName;
        public uint _VtxCurrentOffset;
        public uint _VtxCurrentIdx;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector _ClipRectStack;
        public ImVector _TextureIdStack;
        public ImVector _Path;
        public ImDrawListSplitter _Splitter;
    }
    public unsafe partial struct ImDrawListPtr
    {
        public ImDrawList* NativePtr { get; }
        public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
        public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
        public static implicit operator ImDrawListPtr(ImDrawList* nativePtr) => new ImDrawListPtr(nativePtr);
        public static implicit operator ImDrawList* (ImDrawListPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawListPtr(IntPtr nativePtr) => new ImDrawListPtr(nativePtr);
        public ImPtrVector<ImDrawCmdPtr> CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->CmdBuffer, UnsafeUtility.SizeOf<ImDrawCmd>());
        public ImVector<ushort> IdxBuffer => new ImVector<ushort>(NativePtr->IdxBuffer);
        public ImPtrVector<ImDrawVertPtr> VtxBuffer => new ImPtrVector<ImDrawVertPtr>(NativePtr->VtxBuffer, UnsafeUtility.SizeOf<ImDrawVert>());
        public ref ImDrawListFlags Flags => ref UnsafeUtility.AsRef<ImDrawListFlags>(&NativePtr->Flags);
        public ref IntPtr _Data => ref UnsafeUtility.AsRef<IntPtr>(&NativePtr->_Data);
        public NullTerminatedString _OwnerName => new NullTerminatedString(NativePtr->_OwnerName);
        public ref uint _VtxCurrentOffset => ref UnsafeUtility.AsRef<uint>(&NativePtr->_VtxCurrentOffset);
        public ref uint _VtxCurrentIdx => ref UnsafeUtility.AsRef<uint>(&NativePtr->_VtxCurrentIdx);
        public ImDrawVertPtr _VtxWritePtr => new ImDrawVertPtr(NativePtr->_VtxWritePtr);
        public IntPtr _IdxWritePtr { get => (IntPtr)NativePtr->_IdxWritePtr; set => NativePtr->_IdxWritePtr = (ushort*)value; }
        public ImVector<float4> _ClipRectStack => new ImVector<float4>(NativePtr->_ClipRectStack);
        public ImVector<IntPtr> _TextureIdStack => new ImVector<IntPtr>(NativePtr->_TextureIdStack);
        public ImVector<float2> _Path => new ImVector<float2>(NativePtr->_Path);
        public ref ImDrawListSplitter _Splitter => ref UnsafeUtility.AsRef<ImDrawListSplitter>(&NativePtr->_Splitter);
        public void AddBezierCurve(float2 p1, float2 p2, float2 p3, float2 p4, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierCurve(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierCurve(float2 p1, float2 p2, float2 p3, float2 p4, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierCurve(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddCallback(IntPtr callback, IntPtr callback_data)
        {
            void* native_callback_data = (void*)callback_data.ToPointer();
            ImGuiNative.ImDrawList_AddCallback(NativePtr, callback, native_callback_data);
        }
        public void AddCircle(float2 center, float radius, uint col)
        {
            int num_segments = 12;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircle(float2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircle(float2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircleFilled(float2 center, float radius, uint col)
        {
            int num_segments = 12;
            ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddCircleFilled(float2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddConvexPolyFilled(ref float2 points, int num_points, uint col)
        {
            fixed (float2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddConvexPolyFilled(NativePtr, native_points, num_points, col);
            }
        }
        public void AddDrawCmd()
        {
            ImGuiNative.ImDrawList_AddDrawCmd(NativePtr);
        }
        public void AddImage(IntPtr user_texture_id, float2 p_min, float2 p_max)
        {
            float2 uv_min = new float2();
            float2 uv_max = new float2(1, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, float2 p_min, float2 p_max, float2 uv_min)
        {
            float2 uv_max = new float2(1, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, float2 p_min, float2 p_max, float2 uv_min, float2 uv_max)
        {
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, float2 p_min, float2 p_max, float2 uv_min, float2 uv_max, uint col)
        {
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4)
        {
            float2 uv1 = new float2();
            float2 uv2 = new float2(1, 0);
            float2 uv3 = new float2(1, 1);
            float2 uv4 = new float2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4, float2 uv1)
        {
            float2 uv2 = new float2(1, 0);
            float2 uv3 = new float2(1, 1);
            float2 uv4 = new float2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4, float2 uv1, float2 uv2)
        {
            float2 uv3 = new float2(1, 1);
            float2 uv4 = new float2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4, float2 uv1, float2 uv2, float2 uv3)
        {
            float2 uv4 = new float2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4, float2 uv1, float2 uv2, float2 uv3, float2 uv4)
        {
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, float2 p1, float2 p2, float2 p3, float2 p4, float2 uv1, float2 uv2, float2 uv3, float2 uv4, uint col)
        {
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageRounded(IntPtr user_texture_id, float2 p_min, float2 p_max, float2 uv_min, float2 uv_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners);
        }
        public void AddImageRounded(IntPtr user_texture_id, float2 p_min, float2 p_max, float2 uv_min, float2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners);
        }
        public void AddLine(float2 p1, float2 p2, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddLine(NativePtr, p1, p2, col, thickness);
        }
        public void AddLine(float2 p1, float2 p2, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddLine(NativePtr, p1, p2, col, thickness);
        }
        public void AddNgon(float2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddNgon(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddNgon(float2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddNgon(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddNgonFilled(float2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddNgonFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddPolyline(ref float2 points, int num_points, uint col, bool closed, float thickness)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            fixed (float2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddPolyline(NativePtr, native_points, num_points, col, native_closed, thickness);
            }
        }
        public void AddQuad(float2 p1, float2 p2, float2 p3, float2 p4, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
        }
        public void AddQuad(float2 p1, float2 p2, float2 p3, float2 p4, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
        }
        public void AddQuadFilled(float2 p1, float2 p2, float2 p3, float2 p4, uint col)
        {
            ImGuiNative.ImDrawList_AddQuadFilled(NativePtr, p1, p2, p3, p4, col);
        }
        public void AddRect(float2 p_min, float2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(float2 p_min, float2 p_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(float2 p_min, float2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(float2 p_min, float2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness)
        {
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRectFilled(float2 p_min, float2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilled(float2 p_min, float2 p_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilled(float2 p_min, float2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilledMultiColor(float2 p_min, float2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
        {
            ImGuiNative.ImDrawList_AddRectFilledMultiColor(NativePtr, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
        }
        public void AddTriangle(float2 p1, float2 p2, float2 p3, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddTriangle(NativePtr, p1, p2, p3, col, thickness);
        }
        public void AddTriangle(float2 p1, float2 p2, float2 p3, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddTriangle(NativePtr, p1, p2, p3, col, thickness);
        }
        public void AddTriangleFilled(float2 p1, float2 p2, float2 p3, uint col)
        {
            ImGuiNative.ImDrawList_AddTriangleFilled(NativePtr, p1, p2, p3, col);
        }
        public void ChannelsMerge()
        {
            ImGuiNative.ImDrawList_ChannelsMerge(NativePtr);
        }
        public void ChannelsSetCurrent(int n)
        {
            ImGuiNative.ImDrawList_ChannelsSetCurrent(NativePtr, n);
        }
        public void ChannelsSplit(int count)
        {
            ImGuiNative.ImDrawList_ChannelsSplit(NativePtr, count);
        }
        public void Clear()
        {
            ImGuiNative.ImDrawList_Clear(NativePtr);
        }
        public void ClearFreeMemory()
        {
            ImGuiNative.ImDrawList_ClearFreeMemory(NativePtr);
        }
        public ImDrawListPtr CloneOutput()
        {
            ImDrawList* ret = ImGuiNative.ImDrawList_CloneOutput(NativePtr);
            return new ImDrawListPtr(ret);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawList_destroy(NativePtr);
        }
        public float2 GetClipRectMax()
        {
            float2 ret = ImGuiNative.ImDrawList_GetClipRectMax(NativePtr);
            return ret;
        }
        public float2 GetClipRectMin()
        {
            float2 ret = ImGuiNative.ImDrawList_GetClipRectMin(NativePtr);
            return ret;
        }
        public void PathArcTo(float2 center, float radius, float a_min, float a_max)
        {
            int num_segments = 10;
            ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
        }
        public void PathArcTo(float2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
        }
        public void PathArcToFast(float2 center, float radius, int a_min_of_12, int a_max_of_12)
        {
            ImGuiNative.ImDrawList_PathArcToFast(NativePtr, center, radius, a_min_of_12, a_max_of_12);
        }
        public void PathBezierCurveTo(float2 p2, float2 p3, float2 p4)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierCurveTo(NativePtr, p2, p3, p4, num_segments);
        }
        public void PathBezierCurveTo(float2 p2, float2 p3, float2 p4, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierCurveTo(NativePtr, p2, p3, p4, num_segments);
        }
        public void PathClear()
        {
            ImGuiNative.ImDrawList_PathClear(NativePtr);
        }
        public void PathFillConvex(uint col)
        {
            ImGuiNative.ImDrawList_PathFillConvex(NativePtr, col);
        }
        public void PathLineTo(float2 pos)
        {
            ImGuiNative.ImDrawList_PathLineTo(NativePtr, pos);
        }
        public void PathLineToMergeDuplicate(float2 pos)
        {
            ImGuiNative.ImDrawList_PathLineToMergeDuplicate(NativePtr, pos);
        }
        public void PathRect(float2 rect_min, float2 rect_max)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathRect(float2 rect_min, float2 rect_max, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathRect(float2 rect_min, float2 rect_max, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathStroke(uint col, bool closed)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke(NativePtr, col, native_closed, thickness);
        }
        public void PathStroke(uint col, bool closed, float thickness)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PathStroke(NativePtr, col, native_closed, thickness);
        }
        public void PopClipRect()
        {
            ImGuiNative.ImDrawList_PopClipRect(NativePtr);
        }
        public void PopTextureID()
        {
            ImGuiNative.ImDrawList_PopTextureID(NativePtr);
        }
        public void PrimQuadUV(float2 a, float2 b, float2 c, float2 d, float2 uv_a, float2 uv_b, float2 uv_c, float2 uv_d, uint col)
        {
            ImGuiNative.ImDrawList_PrimQuadUV(NativePtr, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
        }
        public void PrimRect(float2 a, float2 b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRect(NativePtr, a, b, col);
        }
        public void PrimRectUV(float2 a, float2 b, float2 uv_a, float2 uv_b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRectUV(NativePtr, a, b, uv_a, uv_b, col);
        }
        public void PrimReserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimReserve(NativePtr, idx_count, vtx_count);
        }
        public void PrimUnreserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimUnreserve(NativePtr, idx_count, vtx_count);
        }
        public void PrimVtx(float2 pos, float2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimVtx(NativePtr, pos, uv, col);
        }
        public void PrimWriteIdx(ushort idx)
        {
            ImGuiNative.ImDrawList_PrimWriteIdx(NativePtr, idx);
        }
        public void PrimWriteVtx(float2 pos, float2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimWriteVtx(NativePtr, pos, uv, col);
        }
        public void PushClipRect(float2 clip_rect_min, float2 clip_rect_max)
        {
            byte intersect_with_current_clip_rect = 0;
            ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
        }
        public void PushClipRect(float2 clip_rect_min, float2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public void PushClipRectFullScreen()
        {
            ImGuiNative.ImDrawList_PushClipRectFullScreen(NativePtr);
        }
        public void PushTextureID(IntPtr texture_id)
        {
            ImGuiNative.ImDrawList_PushTextureID(NativePtr, texture_id);
        }
        public void UpdateClipRect()
        {
            ImGuiNative.ImDrawList_UpdateClipRect(NativePtr);
        }
        public void UpdateTextureID()
        {
            ImGuiNative.ImDrawList_UpdateTextureID(NativePtr);
        }
    }
}
