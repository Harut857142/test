#pragma checksum "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Permission\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ac205932551933b99796e5a5c33b221896c457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permission_Add), @"mvc.1.0.view", @"/Views/Permission/Add.cshtml")]
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
#line 1 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\_ViewImports.cshtml"
using Gas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\_ViewImports.cshtml"
using Gas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ac205932551933b99796e5a5c33b221896c457", @"/Views/Permission/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a67073476b22c37699e082863fa1a91950662fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Permission_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PermissionAddForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Permission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Permission\Add.cshtml"
  
    ViewData["Title"] = "Permissions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""contentWrapTop"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""contentWrapTopLeft"">
                    <h1>Permission</h1>
                </div>
                <div class=""contentWrapTopRight"">
                    <ul>
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-edit""></i>
                                <span>Permission</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <section class=""contentWrap"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ac205932551933b99796e5a5c33b221896c4575830", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-xs-12 col-md-9 loaderHolder"">
                    <section class=""boxWrap"">
                        <div class=""box"">
                            <div class=""boxHeader"">
                                <div class=""boxHeaderLeft"">
                                    <h3><span>Permission details</span></h3>
                                </div>
                            </div>
                            <div class=""boxBody"">
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""Module"">Module</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 1666, "\"", 1675, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""ModuleNumber"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""Module"" placeholder=""Module"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""ModuleName"">Module Name</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 2165, "\"", 2174, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""ModuleName"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""ModuleName"" placeholder=""Module Name"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""Permission"">Permission</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 2670, "\"", 2679, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""PermissionNumber"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""Permission"" placeholder=""Permission"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""PermissionName"">Permission Name</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 3189, "\"", 3198, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""PermissionName"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""PermissionName"" placeholder=""PermissionName"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""Description"">Description</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 3798, "\"", 3807, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""Description"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""Description"" placeholder=""Description"" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
                <div class=""col-xs-12 col-md-3"">

                    <section class=""boxWrap"">
                        <div class=""box"">
                            <div class=""boxHeader"">
                                <div class=""boxHeaderLeft"">
                                    <h3><span>Actions</span></h3>
                                </div>
                            </div>
                            <div class=""boxBody"">
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-6"">
                                        <button type=""submit"" clas");
                WriteLiteral(@"s=""btn btn-block btn-success btn-flat"" id=""itemEditSave"">Save</button>
                                    </div>
                                    <div class=""col-xs-12 col-md-6"">
                                        <a href=""/Permission"" type=""button"" class=""btn btn-block btn-danger btn-flat"">Discard</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </section>\r\n\r\n<script>\r\n$(\'#openAddCoverModalName\').click(function(e) {\r\n   e.preventDefault();\r\n   $(\'#coverImageModalName\').modal(\'show\');\r\n    \r\n});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591