#pragma checksum "C:\Users\chant\Desktop\IT-Capstone\ProjectTwo\FitKit\Views\Home\Diet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d427216dd7e1264f7763169f3d1ad3b9fe58b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Diet), @"mvc.1.0.view", @"/Views/Home/Diet.cshtml")]
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
#line 1 "C:\Users\chant\Desktop\IT-Capstone\ProjectTwo\FitKit\Views\_ViewImports.cshtml"
using FitKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chant\Desktop\IT-Capstone\ProjectTwo\FitKit\Views\_ViewImports.cshtml"
using FitKit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d427216dd7e1264f7763169f3d1ad3b9fe58b25", @"/Views/Home/Diet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9e103cff8fa2cad4c7c724c9aec68975a83eef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Diet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\chant\Desktop\IT-Capstone\ProjectTwo\FitKit\Views\Home\Diet.cshtml"
  
    ViewBag.Title = "Diet Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d427216dd7e1264f7763169f3d1ad3b9fe58b253212", async() => {
                WriteLiteral(@"
    <style>
        /* ---- CODE FOR ACCORDION ---- */
        .accordion {
            background-color: #eee;
            /* color: #444; */
            cursor: pointer;
            padding: 18px;
            width: 100%;
            text-align: left;
            font-size: 17px;
            border: none;
            outline: none;
            transition: 0.4s;
        }

            /* Add a background color to the button if it is clicked on (add the .active class with JS), and when you move the mouse over it (hover) */
            .active, .accordion:hover {
                background-color: #FF0000;
                color: #fff;
            }

            .accordion:after {
                content: ""\002B"";
                float: right;
                margin-left: 15px;
            }

        /* Style the accordion panel. Note: hidden by default */
        .panel {
            padding: 0 18px;
            background-color: white;
            display: none;
            ov");
                WriteLiteral(@"erflow: hidden;
            /* color: #fff; */
        }

        .active:after {
            content: ""\2212"";
            float: right;
        }
    </style>

    <h1>Diets</h1>
    <button class=""accordion"">Diet 1</button>
        <div class=""panel"">
            <p>A B C D E</p>
        </div>
    <button class=""accordion"">Diet 2</button>
        <div class=""panel"">
            <p>A B C D E</p>
            <ul>
                <li>Coffee</li>
                <li>Tea</li>
                <li>Milk</li>
            </ul>
        </div>
    <button class=""accordion"">Diet 3</button>
        <div class=""panel"">
            <p>A B C D E</p>
        </div>

    <script>
        var acc = document.getElementsByClassName(""accordion"");
        var i;

        for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener(""click"", function () {
                /* Toggle between adding and removing the ""active"" class,
                to highlight the button that controls the");
                WriteLiteral(@" panel */
                this.classList.toggle(""active"");

                /* Toggle between hiding and showing the active panel */
                var panel = this.nextElementSibling;
                if (panel.style.display === ""block"") {
                    panel.style.display = ""none"";
                } else {
                    panel.style.display = ""block"";
                }
            });
        }
    </script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
