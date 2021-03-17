#pragma checksum "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b9cfbc1ae85998d5cd46f29f36b02e894be4a98"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Family Register</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by City: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                                   (arg) => FilterByCity(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:100px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
 if (filter == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
}
else if (!filter.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No Family registered. Please register first.</em></p>");
#nullable restore
#line 25 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Assignment1.Pages.ViewFamily.TypeInference.CreateTableTemplate_0(__builder, 9, 10, 
#nullable restore
#line 28 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                          filter

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.AddMarkupContent(12, "<th>City</th>\r\n            ");
                __builder2.AddMarkupContent(13, "<th>Street Name</th>\r\n            ");
                __builder2.AddMarkupContent(14, "<th>House Number</th>\r\n            ");
                __builder2.AddMarkupContent(15, "<th>Floor</th>\r\n            ");
                __builder2.AddMarkupContent(16, "<th>Number of Adults</th>\r\n            ");
                __builder2.AddMarkupContent(17, "<th>Number of Children</th>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
                __builder2.AddAttribute(19, "Policy", "EditorRole");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(21, "<th>Action</th>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, "<th>Add Member</th>");
            }
            , 24, (item) => (__builder2) => {
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 43 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 44 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.StreetName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 45 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.HouseNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 46 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.Floor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 47 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.Adults.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                                       () => ShowAdults(item.Address())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(42, "<i class=\"oi oi-eye\" style=\"color: #1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 50 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                 item.Children.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                                        () => ShowChildren(item.Address())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "<i class=\"oi oi-eye\" style=\"color: #1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(50);
                __builder2.AddAttribute(51, "Policy", "EditorRole");
                __builder2.AddAttribute(52, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(53, "td");
                    __builder3.OpenElement(54, "button");
                    __builder3.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                        () => RemoveFamily(item.Address())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(56, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddContent(57, " | ");
                    __builder3.OpenElement(58, "button");
                    __builder3.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                                    () => EditFamily(item.Address())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(60, "<i class=\"oi oi-pencil\" style=\"color: red\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenElement(63, "button");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
                                    () => AddMember(item.Address())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "<i class=\"oi oi-person\" style=\"color: #1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
#nullable restore
#line 71 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewFamily.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.Assignment1.Pages.ViewFamily
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTableTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::Assignment1.Shared.TableTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
