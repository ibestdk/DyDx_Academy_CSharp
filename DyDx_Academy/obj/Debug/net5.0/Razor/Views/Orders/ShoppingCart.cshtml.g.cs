#pragma checksum "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e43c64be84fb702b717361947ff27389ab87d8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ShoppingCart), @"mvc.1.0.view", @"/Views/Orders/ShoppingCart.cshtml")]
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
#nullable restore
#line 1 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
using DyDx_Academy.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43c64be84fb702b717361947ff27389ab87d8c7", @"/Views/Orders/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17c2bb0cdaff8327c89b98ed89ba102114ea303", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItemFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
   ViewData["Title"] = "All orders"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row\" style=\"min-height:880px\">\n    <div class=\"col-md-8 offset-2\">\n        <div class=\"text-center\" style=\"margin-top: 160px\">\n            <h2>ตระกร้าสินค้าของคุณ</h2>\n        </div>\n");
#nullable restore
#line 13 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
           int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"" style=""margin-top: 80px"">
            <thead>
                <tr>
                    <th>รายการ</th>
                    <th>คอร์ส</th>
                    <th>ราคา</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                 foreach (var item in Model.ShoppingCart.ShoppingCartItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td class=\"align-middle\">");
#nullable restore
#line 27 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                             Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n        <td class=\"align-middle\">");
#nullable restore
#line 28 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                            Write(item.Courses.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td class=\"align-middle\">");
#nullable restore
#line 29 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                            Write(item.Courses.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n        <td class=\"align-middle\">\n\n\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e43c64be84fb702b717361947ff27389ab87d8c78267", async() => {
                WriteLiteral("\n                <i class=\"bi bi-cart-dash\"></i>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                 WriteLiteral(item.Courses.Id);

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
            WriteLiteral("\n");
            WriteLiteral("\n    </tr>");
#nullable restore
#line 50 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n            <tfoot style=\"margin-top: 40px\">\n                <tr>\n                    <td colspan=\"1\"></td>\n                    <td><b>รวม:</b></td>\n                    <td>\n                        ");
#nullable restore
#line 57 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                   Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td></td>\n                </tr>\n                <tr>\n                    <td colspan=\"1\"></td>\n                    <td><b>โปรโมชั่นพิเศษ:</b></td>\n                    <td>\n                        -");
#nullable restore
#line 65 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                    Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan=""1""></td>
                    <td><b>รวมทั้งสิ้น:</b></td>
                    <td>
                        ฿0.00
                    </td>
                    <td></td>
                </tr>
            </tfoot>
        </table>


        <div class=""text-center"" style=""margin-top: 120px; margin-bottom: 80px; "">
            <div class=""btn-group"">

                <span style=""padding:5px""></span>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e43c64be84fb702b717361947ff27389ab87d8c712626", async() => {
                WriteLiteral("\n                    เลือกคอร์สเพิ่ม\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <span style=\"padding:5px\"></span>\n\n                <a class=\"btn btn-outline-success\" onclick=\"myFunction()\" />\n                Pay With DyDx Point\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e43c64be84fb702b717361947ff27389ab87d8c714310", async() => {
                WriteLiteral("\n                    รับคอร์สฟรี (ช่วงโปรโมชั่นเท่านั้น)\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("            </div>\n        </div>\n\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://www.paypalobjects.com/api/checkout.js""></script>
    <script>
        function myFunction() {
            alert(""ระบบนี้ยังไม่เปิดให้บริการ เเต่สามารถกดรับคอร์สฟรีได้เลย!"");
        }
    </script>

    <script>

    let _total = ");
#nullable restore
#line 115 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
            Write(Html.Raw(Model.ShoppingCartTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        paypal.Button.render({
            //Configure environment
            env: 'sandbox',
            client: {
                sandbox: 'ECcfs3P8X1230NSFV2qcemB1_-61wy99mgQjuyp5JTd8JC16KsH4dENPpLUO1QZDflzi_eG39ByQGJS9'
            },

            //Customize button
            locale: 'en_US',
            style: {
                size: 'small',
                color: 'gold',
                shape: 'pill'
            },
            commit: true,

            //Set up a payment
            payment: function (data, actions) {
                return actions.payment.create({
                    transactions: [{
                        amount: {
                            total: _total,
                            currency: 'USD'
                        }
                    }]
                });
            },

            //Execute the payment
            onAuthorize: function (data, actions) {
                return actions.payment.execute().then(function () {
                    var url = '");
#nullable restore
#line 148 "C:\Users\BestO\Documents\GitHub\DyDx_Academy_CSharp\DyDx_Academy\Views\Orders\ShoppingCart.cshtml"
                          Write(Url.Action("CompleteOrder", "Orders", new { }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n                    window.location.href = url;\n                });\n            }\n\n        }, \'#paypal-btn\')\n\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
