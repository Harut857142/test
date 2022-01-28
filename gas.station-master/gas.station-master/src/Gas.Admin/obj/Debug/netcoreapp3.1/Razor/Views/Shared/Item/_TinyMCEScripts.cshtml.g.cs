#pragma checksum "C:\Users\harut\OneDrive\Рабочий стол\gas.station\src\Gas.Admin\Views\Shared\Item\_TinyMCEScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9809fe8182f533dd68eea4fd23a5bcc6638aae10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Item__TinyMCEScripts), @"mvc.1.0.view", @"/Views/Shared/Item/_TinyMCEScripts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9809fe8182f533dd68eea4fd23a5bcc6638aae10", @"/Views/Shared/Item/_TinyMCEScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a67073476b22c37699e082863fa1a91950662fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Item__TinyMCEScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
$(document).ready(function() {
    // TinyMCE service
    
    /*****Main Function******/
    window.tinyMCEServiceClass = function () {
        var _self = this;
    
        function init() {
    
            bindMainEvents();
        }
    
        _self.Bind = function() {
            init();
    
        };
        _self.BindSendMail = function() {
            initSendMail();
    
        };
    
        function initSendMail() {
    
            tinymce.init({
                orced_root_block : """",
                relative_urls : false,            remove_script_host : false,
                selector: 'textarea',
                toolbar: ""...| removeformat | ..."",
                plugins: [
                    'link pagebreak'
                ],
                toolbar1: 'undo redo | link',
                toolbar2: 'print preview | codesample',
                image_advtab: true,
                templates: [
                    { title: 'Test template 1', con");
            WriteLiteral(@"tent: 'Test 1' },
                    { title: 'Test template 2', content: 'Test 2' }
                ],
                content_css: [
                    '//fonts.googleapis.com/css?family=Lato:300,300i,400,400i',
                    '//www.tinymce.com/css/codepen.min.css'
                ],
                setup: function (editor) {
                    editor.on('change', function () {
                        debugger
                        tinymce.triggerSave();
                    });
                }
            });
        };
    
        function bindMainEvents() {
    
            tinymce.init({            relative_urls : false,            remove_script_host : false,
                selector: 'textarea',
                plugins: [
                    'advlist autolink lists link image charmap print preview hr anchor pagebreak',
                    'searchreplace wordcount visualblocks visualchars code fullscreen',
                    'insertdatetime media nonbreaking save tab");
            WriteLiteral(@"le contextmenu directionality',
                    'emoticons template paste textcolor colorpicker textpattern imagetools codesample toc'
                ],
                toolbar1: 'undo redo | insert | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image',
                toolbar2: 'print preview media | forecolor backcolor emoticons | codesample',
                image_advtab: true,
                templates: [
                    { title: 'Test template 1', content: 'Test 1' },
                    { title: 'Test template 2', content: 'Test 2' }
                ],
                content_css: [
                    '//fonts.googleapis.com/css?family=Lato:300,300i,400,400i',
                    '//www.tinymce.com/css/codepen.min.css'
                ]
            });
        }
    };
    /************************/
});
</script>");
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