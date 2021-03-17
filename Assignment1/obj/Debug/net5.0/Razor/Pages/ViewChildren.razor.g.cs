#pragma checksum "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3d816d9322d29b111df9667c0882859b4f0309"
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
#line 2 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewChildren/{Id:int}")]
    public partial class ViewChildren : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View Children</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by First Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                                                         (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:100px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
 if (personToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
}
else if (!personToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No Person registered. Please register first.</em></p>");
#nullable restore
#line 26 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Assignment1.Pages.ViewChildren.TypeInference.CreateTableTemplate_0(__builder, 9, 10, 
#nullable restore
#line 29 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                          personToShow

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.AddMarkupContent(12, "<th>CPR Number</th>\r\n            ");
                __builder2.AddMarkupContent(13, "<th>First Name</th>\r\n            ");
                __builder2.AddMarkupContent(14, "<th>LastName</th>\r\n            ");
                __builder2.AddMarkupContent(15, "<th>Age</th>\r\n            ");
                __builder2.AddMarkupContent(16, "<th>Gender</th>\r\n            ");
                __builder2.AddMarkupContent(17, "<th>Height</th>\r\n            ");
                __builder2.AddMarkupContent(18, "<th>Weight</th>\r\n            ");
                __builder2.AddMarkupContent(19, "<th>Hair Color</th>\r\n            ");
                __builder2.AddMarkupContent(20, "<th>Eye Color</th>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(21);
                __builder2.AddAttribute(22, "Policy", "EditorRole");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(24, "<th>Action</th>");
                }
                ));
                __builder2.CloseComponent();
            }
            , 25, (item) => (__builder2) => {
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 46 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.CPRNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 47 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 48 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 49 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 50 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 51 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 52 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 53 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddContent(51, 
#nullable restore
#line 54 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                 item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
                __builder2.AddAttribute(54, "Policy", "EditorRole");
                __builder2.AddAttribute(55, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(56, "td");
                    __builder3.OpenElement(57, "button");
                    __builder3.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                                        () => RemovePerson(item.CPRNumber)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(59, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, " |\r\n                    ");
                    __builder3.OpenElement(61, "button");
                    __builder3.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
                                        () => Edit(item.CPRNumber)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(63, "<i class=\"oi oi-pencil\" style=\"color: #1b6ec2\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 69 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\ViewChildren.razor"
       
    [Parameter] public int Id { get; set; }
    private IList<Child> children;
    private IList<Child> personToShow;
    private string? filterbyName;

    protected override async Task OnInitializedAsync()
    {
        children = file.Get(Id).Children;
        personToShow = children;
    }

    private void FilterByName(ChangeEventArgs evt)
    {
        string? filterByName = null;
        try
        {
            filterByName = evt.Value.ToString();
        }
        catch (Exception e)
        {
        }
        if (filterByName != null)
        {
            personToShow = children.Where(t => t.FirstName == filterByName).ToList();
        }
        else
        {
            personToShow = children;
        }
    }

    private void Edit(int id)
    {
        //NavMgr.NavigateTo($"/EditPerson/{id}");
    }

    private void RemovePerson(int id)
    {
        Child ToRemove = children.First(t => t.CPRNumber == id);
        file.RemoveChild(ToRemove, Id);
        children.Remove(ToRemove);
        personToShow.Remove(ToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonTarget file { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.ViewChildren
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
