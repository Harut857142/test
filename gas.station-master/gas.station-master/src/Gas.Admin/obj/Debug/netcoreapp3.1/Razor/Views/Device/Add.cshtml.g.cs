#pragma checksum "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Device\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8327d9b157d24e07329317479f0f4152b271c2e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Add), @"mvc.1.0.view", @"/Views/Device/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8327d9b157d24e07329317479f0f4152b271c2e1", @"/Views/Device/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a67073476b22c37699e082863fa1a91950662fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DeviceAddForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Device", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Device\Add.cshtml"
  
    ViewData["Title"] = "Devices";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""contentWrapTop"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""contentWrapTopLeft"">
                    <h1>Device</h1>
                </div>
                <div class=""contentWrapTopRight"">
                    <ul>
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-edit""></i>
                                <span>Device</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <section class=""contentWrap"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8327d9b157d24e07329317479f0f4152b271c2e15786", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-xs-12 col-md-9 loaderHolder"">
                    <section class=""boxWrap"">
                        <div class=""box"">
                            <div class=""boxHeader"">
                                <div class=""boxHeaderLeft"">
                                    <h3><span>Device details</span></h3>
                                </div>
                            </div>
                            <div class=""boxBody"">
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""DeviceName"">Device Name</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 1651, "\"", 1660, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceName"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""DeviceName"" placeholder=""DeviceName"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""Key"">Key</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 2141, "\"", 2150, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""Key"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""Key"" placeholder=""Key"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-4"">
                                        <div class=""form-group"">
                                            <label for=""Description"">Description</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 2717, "\"", 2726, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""Description"" type=""text"" class=""form-control collectItemEdit"" data-valid=""1"" id=""Description"" placeholder=""Description"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowauto"">flowauto</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 3311, "\"", 3320, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowauto"" type=""text"" class=""form-control collectItemEdit"" id=""flowauto"" placeholder=""flowauto"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""dppastaci"">dppastaci</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 3805, "\"", 3814, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.dppastaci"" type=""text"" class=""form-control collectItemEdit"" id=""dppastaci"" placeholder=""dppastaci"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""dpdrac"">dpdrac</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 4296, "\"", 4305, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.dpdrac"" type=""text"" class=""form-control collectItemEdit"" id=""dpdrac"" placeholder=""dpdrac"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""dpgorcakic"">dpgorcakic</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 4786, "\"", 4795, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.dpgorcakic"" type=""text"" class=""form-control collectItemEdit"" id=""dpgorcakic"" placeholder=""dpgorcakic"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowpast"">flowpast</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 5284, "\"", 5293, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowpast"" type=""text"" class=""form-control collectItemEdit"" id=""flowpast"" placeholder=""flowpast"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowsarqac"">flowsarqac</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 5780, "\"", 5789, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowsarqac"" type=""text"" class=""form-control collectItemEdit"" id=""flowsarqac"" placeholder=""flowsarqac"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowhanac"">flowhanac</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 6371, "\"", 6380, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowhanac"" type=""text"" class=""form-control collectItemEdit"" id=""flowhanac"" placeholder=""flowhanac"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""kgorcakic"">kgorcakic</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 6868, "\"", 6877, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.kgorcakic"" type=""text"" class=""form-control collectItemEdit"" id=""kgorcakic"" placeholder=""kgorcakic"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""selfonoff"">selfonoff</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 7365, "\"", 7374, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.selfonoff"" type=""text"" class=""form-control collectItemEdit"" id=""selfonoff"" placeholder=""selfonoff"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowmax"">flowmax</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 7858, "\"", 7867, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowmax"" type=""text"" class=""form-control collectItemEdit"" id=""flowmax"" placeholder=""flowmax"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowproc"">flowproc</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 8347, "\"", 8356, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.flowproc"" type=""text"" class=""form-control collectItemEdit"" id=""flowproc"" placeholder=""flowproc"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""presspastaci"">presspastaci</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 8847, "\"", 8856, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.presspastaci"" type=""text"" class=""form-control collectItemEdit"" id=""presspastaci"" placeholder=""presspastaci"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""pressgorcakic"">pressgorcakic</label>
                                            <input");
                BeginWriteAttribute("value", "  value=\"", 9452, "\"", 9461, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""DeviceConfig.pressgorcakic"" type=""text"" class=""form-control collectItemEdit"" id=""pressgorcakic"" placeholder=""pressgorcakic"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""onoff"">onoff</label>
                                            <input  value=""true"" name=""DeviceConfig.onoff"" type=""checkbox"" class=""collectItemEdit"" id=""onoff"" placeholder=""onoff"" />
                                        </div>
                                    </div>
                                    <div class=""col-xs-12 col-md-2"">
                                        <div class=""form-group"">
                                            <label for=""flowAutoOnoff"">flowAutoOnoff</label>
                                            <input  value=""true"" name=""DeviceConfig.flowAutoOno");
                WriteLiteral(@"ff"" type=""checkbox"" class=""collectItemEdit"" id=""flowAutoOnoff"" placeholder=""flowAutoOnoff"" />
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
                                        <button type=""submit"" class=""btn btn-block btn-success btn-fla");
                WriteLiteral(@"t"" id=""itemEditSave"">Save</button>
                                    </div>
                                    <div class=""col-xs-12 col-md-6"">
                                        <a href=""/Device"" type=""button"" class=""btn btn-block btn-danger btn-flat"">Discard</a>
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
