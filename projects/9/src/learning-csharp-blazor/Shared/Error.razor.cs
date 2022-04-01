using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;

namespace Luotao.Blazor.Shared
{
    /// <summary>
    /// 全局异常处理.
    /// </summary>
    public partial class Error
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Inject]
        private ILogger<Error> Logger { get; set; }

        public void ProcessError(Exception e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            Logger.LogError($"{e.GetType()}\n{e.Message}");
        }
    }
}
