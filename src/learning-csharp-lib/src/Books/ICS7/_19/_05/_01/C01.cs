using System.Collections.Generic;

namespace Luotao.Lib.Books.ICS7._19._05._01
{
    public class C01
    {
        /// <summary>
        ///     iterator block 是指包含 `yield return` / `yield break` 语句的 block，
        ///     iterator block 返回 <see cref="IEnumerator{T}" /> 或者 <see cref="IEnumerable{T}" />，
        ///     compiler 会根据 iterator block 帮我们完成 <see cref="IEnumerator{T}" /> 或者 <see cref="IEnumerable{T}" /> 的创建，
        /// </summary>
        /// <returns></returns>
        public static IEnumerator<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
