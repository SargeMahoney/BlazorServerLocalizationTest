using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BlazorServerLocalization.Components.Test
{
    public partial class TestingLocalizer
    {
        [Inject]
        IStringLocalizer<TestingLocalizer> _loc { get; set; }




     
    }
}
