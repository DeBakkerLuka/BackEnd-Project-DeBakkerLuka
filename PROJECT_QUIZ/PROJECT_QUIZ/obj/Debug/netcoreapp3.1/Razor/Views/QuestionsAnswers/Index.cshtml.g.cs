#pragma checksum "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "975447efa5c809804050401079b0480fab1c837c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestionsAnswers_Index), @"mvc.1.0.view", @"/Views/QuestionsAnswers/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
using PROJECT_QUIZ.Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975447efa5c809804050401079b0480fab1c837c", @"/Views/QuestionsAnswers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c4f720571719f195a1f2032f42545b279534d1", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestionsAnswers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsAnswers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Answers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Questions And Answers In Quiz</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975447efa5c809804050401079b0480fab1c837c5312", async() => {
                WriteLiteral("Create New Question");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
                                                        WriteLiteral(ViewBag.QuizId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<h2>Vragen</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Vraag ID</th>\r\n        <th>Vraag Text</th>\r\n        <th>Quiz ID</th>\r\n        <th>Image</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
     foreach (var item in Model.Questions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.QuestionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.QuizID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.ImageString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975447efa5c809804050401079b0480fab1c837c9810", async() => {
                WriteLiteral("Add Answer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
                                                              WriteLiteral(item.QuestionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975447efa5c809804050401079b0480fab1c837c12271", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
                                                                WriteLiteral(item.QuestionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n");
#nullable restore
#line 35 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</tr>\r\n");
#nullable restore
#line 39 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<h2>Antwoorden</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Vraag</th>\r\n        <th>Antwoord ID</th>\r\n        <th>Antwoord Text</th>\r\n        <th>Correct?</th>\r\n    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
     foreach (var item in Model.Answers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 53 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.QuestionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 54 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.AnswerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 55 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.AnswerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 56 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
   Write(item.Correct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975447efa5c809804050401079b0480fab1c837c17328", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
                                                              WriteLiteral(item.AnswerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n");
#nullable restore
#line 63 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Luka De Bakker\Documents\SCHOOL - SEM 4\Backend Development\Project\PROJECT_QUIZ\PROJECT_QUIZ\Views\QuestionsAnswers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsAnswers> Html { get; private set; }
    }
}
#pragma warning restore 1591
