#pragma checksum "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780bf98f37d75429510ab8c2254ba2a12a09ddc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubmitModels_SubmitList), @"mvc.1.0.view", @"/Views/SubmitModels/SubmitList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780bf98f37d75429510ab8c2254ba2a12a09ddc6", @"/Views/SubmitModels/SubmitList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b0f527550ac282ae232008014f13a9153b80e8", @"/Views/_ViewImports.cshtml")]
    public class Views_SubmitModels_SubmitList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClassDrive.Models.SubmitModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
  
    ViewData["Title"] = "SubmitList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc64601", async() => {
                WriteLiteral(@"
    <style>
        html, body {
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

        .btn-upload {
            background-color: #9C69E2;
            border: 2px solid #9C69E2;
            color: #ffffff;
            border-radius: 8px;
            width: 100%;
            float: right;
            transition: 300ms;
        }

            .btn-upload:hover {
                background-color: #a97aec;
                border: 2px solid #a97aec;
                color: #ffffff;
                border-radius: 8px;
                width: 100%;
                float: right;
         ");
                WriteLiteral(@"       transition: 300ms;
            }

        table {
            border-collapse: separate;
            border-spacing: 0 10px;
        }

        tbody {
            border: none;
            background-color: #ffffff;
        }

            tbody > tr {
                cursor: pointer;
                transition: 300ms;
                color: #000000;
            }

                tbody > tr:hover {
                    box-shadow: 0px 4px 10px rgb(112, 144, 176, 0.2);
                    transition: 500ms;
                }

        tr > td > .icon-table {
            color: #000000;
            transition: 300ms;
        }

            tr > td > .icon-table:hover {
                color: #9C69E2;
                transition: 300ms;
            }

        .table-borderless > tbody > tr > td,
        .table-borderless > tbody > tr > th,
        .table-borderless > tfoot > tr > td,
        .table-borderless > tfoot > tr > th,
        .table-borderless > thead > tr > t");
                WriteLiteral(@"d,
        .table-borderless > thead > tr > th {
            border: none;
        }

        /* nth-child(1) = the first td in each tr */


        /* the second */
        td:nth-child(1) {
            width: 350px;
        }

        /* the third */
        td:nth-child(2) {
            width: 300px;
        }

        /* the third */
        td:nth-child(3) {
            width: 200px;
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc68122", async() => {
                WriteLiteral(@"

    <div style="" margin-top:1%;"">
        <div class=""row"">
            <div class=""col-3"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row mb-4"">
                            <div class=""col-6"">
                                <img src=""https://i.imgur.com/1lxAxm7.png""");
                BeginWriteAttribute("alt", " alt=\"", 2961, "\"", 2967, 0);
                EndWriteAttribute();
                BeginWriteAttribute("srcset", " srcset=\"", 2968, "\"", 2977, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <p class=\"class-schedule justify-content-end\">");
#nullable restore
#line 128 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                         Write(ViewBag.SubmitList.TaskDeadline);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 131 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                             Write(ViewBag.SubmitList.TaskTeacher);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h5 class=\"card-title mb-2\">");
#nullable restore
#line 132 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                               Write(ViewBag.SubmitList.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 133 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                        Write(ViewBag.SubmitList.TaskDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 134 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                         if (User.IsInRole("Mahasiswa"))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"card-button\">\r\n                                <button type=\"button\" class=\"btn btn-upload floated\">");
#nullable restore
#line 137 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                                Write(Html.ActionLink("Upload File", "CreateSubmit", "SubmitModels", new { TaskID = ViewBag.SubmitList.TaskID }, new { @style = "text-decoration:none;color:#fff;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
                WriteLiteral("                            </div>\r\n");
#nullable restore
#line 140 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-9"">
                <table class=""table table-borderless"">
                    <thead>
                        <tr>
                            <th scope=""col"">Student Name</th>
                            <th scope=""col"">Submit Date</th>
                            <th scope=""col"">Score</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 153 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 157 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SubmitName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 158 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                Write(Html.DisplayFor(modelItem => item.SubmitTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 159 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                 if (item.SubmitScore == null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     if (User.IsInRole("Dosen"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc614084", async() => {
                    WriteLiteral("Not graded");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                   WriteLiteral(item.SubmitID);

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
                WriteLiteral("</td>\r\n");
#nullable restore
#line 164 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     if (User.IsInRole("Mahasiswa"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>Not graded</td>\r\n");
#nullable restore
#line 168 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     if (User.IsInRole("Dosen"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td> ");
#nullable restore
#line 174 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.SubmitScore));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc618219", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 174 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                                                                      WriteLiteral(item.SubmitID);

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
                WriteLiteral("</td>\r\n");
#nullable restore
#line 175 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     if (User.IsInRole("Mahasiswa"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td> ");
#nullable restore
#line 179 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.SubmitScore));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 180 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc621992", async() => {
                    WriteLiteral("<span class=\"fa fa-download\"></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filename", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                     WriteLiteral(item.SubmitDescription);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filename"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filename", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filename"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n");
#nullable restore
#line 184 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                 if (User.IsInRole("Mahasiswa"))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780bf98f37d75429510ab8c2254ba2a12a09ddc624707", async() => {
                    WriteLiteral("<span class=\"fa fa-trash\"></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                                                 WriteLiteral(item.SubmitID);

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
                WriteLiteral("</td>\r\n");
#nullable restore
#line 187 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 190 "D:\Kuliah\TUGAS AKHIR WEB\ClassDrive-master\ClassDrive\Views\SubmitModels\SubmitList.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </table>
            </div>
        </div>
    </div>


    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClassDrive.Models.SubmitModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
