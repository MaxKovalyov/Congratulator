#pragma checksum "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86d1274ff769356e3c26f7cddbd7963afc2b86a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BirthdayPeople_Index), @"mvc.1.0.view", @"/Views/BirthdayPeople/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d1274ff769356e3c26f7cddbd7963afc2b86a5", @"/Views/BirthdayPeople/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c47c6d07e32396f240f2633a4bb4dae26902ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_BirthdayPeople_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<hr>\r\n");
#nullable restore
#line 2 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
  
    int i = 0;
    foreach (var person in Model.birthdayPersons)
    {
        string day, month;
        if (person.dayBirth < 10)
        {
            day = "0" + person.dayBirth;
        }
        else
        {
            day = Convert.ToString(person.dayBirth);
        }
        if (person.monthBirth < 10)
        {
            month = "0" + person.monthBirth;
        }
        else
        {
            month = Convert.ToString(person.monthBirth);
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-7\">\r\n                <h2>");
#nullable restore
#line 25 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
               Write(person.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"lead\">Date: ");
#nullable restore
#line 26 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
                                 Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 26 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
                                      Write(month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"lead\">Category: ");
#nullable restore
#line 27 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
                                     Write(person.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-5\">\r\n                <img class=\"img-fluid mx-auto\" alt=\"300x300\" style=\"width: 300px; height: 300px;\"");
            BeginWriteAttribute("src", " src=\"", 874, "\"", 894, 1);
#nullable restore
#line 30 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
WriteAttributeValue("", 880, person.urlImg, 880, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-holder-rendered=\"true\">\r\n            </div>\r\n        </div>\r\n        <hr>\r\n");
#nullable restore
#line 34 "D:\Учеба\SolarTestTask\Congratulator\Views\BirthdayPeople\Index.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
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
