#pragma checksum "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718201898bbb0968b7fcb6623cec15b93ec94386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IMEI_DienThoai_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/IMEI_DienThoai/Index.cshtml")]
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
#line 1 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718201898bbb0968b7fcb6623cec15b93ec94386", @"/Areas/Admin/Views/IMEI_DienThoai/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c81b1a8f9ef81bbd2ceef44ee517b11b3ebd31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IMEI_DienThoai_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CuaHangDienThoai.Models.ChiTietHoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HoaDons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
  
    ViewData["Title"] = "Danh sách IMEI";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718201898bbb0968b7fcb6623cec15b93ec943865643", async() => {
                WriteLiteral(@"
        <h2 class=""text-info"" style=""text-align:center"">Danh sách IMEI thuộc các hóa đơn</h2>
        <div style=""height:200px; background-color:aliceblue"" class=""container"">
            <div class=""row"" style=""padding-top:10px;"">
                <label>Tìm kiếm</label>
            </div>
            <div class=""col-12"">
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Mã hóa đơn
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 18 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                   Write(Html.Editor("searchMaHD", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                        Mã điện thoại
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 27 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                   Write(Html.Editor("searchMaDT", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Mã IMEI
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 36 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                   Write(Html.Editor("searchIMEI", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                    </div>
                    <div class=""col-3"">
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-3"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-primary form-control"">
                            <i class=""fas fa-search""></i> Tìm kiếm
                        </button>
                    </div>

                </div>
            </div>
        </div>
        <table class=""table"">
            <tr class=""table-info"">
                <th>
                    ");
#nullable restore
#line 62 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 65 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaDT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 68 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    IMEI\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
             foreach (var item in Model)
            {
                var IMEI = TempData["searchIMEI"];

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718201898bbb0968b7fcb6623cec15b93ec9438610457", async() => {
#nullable restore
#line 80 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                                                                                                                                      Write(Html.DisplayFor(modelItem => item.MaHD));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchMaHD", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                                                                                                                   WriteLiteral(item.MaHD);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchMaHD"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchMaHD", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchMaHD"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaDT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 89 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                          int t = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                         foreach (var im in item.IMEI_DienThoais.Where(im => im.MaHD == item.MaHD))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"form-group\">");
#nullable restore
#line 92 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => im.IMEI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n");
#nullable restore
#line 93 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                            t++;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 97 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                         if (t < item.SoLuong)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"text-danger\">Bổ sung IMEI!</label>\r\n                            <br />\r\n");
#nullable restore
#line 101 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                          var id = item.MaHD.ToString() + item.MaDT.ToString();

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718201898bbb0968b7fcb6623cec15b93ec9438616662", async() => {
                    WriteLiteral("Sửa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
                                              WriteLiteral(id);

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
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 107 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CuaHangDienThoai.Models.ChiTietHoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
