#pragma checksum "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fc1332d89e401cb65612c9ff73be31f099053b"
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
#line 1 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\_ViewImports.cshtml"
using Diplom1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\_ViewImports.cshtml"
using Diplom1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\_ViewImports.cshtml"
using Diplom1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\_ViewImports.cshtml"
using Omu.AwesomeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\_ViewImports.cshtml"
using Omu.Awem.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fc1332d89e401cb65612c9ff73be31f099053b", @"/Views/MainPage/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae77ae21de99afa548ac8de3ba42436758a5784", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/delete_button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n    <a class=\"btn btn-primary button-marg\" href=\"/AddReq/Index\">?????????????? ?????????? ????????????</a>\r\n\r\n    <!--<form asp-controller=\"MainPage\"\r\n          asp-action=\"MainPage\" method=\"post\">-->\r\n");
            WriteLiteral(@"        <!--<br />

        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-10"">
                    <button id=""btnclick"" class=""btn btn-primary button-marg"" type=""button"">?????????????? ?????????? ????????????</button>
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
                                    <div class=""form-group"">
                                        <input class=""form-control"" type=""text"" placeholder=""Username"" id=""usrnametxt"" />");
            WriteLiteral(@"
                                        <details>
                                            <summary>??????????</summary>
                                            <table class=""scroll-table"">
                                                <thead>
                                                    <tr><td>Name</td></tr>
                                                </thead>
                                                <tbody class=""scroll-table-body"">
");
#nullable restore
#line 47 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                                     if (Model.AllCargoes.Count > 0)
                                                    {
                                                        foreach (var item in Model.AllCargoes)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>");
#nullable restore
#line 52 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
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
                                </div>
                                <div class=""modal-footer"">
                                    <input type=""submit"" class=""create-request-button"" name=""openmodal"" value=""????????????????"" />
                                    <button type=""button"" id=""HidebtnModal"" class=""btn btn-primary"">Hide</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</div>-->


<script src=""https://ajax.googleapis.");
            WriteLiteral("com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fc1332d89e401cb65612c9ff73be31f099053b9655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fc1332d89e401cb65612c9ff73be31f099053b10694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                <th>????????</th>
                <th>????????????</th>
                <th>??????-????</th>
                <th>????????????</th>
                <th>??????????, ??????</th>
                <th>??????????, ?????????????? ??????</th>
                <th></th>
            </tr>
        </thead>
    </table>
    <div class=""scroll-table-body"">
        <table>
            <tbody>
");
#nullable restore
#line 117 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                  
                    string SvgPath = null;
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
#line 128 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                         foreach (CargoObject co in req.CargoObj)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
#nullable restore
#line 130 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                          Write(co.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 131 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <th>\r\n                                        <details>\r\n                                            <summary>????????????:</summary>\r\n");
#nullable restore
#line 136 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                             foreach (Service sr in req.Services)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p>");
#nullable restore
#line 138 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                              Write(sr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 139 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </details>\r\n                                    </th>\r\n                                    <td>");
#nullable restore
#line 142 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.CargoAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 144 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                         switch (req.Status)
                                        {
                                            case "??????????????":
                                                SvgPath = "~/img/gray.svg";
                                                break;
                                            case "??????????????????????":
                                                SvgPath = "~/img/yellow.svg";
                                                break;
                                            case "????????????????":
                                                SvgPath = "~/img/red.svg";
                                                break;
                                            case "??????????????????":
                                                SvgPath = "~/img/green.svg";
                                                break;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 7201, "\"", 7228, 1);
#nullable restore
#line 159 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
WriteAttributeValue("", 7207, Url.Content(SvgPath), 7207, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"15px\" width=\"15px\">\r\n                                        ");
#nullable restore
#line 160 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 162 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.TotalSumRub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 163 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
                                   Write(req.TotalSumUsd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button class=\"delete-request-buttontable\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82fc1332d89e401cb65612c9ff73be31f099053b18875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 170 "C:\Users\Demid\Desktop\Diplom-133db33997cb74df6c042480af21c02c60829c5a\Diplom1\Views\MainPage\MainPage.cshtml"
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
