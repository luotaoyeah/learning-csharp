using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._03._05
{
    /// <summary>
    ///     5.3.5 storing multiple values using an enum type
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// </summary>
        [Fact]
        public void _01()
        {
            var person01 = new Person
            {
                BucketList = WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E
            };
            Assert.Equal((WondersOfTheAncientWorld)17, person01.BucketList);
            Assert.Equal(17, (byte)person01.BucketList);
            Assert.Equal("A, E", person01.BucketList.ToString());
            Assert.Equal(WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E, person01.BucketList);

            var person02 = new Person
            {
                BucketList = (WondersOfTheAncientWorld)17
            };

            Assert.Equal(person01.BucketList, person02.BucketList);
        }
    }

    public class Person
    {
        public WondersOfTheAncientWorld BucketList = WondersOfTheAncientWorld.C;
    }

    [Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        A = 0b_0000_0001,
        B = 0b_0000_0010,
        C = 0b_0000_0100,
        D = 0b_0000_1000,
        E = 0b_0001_0000,
        F = 0b_0010_0000,
        G = 0b_0100_0000
    }
}
