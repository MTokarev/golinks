#pragma checksum "C:\git\golink\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e5c15dd822a319a93a32e69f011e236b834077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\git\golink\Views\_ViewImports.cshtml"
using golink;

#line default
#line hidden
#line 2 "C:\git\golink\Views\_ViewImports.cshtml"
using golink.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e5c15dd822a319a93a32e69f011e236b834077", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c52dca587efd7d7fbad03712763afc75b1fddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Site>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveSite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\git\golink\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e5c15dd822a319a93a32e69f011e236b8340775472", async() => {
                BeginContext(134, 398, true);
                WriteLiteral(@"
    <div class=""form-row justify-content-center"">
        <div class=""form-group col-md-6"">
            <input type=""text"" name=""aliasToSearch"" class=""form-control"" id=""aliasToSearch"" placeholder=""Search by Alias"">
        </div>
        <div class=""form-group col-md-3"">
            <button type=""submit"" class=""btn btn-secondary btn-block"">Search</button>    
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(539, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(543, 601, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e5c15dd822a319a93a32e69f011e236b8340777943", async() => {
                BeginContext(606, 531, true);
                WriteLiteral(@"
    <div class=""form-row justify-content-center mb-3"">
        <div class=""form-group col-md-3"">
            <input type=""text"" name=""Alias"" class=""form-control"" id=""alias"" placeholder=""Site Alias"">
        </div>
    <div class=""form-group col-md-3"">
        <input type=""text"" name=""Url"" class=""form-control"" id=""url"" placeholder=""Site URL"">
    </div>
    <div class=""form-group col-md-3"">
        <button type=""submit"" class=""btn btn-secondary btn-block"">Create Site Alias</button>
    </div>
        
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1144, 70, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h3 class=\"text-black-50 mb-4\">\r\n");
            EndContext();
#line 35 "C:\git\golink\Views\Home\Index.cshtml"
             if(ViewData["isFromSearch"] == null)
            {

#line default
#line hidden
            BeginContext(1280, 60, true);
            WriteLiteral("                <p>Top 10 visited sites using this app</p>\r\n");
            EndContext();
#line 38 "C:\git\golink\Views\Home\Index.cshtml"
            }else{

#line default
#line hidden
            BeginContext(1360, 38, true);
            WriteLiteral("                <p>Search result</p>\r\n");
            EndContext();
#line 40 "C:\git\golink\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1417, 405, true);
            WriteLiteral(@"</div>

<div class=""text-center"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Alias</th>
                <th scope=""col"">URL</th>
                <th scope=""col"">Accessed</th>
                <th scope=""col>"">LastAccessedUTC</th>
                <th scope=""col"">Delete</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 55 "C:\git\golink\Views\Home\Index.cshtml"
              foreach(var site in Model){

#line default
#line hidden
            BeginContext(1865, 67, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(1933, 10, false);
#line 57 "C:\git\golink\Views\Home\Index.cshtml"
                                        Write(site.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(1943, 54, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1997, "\"", 2013, 1);
#line 58 "C:\git\golink\Views\Home\Index.cshtml"
WriteAttributeValue("", 2004, site.Url, 2004, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2014, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(2032, 8, false);
#line 58 "C:\git\golink\Views\Home\Index.cshtml"
                                                                            Write(site.Url);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 56, true);
            WriteLiteral("</a></td>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(2097, 13, false);
#line 59 "C:\git\golink\Views\Home\Index.cshtml"
                                        Write(site.Accessed);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 52, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(2163, 21, false);
#line 60 "C:\git\golink\Views\Home\Index.cshtml"
                                        Write(site.LastTimeAccessed);

#line default
#line hidden
            EndContext();
            BeginContext(2184, 78, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(2262, 331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e5c15dd822a319a93a32e69f011e236b83407714035", async() => {
                BeginContext(2348, 47, true);
                WriteLiteral("\r\n                                <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2395, "\"", 2414, 1);
#line 63 "C:\git\golink\Views\Home\Index.cshtml"
WriteAttributeValue("", 2403, site.Alias, 2403, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2415, 171, true);
                WriteLiteral(" type=\"text\" name=\"alias\" class=\"form-control\">\r\n                            <button type=\"submit\" class=\"btn btn-link btn-block\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2593, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 68 "C:\git\golink\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2661, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 75 "C:\git\golink\Views\Home\Index.cshtml"
  if(!string.IsNullOrEmpty(ViewData["messageToShow"] as string)){
    

#line default
#line hidden
            DefineSection("ShowModal", async() => {
                BeginContext(2847, 107, true);
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            $(\'#myModal\').modal(\'show\')\r\n        </script>\r\n    ");
                EndContext();
            }
            );
#line 80 "C:\git\golink\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(2961, 438, true);
            WriteLiteral(@"
<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""myModal"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Info</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>");
            EndContext();
            BeginContext(3400, 25, false);
#line 93 "C:\git\golink\Views\Home\Index.cshtml"
      Write(ViewData["messageToShow"]);

#line default
#line hidden
            EndContext();
            BeginContext(3425, 191, true);
            WriteLiteral("</p>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Site>> Html { get; private set; }
    }
}
#pragma warning restore 1591
