#pragma checksum "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc1ccd8348fab23819b1bcccfe9289b9b154b69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Details), @"mvc.1.0.view", @"/Views/Questions/Details.cshtml")]
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
#line 1 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\_ViewImports.cshtml"
using PROJECT_QUIZ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\_ViewImports.cshtml"
using PROJECT_QUIZ.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc1ccd8348fab23819b1bcccfe9289b9b154b69", @"/Views/Questions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c4f720571719f195a1f2032f42545b279534d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJECT_QUIZ.Models.Models.Questions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
  
    var imgSrc = "";
    ViewData["Title"] = "Details";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
     if (Model.ImageData != null) 
    {
        var base64 = Convert.ToBase64String(Model.ImageData);
        imgSrc = String.Format("data:image/gif;base64,{0}", base64);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Questions</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuestionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuizID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuizID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1186, "\"", 1199, 1);
#nullable restore
#line 42 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Questions\Details.cshtml"
WriteAttributeValue("", 1192, imgSrc, 1192, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJECT_QUIZ.Models.Models.Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591