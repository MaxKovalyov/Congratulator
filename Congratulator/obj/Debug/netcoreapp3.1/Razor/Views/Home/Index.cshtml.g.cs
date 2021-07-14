#pragma checksum "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b59ad84a360fddbf13c1f30b8efed462d13b7ae"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b59ad84a360fddbf13c1f30b8efed462d13b7ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c47c6d07e32396f240f2633a4bb4dae26902ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonListViewModel>
    {
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
#line 15 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
              

                int i = 1;
                foreach (var person in Model.somePersons)
                {
                    string dayStr, monthStr, classTr;
                    dayStr = (person.dayBirth < 10) ? "0" + person.dayBirth : Convert.ToString(person.dayBirth);
                    monthStr = (person.monthBirth < 10) ? "0" + person.monthBirth : Convert.ToString(person.monthBirth);
                    classTr = (person.monthBirth == NowDate.nowMonth && person.dayBirth == NowDate.nowDay) ? "bg-success" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=", 1035, "", 1050, 1);
#nullable restore
#line 24 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
WriteAttributeValue("", 1042, classTr, 1042, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <th scope=\"row\">");
#nullable restore
#line 25 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 26 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(dayStr);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 28 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                               Write(monthStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                       Write(person.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"action-td\"><a");
            BeginWriteAttribute("href", " href=\"", 1345, "\"", 1352, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"table-button\">Update</a></td>\r\n                        <td class=\"action-td\"><a");
            BeginWriteAttribute("href", " href=\"", 1440, "\"", 1447, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"table-button\">Delete</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "D:\Учеба\SolarTestTask\Congratulator\Views\Home\Index.cshtml"
                    i++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"place-buttons\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1649, "\"", 1656, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"action-button\">Create</a>\r\n</div>\r\n");
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
