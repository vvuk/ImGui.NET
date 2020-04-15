using System;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    public unsafe struct RangeAccessor<T> where T : struct
    {
        private static readonly int s_sizeOfT = UnsafeUtility.SizeOf<T>();

        public readonly void* Data;
        public readonly int Count;

        public RangeAccessor(IntPtr data, int count) : this(data.ToPointer(), count) {}
        public RangeAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public ref T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return ref UnsafeUtility.AsRef<T>((byte*)Data + s_sizeOfT * index);
            }
        }
    }

    public unsafe struct RangePtrAccessor<T> where T : struct
    {
        public readonly void* Data;
        public readonly int Count;

        public RangePtrAccessor(IntPtr data, int count) : this(data.ToPointer(), count) {}
        public RangePtrAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                //return Unsafe.Read<T>((byte*)Data + sizeof(void*) * index);
                return UnsafeUtility.AsRef<T>((byte*)Data + sizeof(void*) * index);
            }
        }
    }

    public static class RangeAccessorExtensions
    {
        public static unsafe string GetStringASCII(this RangeAccessor<byte> stringAccessor)
        {
            char* chars = stackalloc char[stringAccessor.Count];
            for (int i = 0; i < stringAccessor.Count; ++i)
                chars[i] = (char)stringAccessor[i];
            return new string(chars);
            //return Encoding.ASCII.GetString((byte*)stringAccessor.Data, stringAccessor.Count);
        }
    }
}
