#pragma checksum "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bc8e80504b7956fbfec3d27b65933e53a2699c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SlideMenuPartial), @"mvc.1.0.view", @"/Views/Shared/_SlideMenuPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
using Gas.Shared.Models.Core.Auth;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55bc8e80504b7956fbfec3d27b65933e53a2699c", @"/Views/Shared/_SlideMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a67073476b22c37699e082863fa1a91950662fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SlideMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
  
    bool hasPermission = authorizeUserHelper.HasPermission(User);
    string controllerName = this.ViewContext.RouteData.Values["controller"].ToString();
//    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
//    var showBanner = !consentFeature?.CanTrack ?? false;
//    var cookieString = consentFeature?.CreateConsentCookie();
    
    var isAdmin = authorizeUserHelper.HasPermission(User, (int)Modules.User, new int[] { (int)UserModule.Edit });

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
 if (hasPermission)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""mtSidebar"">
            <div class=""sidebar-menu"">
                <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                    <div class=""panel panel-default panel-bg"">
                        <div class=""panel-heading"" role=""tab"" id=""heading-device"">
                            <h4 class=""panel-title sidebar-title"">
                                <a");
            BeginWriteAttribute("class", " class=\"", 1043, "\"", 1099, 1);
#nullable restore
#line 22 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
WriteAttributeValue("", 1051, controllerName == "Device" ? "" : "collapsed", 1051, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#collapse-device-page"" aria-controls=""collapse-device-page"" data-parent=""#accordion"" role=""button"" data-toggle=""collapse"" aria-expanded=""false"">
                                    <div class=""panel-title-left"">
                                        <i class=""fa fa-users""></i>
                                        <span>Devices</span>
                                    </div>
                                    <div class=""panel-title-right""></div>
                                </a>
                            </h4>
                        </div>
                        <div id=""collapse-device-page"" aria-labelledby=""heading-device""");
            BeginWriteAttribute("class", " class=\"", 1763, "\"", 1876, 2);
            WriteAttributeValue("", 1771, "panel-collapse", 1771, 14, true);
#nullable restore
#line 31 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
WriteAttributeValue(" ", 1785, controllerName == "Permission" || controllerName == "Role" ? "collapse in" : "collapse", 1786, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel"">
                            <div class=""panel-body"">
                                <ul>
                                    <li>
                                        <a href=""/Device/Index"">
                                            <span>List</span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 43 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
                         if (isAdmin)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""panel panel-default panel-bg"">
                                <div class=""panel-heading"" role=""tab"" id=""heading-2"">
                                    <h4 class=""panel-title sidebar-title"">
                                        <a");
            BeginWriteAttribute("class", " class=\"", 2726, "\"", 2814, 1);
#nullable restore
#line 48 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
WriteAttributeValue("", 2734, controllerName == "Permission" || controllerName == "Role" ? "" : "collapsed", 2734, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#collapse-2-page"" aria-controls=""collapse-2-page"" data-parent=""#accordion"" role=""button"" data-toggle=""collapse"" aria-expanded=""false"">
                                            <div class=""panel-title-left"">
                                                <i class=""fa fa-users""></i>
                                                <span>Permission, Roles, Users</span>
                                            </div>
                                            <div class=""panel-title-right""></div>
                                        </a>
                                    </h4>
                                </div>
                                <div id=""collapse-2-page"" aria-labelledby=""heading-2""");
            BeginWriteAttribute("class", " class=\"", 3547, "\"", 3660, 2);
            WriteAttributeValue("", 3555, "panel-collapse", 3555, 14, true);
#nullable restore
#line 57 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
WriteAttributeValue(" ", 3569, controllerName == "Permission" || controllerName == "Role" ? "collapse in" : "collapse", 3570, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel"">
                                    <div class=""panel-body"">
                                        <ul>
                                            <li>
                                                <a href=""/Permission/Index"">
                                                    <span>Permissions</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""/Role/Index"">
                                                    <span>Roles</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""/User/Index"">
                                                    <span>Users</span>
                                                </a>
                                       ");
            WriteLiteral("     </li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 80 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 85 "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\_SlideMenuPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Gas.Shared.Services.AuthorizeUserHelper authorizeUserHelper { get; private set; }
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