// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewFamily")]
    public partial class ViewFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
       
    private IList<Family> toShow;
    private IList<Family> filter;
    
   private string? filterbyCity;

    protected override async Task OnInitializedAsync()
    {
        toShow = file.Get();
        filter = toShow;
    }

    private void AddMember(string address)
    {
        NavMgr.NavigateTo($"/AddMember/{address}");
    }

    private void FilterByCity(ChangeEventArgs evt)
    {
        string? filterByCity = null;
        try
        {
            filterByCity = evt.Value.ToString();
        }
        catch (Exception e)
        {}
        if (filterByCity != null)
        {
            filter = toShow.Where(t => t.City == filterByCity).ToList();
        }
        else
        {
            filter = toShow;
        }
    }

    private void ShowAdults(string address)
    {
       NavMgr.NavigateTo($"/ViewAdults/{address}");
    }

    private void ShowChildren(string address)
    {
        NavMgr.NavigateTo($"/ViewChildren/{address}");
    }

    private void RemoveFamily(string address)
    {
        file.RemoveFamily(address);
    }

    private void EditFamily(string address)
    {
        NavMgr.NavigateTo($"/EditFamily/{address}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonTarget file { get; set; }
    }
}
#pragma warning restore 1591
