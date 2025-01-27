#pragma checksum "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f096ea18a937711f09cacdfabee46dfb27b047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\_ViewImports.cshtml"
using Milestone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\_ViewImports.cshtml"
using Milestone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f096ea18a937711f09cacdfabee46dfb27b047", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c56186b46366aee57c914ee133d6bf1029d996", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Milestone.Models.CellModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mine"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("*asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Game"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HandleLeftClick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .game-button {
        width: 85px;
        height: 85px;
        border: none;
        white-space: nowrap;
        text-align: center;
        background-color: transparent;
        background-repeat: no-repeat;
        overflow: hidden;
        outline: 2px solid black;
        color: white;
        text-align: center;
        position: relative;
    }

    .game-button-image {
        width: 85px;
        height: 85px;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }

    .button-zone {
        display: flex;
        flex-wrap: wrap;
    }

    .line-break {
        flex-basis: 100%;
        height: 0;
    }

    .button-label {
        font-size: 8px;
        text-align: center;
    }

    .cell-zone {
        background-image: url(""/Images/bigField.png"");
        background-repeat: no-repeat;
        background-size: contain;
        resize: both;
    }

    .centered {
        p");
            WriteLiteral("osition: absolute;\r\n        top: 50%;\r\n        left: 50%;\r\n        transform: translate(-50%, -50%);\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
  
    //Add image names for game pieces here!
    string[] gamePieces = { "", "", "" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"cell-zone\">\r\n");
#nullable restore
#line 64 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
     using (@Html.BeginForm("HandleLeftClick", "GameController"))
    {

        for (int i = 0; i < Model.Count(); i++)
        {
            if (i % Math.Sqrt(Model.Count) == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 72 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
            }


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f096ea18a937711f09cacdfabee46dfb27b0476930", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
     if (!Model.ElementAt(i).Visited)
    {
        //<img class="game-button-image" src="~/Images/field.png" />
    }
    else
    {
        if (Model[i].State > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <!--script>alert(\"Game Over!!!\");</!--script-->\r\n");
#nullable restore
#line 84 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
            //<img class="game-button-image" src="~/Images/bomb3.png" />
        }
        else
        {
            //<img class="game-button-image" src="~/Images/hole3.png" />

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"centered\">");
#nullable restore
#line 89 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
                             Write(Model[i].Neighbors);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 90 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--<div class=\"button-label\">\r\n        ");
#nullable restore
#line 94 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
   Write(Model.ElementAt(i).State);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n        ");
#nullable restore
#line 95 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
   Write(Model.ElementAt(i).Neighbors);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n        ");
#nullable restore
#line 96 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
   Write(Model.ElementAt(i).Visited);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
AddHtmlAttributeValue("", 1623, i, 1623, 2, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\TrapBox\Documents\GitHub\milestonecst350_mason\Views\Game\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Milestone.Models.CellModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
