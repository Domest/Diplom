#pragma checksum "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c91cd45cc9a33c4bfc0be60e9652f7455139c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_MainPage), @"mvc.1.0.view", @"/Views/MainPage/MainPage.cshtml")]
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
#line 1 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\_ViewImports.cshtml"
using Diplom1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\_ViewImports.cshtml"
using Diplom1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\_ViewImports.cshtml"
using Diplom1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\_ViewImports.cshtml"
using Omu.AwesomeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\_ViewImports.cshtml"
using Omu.Awem.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c91cd45cc9a33c4bfc0be60e9652f7455139c0", @"/Views/MainPage/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8239852346793110f123e831d356670ed238a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MainPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/delete_button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
            WriteLiteral("    <a href=\"/AddReq/Index\"");
            BeginWriteAttribute("class", " class=\"", 482, "\"", 490, 0);
            EndWriteAttribute();
            WriteLiteral(">Your button text</a>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c91cd45cc9a33c4bfc0be60e9652f7455139c06445", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"        <br />

        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-10"">
                    <button id=""btnclick"" type=""button"">Click to add</button>
                    <div class=""modal fade"" id=""login"">
                        <div class=""modal-dialog modal-lg"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <button type=""button"" class=""close"" data-dismiss=""modal"">
                                        x
                                    </button>
                                    <h4 class=""modal-title"">Login</h4>
                                </div>
                                <div class=""modal-body"">
");
                WriteLiteral(@"                                    <div class=""form-group"">
                                        <input class=""form-control"" type=""text"" placeholder=""Username"" id=""usrnametxt"" />
                                        <details>
                                            <summary>Грузы</summary>
                                            <table class=""scroll-table"">
                                                <thead>
                                                    <tr><td>Name</td></tr>
                                                </thead>
                                                <tbody class=""scroll-table-body"">
");
#nullable restore
#line 44 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                                     if (Model.AllCargoes.Count > 0)
                                                    {
                                                        foreach (var item in Model.AllCargoes)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <tr>\r\n                                                                <td>");
#nullable restore
#line 49 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                                        }
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </tbody>
                                            </table>
                                        </details>
                                    </div>
                                    <div>
                                        <input class=""form-control"" type=""password"" placeholder=""Password"" id=""passwordtxt"" />
                                    </div>
");
                WriteLiteral(@"                                </div>
                                <div class=""modal-footer"">
                                    <input type=""submit"" class=""create-request-button"" name=""openmodal"" value=""Добавить"" />
                                    <button type=""button"" id=""HidebtnModal"" class=""btn btn-primary"">Hide</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c91cd45cc9a33c4bfc0be60e9652f7455139c012243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c91cd45cc9a33c4bfc0be60e9652f7455139c013283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#btnclick"").click(function () {
            $(""#login"").modal('show');
        });
        $(""#HidebtnModal"").click(function () {
            $(""#login"").modal('hide');
        });
    });
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#Subjects_dropdown\').multiselect();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"

<div class=""scroll-table"">
    <table>
        <thead>
            <tr>
                <th>Груз</th>
                <th>Услуга</th>
                <th>Кол-во</th>
                <th>Статус</th>
                <th>Сумма, руб</th>
                <th>Сумма, доллары США</th>
                <th></th>
            </tr>
        </thead>
    </table>
    <div class=""scroll-table-body"">
        <table>
            <tbody>
");
#nullable restore
#line 115 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                  
                    if (Model.AllRequests != null)
                    {

                        foreach (Request req in Model.AllRequests)
                        {
                            if (req.User == Model.CurrUserName)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n");
#nullable restore
#line 125 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                         foreach (CargoObject co in req.CargoObj)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
#nullable restore
#line 127 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                          Write(co.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 128 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <th>\r\n                                        <details>\r\n                                            <summary>Услуги:</summary>\r\n");
#nullable restore
#line 133 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                             foreach (Service sr in req.Services)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p>");
#nullable restore
#line 135 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                              Write(sr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 136 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </details>\r\n                                    </th>\r\n                                    <td>");
#nullable restore
#line 139 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.CargoAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 140 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 141 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.TotalSumRub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 142 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.TotalSumUsd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button class=\"delete-request-buttontable\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26c91cd45cc9a33c4bfc0be60e9652f7455139c019259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 149 "C:\Users\Demid\Desktop\GitProj\Diplom1\Views\MainPage\MainPage.cshtml"
                            }
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
