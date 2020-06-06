using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Luotao.BlazorLib.Components
{
  public partial class Component01
  {
    [Inject]
    public IStringLocalizer<Component01> L { get; set; } = null!;
  }
}
