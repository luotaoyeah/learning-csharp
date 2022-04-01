using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#custom-binding-formats-1.
    /// </summary>
    [Route("/docs/components/data-binding/custom-binding-formats")]
    public partial class CustomBindingFormats
    {
        private string? inputValue;

        /// <summary>
        /// 双向绑定一个 property 时, 可以在 get/set 里面对数据进行处理.
        /// </summary>
        private string? InputValue
        {
            get => inputValue;
            set => inputValue = value?.ToUpper();
        }
    }
}
