#pragma checksum "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "239be708c977e96b368d62fc508abf7970ea5c81"
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
#line 3 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
           [Authorize(Policy = "AdminRole")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddMember/{Address}")]
    public partial class AddMember : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Add Member:");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
  if (family == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<em>Person is not registered!</em>");
#nullable restore
#line 13 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
    }
 else
 {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "Catagory\r\n         ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "form-control-selectpicker");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                (arg) => AddSelected(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "width:100px");
            __builder.OpenElement(10, "option");
            __builder.AddContent(11, "Adult");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n             ");
            __builder.OpenElement(13, "option");
            __builder.AddContent(14, "Child");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                       newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                  Execute

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n         ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label class=\"col-sm-2 col-form-label\">CPR Number:</label>\r\n             ");
                __Blazor.Assignment1.Pages.AddMember.TypeInference.CreateInputNumber_0(__builder2, 26, 27, "col-sm-6 form-control", 28, 
#nullable restore
#line 29 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                      newPerson.CPRNumber

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.CPRNumber = __value, newPerson.CPRNumber)), 30, () => newPerson.CPRNumber);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n         ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "<label class=\"col-sm-2 col-form-label\">First Name:</label>\r\n             ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                    newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n         ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group row");
                __builder2.AddMarkupContent(43, "<label class=\"col-sm-2 col-form-label\">Last Name:</label>\r\n             ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                    newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n         ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "<label class=\"col-sm-2 col-form-label\">Hair Color:</label>\r\n             ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                    newPerson.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.HairColor = __value, newPerson.HairColor))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n         ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group row");
                __builder2.AddMarkupContent(61, "<label class=\"col-sm-2 col-form-label\">Eye Color:</label>\r\n             ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                    newPerson.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.EyeColor = __value, newPerson.EyeColor))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n         ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group row");
                __builder2.AddMarkupContent(70, "<label class=\"col-sm-2 col-form-label\">Age:</label>\r\n             ");
                __Blazor.Assignment1.Pages.AddMember.TypeInference.CreateInputNumber_1(__builder2, 71, 72, "col-sm-6 form-control", 73, 
#nullable restore
#line 49 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                      newPerson.Age

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Age = __value, newPerson.Age)), 75, () => newPerson.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n         ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group row");
                __builder2.AddMarkupContent(79, "<label class=\"col-sm-2 col-form-label\">Weight:</label>\r\n             ");
                __Blazor.Assignment1.Pages.AddMember.TypeInference.CreateInputNumber_2(__builder2, 80, 81, "col-sm-6 form-control", 82, 
#nullable restore
#line 53 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                      newPerson.Weight

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Weight = __value, newPerson.Weight)), 84, () => newPerson.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n         ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group row");
                __builder2.AddMarkupContent(88, "<label class=\"col-sm-2 col-form-label\">Height:</label>\r\n             ");
                __Blazor.Assignment1.Pages.AddMember.TypeInference.CreateInputNumber_3(__builder2, 89, 90, "col-sm-6 form-control", 91, 
#nullable restore
#line 57 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                      newPerson.Height

#line default
#line hidden
#nullable disable
                , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Height = __value, newPerson.Height)), 93, () => newPerson.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n         ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.AddMarkupContent(97, "<label class=\"col-sm-2 col-form-label\">Gender:</label>\r\n             ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
                                                                    newPerson.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Sex = __value, newPerson.Sex))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n         ");
                __builder2.AddMarkupContent(104, "<p class=\"actions\"><button class=\"btn-primary btn-outline-dark\" type=\"submit\">Add Member</button></p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 67 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\HP\RiderProjects\Assignments\Assignment1\Pages\AddMember.razor"
       
    [Parameter] public string Address { get; set; }
    private Person newPerson = new();
    private string e;
    private Family family;

    protected override async Task OnInitializedAsync()
    {
        family = file.Get(Address);
    }
    
    private void AddNewAdult()
    {
       file.AddNewAdult((Adult)newPerson, Address);
        Console.WriteLine(newPerson);
    }
    
    private void AddNewChild()
    {
        file.AddNewChild((Child)newPerson, Address);
    }

    private void AddSelected(ChangeEventArgs evt)
    {
        e = evt.Value.ToString();
        if (e.Equals("Child"))
        {
            newPerson = new Child();
        }
        else
        {
            newPerson = new Adult();
        }
    }

    private void Execute()
    {
        if(e.Equals("Child"))
        {
            AddNewChild();
        }
        else
        {
            AddNewAdult();
        }
        NavMgr.NavigateTo("/ViewFamily");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonTarget file { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.AddMember
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
