#pragma checksum "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb919036598a3ba54db80dd7cc83e81d8ef0f1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_Delete), @"mvc.1.0.view", @"/Views/Answers/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb919036598a3ba54db80dd7cc83e81d8ef0f1d", @"/Views/Answers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c4f720571719f195a1f2032f42545b279534d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJECT_QUIZ.Models.Models.Answers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Answers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnswerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnswerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QuestionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnswerText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnswerText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Correct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\Answers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Correct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cb919036598a3ba54db80dd7cc83e81d8ef0f1d7399", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJECT_QUIZ.Models.Models.Answers> Html { get; private set; }
    }
}
#pragma warning restore 1591
