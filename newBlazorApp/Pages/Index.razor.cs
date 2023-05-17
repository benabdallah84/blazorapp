using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newBlazorApp.Pages
{
    
    public partial class Index: ComponentBase
    {
        [Inject]
        public NavigationManager NavMang { get; set; }
        protected override async Task OnInitializedAsync()
        {
            NavMang.NavigateTo("/backlog");
        }
    }
}
