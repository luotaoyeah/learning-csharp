using System;

namespace Luotao.Lib.Books.ICS7._12._02
{
    //----------------------------------------------------------------------------------------------------
    // bit flag 是一种特殊的 enum，
    //   1. 使用了 Flags 这个 attribute
    //   2. 每个 member 的值都是 2^n，刚好对应某一个 bit，
    //----------------------------------------------------------------------------------------------------
    [Flags]
    public enum CardDeckSettings : uint
    {
        A = 0b00000001,
        B = 0b00000010,
        C = 0b00000100
    }
}
