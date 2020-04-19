using System;

namespace FantasyLibrary
{
    public class VM
    {
        public const int AReg = 0;
        public const int BReg = 1;
        public const int MaxReg = 2;

        public bool HasOverflow = false;
        public void Add(int Reg1, int Reg2)
        { 
            int result = (Registers[Reg1] + Registers[Reg2]);
            int top8Bits = result & 0b1111111100000000;
            if (top8Bits != 0)
            {
                HasOverflow = true;
            }
            else
            {
                HasOverflow = false;
            }
            Registers[Reg1] = (byte)result;
        }
        public byte[] Registers = new byte[MaxReg];
    };
}
