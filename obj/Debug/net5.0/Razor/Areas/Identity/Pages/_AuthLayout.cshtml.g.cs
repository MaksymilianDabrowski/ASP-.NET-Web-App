#pragma checksum "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd5299209f7d6db355cc5f139578b41104663a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_ViewImports.cshtml"
using Password_Keep.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_ViewImports.cshtml"
using Password_Keep.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_ViewImports.cshtml"
using Password_Keep.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5299209f7d6db355cc5f139578b41104663a1b", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7895ca1476f82726950e8d6e4ef23af1a63662f0", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_AuthLayout.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-md-8 offset-md-2"">
		<div class=""card login-logout-tab"">
			<div class=""card-header"">
				<ul class=""nav nav-tabs card-header-tabs"">
					<li class=""nav-item"">
						<a class=""nav-link"" href=""Login"">Sign In</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""Register"">Sign Up</a>
					</li>
				</ul>
			</div>
			<div class=""card-content"">
				<div class=""row"">
					<div class=""col-md-12"">
						");
#nullable restore
#line 21 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div> \r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
#nullable restore
#line 31 "C:\Users\Maksd\source\repos\Password_Keep_Project\Password_Keep\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\r\n<script>\r\n\t$(function () {\r\n\t\tvar current = location.pathname;\r\n\t\t$(\'.nav-tabs li a\').each(function () {\r\n\t\t\tvar $this = $(this);\r\n\t\t\tif(current.indexOf($this.attr(\'href\')) !== -1) {\r\n\t\t\t\t$this.addClass(\'active\'):\r\n\t\t\t}\r\n\t\t})\r\n\t})\r\n</script>\r\n\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
