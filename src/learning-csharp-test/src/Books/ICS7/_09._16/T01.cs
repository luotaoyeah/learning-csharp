using System;
using System.Reflection;
using Luotao.Lib.Books.ICS7._09._16;
using Xunit;

namespace Luotao.Test.Books.ICS7._09._16
{
    /// <summary>
    ///     9.16 the typeof operator
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // typeof 是一个 operator，他返回某个类型的类型信息，这个类型信息是一个 System.Type 对象，
            //----------------------------------------------------------------------------------------------------
            Type type = typeof(SomeClass);

            FieldInfo[] fields = type.GetFields();
            Assert.Equal("X", fields[0].Name);
            Assert.Equal("Y", fields[1].Name);

            MethodInfo[] methodInfos = type.GetMethods();
            Assert.Equal("Fn01", methodInfos[0].Name);
            Assert.Equal("Fn02", methodInfos[1].Name);
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // 相同的类型返回的是同一个 System.Type 对象
            //----------------------------------------------------------------------------------------------------
            Type type01 = typeof(SomeClass);
            Type type02 = typeof(SomeClass);

            Assert.StrictEqual(type01, type02);
        }
    }
}
