#pragma checksum "C:\Users\www12\Desktop\NetCoreBlog\NetCoreBlog\Views\Login\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed94ef9c227fb045235dcd6ce678864d572f77cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_AccessDenied), @"mvc.1.0.view", @"/Views/Login/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/AccessDenied.cshtml", typeof(AspNetCore.Views_Login_AccessDenied))]
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
#line 1 "C:\Users\www12\Desktop\NetCoreBlog\NetCoreBlog\Views\_ViewImports.cshtml"
using NetCoreBlog;

#line default
#line hidden
#line 2 "C:\Users\www12\Desktop\NetCoreBlog\NetCoreBlog\Views\_ViewImports.cshtml"
using NetCoreBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed94ef9c227fb045235dcd6ce678864d572f77cb", @"/Views/Login/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86e46a2c04fd5b374d7c876196cea98e97c146af", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\www12\Desktop\NetCoreBlog\NetCoreBlog\Views\Login\AccessDenied.cshtml"
  
    ViewData["Title"] = "AccessDenied";

#line default
#line hidden
            BeginContext(50, 276, true);
            WriteLiteral(@"
<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 30px;"">
    <legend>用户权限不足</legend>
</fieldset>

<blockquote class=""layui-elem-quote"">
    权限不足，请联系管理员或更换身份登录
    <a class=""layui-btn layui-btn-normal"" href=""/Login/Logout"">重新登录</a>
</blockquote>");
            EndContext();
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
