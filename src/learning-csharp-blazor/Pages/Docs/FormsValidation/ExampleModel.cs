using System.ComponentModel.DataAnnotations;

namespace Luotao.Blazor.Pages.Docs.FormsValidation
{
    /// <summary>
    /// 表单模型对象.
    /// </summary>
    public class ExampleModel
    {
        /// <summary>
        /// 名称.
        /// </summary>
        [Required]
        [StringLength(10, ErrorMessage = "最多 10 个字符", MinimumLength = 5)]
        public string? Name { get; set; }
    }
}
