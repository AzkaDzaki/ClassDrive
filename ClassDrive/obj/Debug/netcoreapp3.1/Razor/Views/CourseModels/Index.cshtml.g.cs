#pragma checksum "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5064a1c7bee55dddcc737594fe86b0cacf476c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseModels_Index), @"mvc.1.0.view", @"/Views/CourseModels/Index.cshtml")]
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
#line 1 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\_ViewImports.cshtml"
using ClassDrive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\_ViewImports.cshtml"
using ClassDrive.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5064a1c7bee55dddcc737594fe86b0cacf476c", @"/Views/CourseModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b0f527550ac282ae232008014f13a9153b80e8", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClassDrive.Models.CourseModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5064a1c7bee55dddcc737594fe86b0cacf476c3523", async() => {
                WriteLiteral(@"
    <style>
        body {
            height: 100%;
            background-color: #f2f2f2;
        }

        nav {
            background-color: #ffffff;
            height: 76px;
        }

        .navbar-brand {
            color: #4f4f4f;
            font-weight: 700;
        }

        .nav-link {
            color: #4f4f4f;
        }

        .card {
            border: none;
        }

        .class-schedule {
            text-align: end;
        }

        .btn-save {
            background-color: #9C69E2;
            border: 2px solid #9C69E2;
            color: #ffffff;
            border-radius: 8px;
            width: 48%;
            float: right;
        }
        .btn-text {
            color: #ffffff;
            text-decoration: none;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5064a1c7bee55dddcc737594fe86b0cacf476c5321", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 2469, "\"", 2477, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 94 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""col-3"" style="" margin-top:4%;"">
                <div class=""card"" style=""width: 15rem;"">
                    <div class=""card-body"">
                        <div class=""row mb-4"">
                            <div class=""col-6"">
                                <img src=""https://i.imgur.com/1lxAxm7.png""");
                BeginWriteAttribute("alt", " alt=\"", 2896, "\"", 2902, 0);
                EndWriteAttribute();
                BeginWriteAttribute("srcset", " srcset=\"", 2903, "\"", 2912, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <p class=\"class-schedule justify-content-end\">");
#nullable restore
#line 104 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.CourseSchedule));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 107 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.CourseTeacher));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h5 class=\"card-title mb-2\">");
#nullable restore
#line 108 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CourseName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 109 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.CourseDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <button type=\"button\" class=\"btn btn-save floated\">");
#nullable restore
#line 110 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                                                                      Write(Html.ActionLink("Klik", "ContentList", "ContentModels", new { CourseID = item.CourseID }, new { @style = "color:#ffffff;text-decoration:none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>");
#nullable restore
#line 113 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\CourseModels\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClassDrive.Models.CourseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591