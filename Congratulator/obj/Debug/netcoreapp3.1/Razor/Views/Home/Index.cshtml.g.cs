#pragma checksum "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b906f668e344c8f9b3b0338324722b0df51d4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Учеба\SolarTestTask\Congratulator\Views\_ViewImports.cshtml"
using Congratulator.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Учеба\SolarTestTask\Congratulator\Views\_ViewImports.cshtml"
using Congratulator.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Учеба\SolarTestTask\Congratulator\Views\_ViewImports.cshtml"
using Congratulator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b906f668e344c8f9b3b0338324722b0df51d4d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0307f5008697b54432a373907ae9b5122ef7575", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div>
    <table class=""table table-striped"">
        <thead class=""thead-red"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">ID</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Date birthday</th>
                <th scope=""col"">Category</th>
                <th scope=""col"">Update</th>
                <th scope=""col"">Delete</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
              

                int i = 1;
                foreach (var person in Model.somePersons)
                {
                    string dayStr, monthStr, classTr;
                    dayStr = (person.DayBirth < 10) ? "0" + person.DayBirth : Convert.ToString(person.DayBirth);
                    monthStr = (person.MonthBirth < 10) ? "0" + person.MonthBirth : Convert.ToString(person.MonthBirth);
                    classTr = (person.MonthBirth == NowDate.nowMonth && person.DayBirth == NowDate.nowDay) ? "bg-success" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=", 1063, "", 1078, 1);
#nullable restore
#line 25 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
WriteAttributeValue("", 1070, classTr, 1070, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <th scope=\"row\">");
#nullable restore
#line 26 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 27 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(dayStr);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 29 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                               Write(monthStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"action-td\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b906f668e344c8f9b3b0338324722b0df51d4d6709", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1380, "~/Update/Index/", 1380, 15, true);
#nullable restore
#line 31 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1395, person.Id, 1395, 10, false);

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
            WriteLiteral("</td>\r\n                        <td class=\"action-td\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b906f668e344c8f9b3b0338324722b0df51d4d8357", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1500, "~/Home/Delete/", 1500, 14, true);
#nullable restore
#line 32 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1514, person.Id, 1514, 10, false);

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
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                    i++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"place-buttons\">\r\n    <a href=\"/Create/Index\" class=\"action-button\">Create</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
