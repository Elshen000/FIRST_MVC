#pragma checksum "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd892e5ae03609841b6e392ff1bf8cdf57ed4324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\_ViewImports.cshtml"
using FIRST_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\_ViewImports.cshtml"
using FIRST_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\_ViewImports.cshtml"
using FIRST_MVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd892e5ae03609841b6e392ff1bf8cdf57ed4324", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be95c0bde15d66b5479d70ce7e13b48acfa847ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div  class=""my-3 d-flex justify-content-center"" style=""padding:30px;"">
    <div class=""col-lg-8 border p-3 main-section bg-white"">
        <div class=""row hedding m-0 pl-3 pt-0 pb-3"">
            <h3>Məhsul</h3>
        </div>
        <div class=""row m-0"">
            <div class=""col-lg-4 left-side-product-box pb-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd892e5ae03609841b6e392ff1bf8cdf57ed43244281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 416, "~/img/", 416, 6, true);
#nullable restore
#line 14 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 422, Model.Image, 422, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-lg-8"">
                <div class=""right-side-pro-detail border p-3 m-0"">
                    <div class=""justify-content-lg-end"">
                        <div class=""col-lg-12"">
                            <h5 class=""m-0 p-0"">Ad</h5>
                        </div>
                        <div class=""col-lg-12"">
                            <p class=""m-0 p-0 price-pro"">");
#nullable restore
#line 23 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml"
                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <hr class=""p-0 m-0"">
                        </div>
                        <div class=""col-lg-12"">
                            <h5 class=""m-0 p-0"">Qiymət</h5>
                        </div>
                        <div class=""col-lg-12"">
                            <p class=""m-0 p-0 price-pro"">");
#nullable restore
#line 30 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml"
                                                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" AZN</p>
                            <hr class=""p-0 m-0"">
                        </div>
                        <div class=""col-lg-12"">
                            <h5 class=""m-0 p-0"">Kateqoriya</h5>
                        </div>
                        <div class=""col-lg-12"">
                            <p class=""m-0 p-0 price-pro"">");
#nullable restore
#line 37 "C:\Users\user\OneDrive\İş masası\git\FIRST_MVC\FIRST_MVC\FIRST_MVC\Views\Shop\Detail.cshtml"
                                                    Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <hr class=""p-0 m-0"">
                        </div>
                        <div class=""col-lg-12 pt-2"">
                            <h5>Məhsul Detalları</h5>
                            <span>
                                Bu gün floristlər tərəfindən təqdim edilən çiçəklərin böyük seçiminə baxmayaraq, sevgi və arzuları simvolizə edən hər kəsin sevdiyi gül, 
                                populyarlıqlarını heç vaxt itirmə. Janrın klassikləri, təqsirsizlik və təmizliyin təcəssümü - ağ və ya krem ​​güllərin bir buketidir.
                                Bir buketi daha parlaq olun, kölgəlik və göyərtəsiz gökadaların uzun yarpaqları yaradılan kontrasta kömək edəcəkdir. Bu ekzotik bitkilər də 
                                qırmızı və ya çəhrayı güllərin bir rəngli toy kveti ilə bəzədilib. İstixana jasmine, clematis və ferns tərəfindən xüsusi bir romantik və şık not 
                                təqdim olunur.
                            </span>
               ");
            WriteLiteral(@"             <hr class=""m-0 pt-2 mt-2"">
                        </div>


                        <div class=""col-lg-12"">
                            <h6>Say :</h6>
                            <input type=""number"" class=""form-control text-center w-100"" value=""1"">
                        </div>
                        <div class=""col-lg-12 mt-3"">
                            <div class=""row"">
                                <div class=""col-lg-6 pb-2"">
                                    <a href=""#"" class=""btn btn-danger w-100"">Kart əlavə et</a>
                                </div>
                                <div class=""col-lg-6"">
                                    <a href=""#"" class=""btn btn-success w-100"">sebete elave et</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
       
    </div>
</div>

");
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
