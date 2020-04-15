using System;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct NullTerminatedString
    {
        public readonly byte* Data;

        public NullTerminatedString(byte* data)
        {
            Data = data;
        }

        public override string ToString()
        {
            int length = 0;
            byte* ptr = Data;
            while (*ptr != 0)
            {
                length += 1;
                ptr += 1;
            }

            char* chars = stackalloc char[length];
            for (int i = 0; i < length; ++i)
                chars[i] = (char)Data[i];
            return new string(chars);
            //return Encoding.ASCII.GetString(Data, length);
        }

        public static implicit operator string(NullTerminatedString nts) => nts.ToString();
    }
}
