#pragma checksum "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad12595e01d4531a44d606c618b53b8021a87f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\_ViewImports.cshtml"
using FIRST_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\_ViewImports.cshtml"
using FIRST_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\_ViewImports.cshtml"
using FIRST_MVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad12595e01d4531a44d606c618b53b8021a87f95", @"/Areas/Admin/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6658861432de3cade01a0461817c83d207214cef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>This Product CategoryId is ");
#nullable restore
#line 6 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\Product\Detail.cshtml"
                          Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>This Product Category Name is ");
#nullable restore
#line 7 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Areas\Admin\Views\Product\Detail.cshtml"
                             Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
