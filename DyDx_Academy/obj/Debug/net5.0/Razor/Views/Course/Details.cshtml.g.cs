#pragma checksum "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b499854f3c0367fb83f775388bee097ff3d7557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\_ViewImports.cshtml"
using DyDx_Academy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\_ViewImports.cshtml"
using DyDx_Academy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b499854f3c0367fb83f775388bee097ff3d7557", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17c2bb0cdaff8327c89b98ed89ba102114ea303", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-addtocart text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Instructors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
   ViewData["Title"] = "Courses details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"padding-top: 88px\">\r\n    <div class=\"col-md-8 offset-2\" style=\"padding-top: 40px;\">\r\n        <div class=\" mb-12\">\r\n            <div class=\"row g-0\">\r\n                <div class=\"col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b499854f3c0367fb83f775388bee097ff3d75575890", async() => {
                WriteLiteral("\r\n                        < Back to List\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                    \r\n\r\n                <div class=\"col-md-8\">\r\n                    <img style=\"border-radius:20px;\"");
            BeginWriteAttribute("src", " src=\"", 564, "\"", 585, 1);
#nullable restore
#line 17 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
WriteAttributeValue("", 570, Model.ImageURL, 570, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 599, "\"", 616, 1);
#nullable restore
#line 17 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
WriteAttributeValue("", 605, Model.Name, 605, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""col-md-4"">
                    <div class=""card-body"" style="" height: 100%; box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.25); border-radius: 20px; margin-left: 20px; }"">
                        <div class=""text-dark"">
                            <p class=""card-text""style=""float:right;"">
                                <h5 class=""card-title"" style=""float:right; font-size:3rem; font-weight:600"">
                                    ");
#nullable restore
#line 24 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                               Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </h5>
                            </p>
                            <p class=""card-text"">
                                <h5 class=""card-title"" style=""font-size: 2.3rem; padding-top: 34%; border-bottom: 1px solid lightgray; padding-bottom: 5%; "">
                                    ");
#nullable restore
#line 29 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                            </p>\r\n                        </div>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 33 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Category: </b><a  class=\"text-light\" style=\"border-radius: 30px; background-color: lightblue; width: 54%; padding: 2px 10px;\">");
#nullable restore
#line 34 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                                                                                                                                                         Write(Model.CourseCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        <p class=\"card-text\">\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b499854f3c0367fb83f775388bee097ff3d755710616", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-cart-plus\"></i> Add to Cart\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            
                        </p>

                    </div>
                </div>
                <div class=""col-md-12 "" style="" padding-bottom: 300px; padding-top : 100px;"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 2541, "\"", 2549, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"display: grid; \">\r\n                        <p style=\"color: #C2C2C2;\">Course last update : ");
#nullable restore
#line 50 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                                                   Write(Model.Create.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <hr />\r\n                            <b style=\"text-align:center; font-size:2.5rem;\">Instructor</b>\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 54 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                 foreach (var instructor in Model.Instructor_Course)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"column text-center\">\r\n                        <img class=\"border-info rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 3104, "\"", 3151, 1);
#nullable restore
#line 57 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
WriteAttributeValue("", 3110, instructor.Instructors.ProfilePictureURL, 3110, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b499854f3c0367fb83f775388bee097ff3d755715190", async() => {
#nullable restore
#line 59 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                                                                                                Write(instructor.Instructors.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                                                                               WriteLiteral(instructor.InstructorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Course\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>


                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<style>
    .btn-addtocart {
        width: 100%;
        height: 30%;
        background: linear-gradient(90deg, #F7971E 0%, #FFD200 100%);
        border-radius: 50px;
        padding: 15px;
        font-weight: 900;
        text-decoration: none;
        text-align: center;
        display: block;
        transition: .5s;
        font-size: 1.2rem

    }
    .btn-addtocart:hover {

        background: linear-gradient(180deg, #F7971E 0%, #FFD200 100%);

    }
    a{
        text-decoration: none ;
        color: black;
    }
    a:hover{
        color: black;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courses> Html { get; private set; }
    }
}
#pragma warning restore 1591
