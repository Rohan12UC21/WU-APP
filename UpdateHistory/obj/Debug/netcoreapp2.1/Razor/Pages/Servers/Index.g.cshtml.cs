#pragma checksum "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac00f4fefaadcb987037c164b1e93f41fd00abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UpdateHistory.Pages.Servers.Pages_Servers_Index), @"mvc.1.0.razor-page", @"/Pages/Servers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Servers/Index.cshtml", typeof(UpdateHistory.Pages.Servers.Pages_Servers_Index), null)]
namespace UpdateHistory.Pages.Servers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\development\wureporting\UpdateHistory\Pages\_ViewImports.cshtml"
using UpdateHistory;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac00f4fefaadcb987037c164b1e93f41fd00abd", @"/Pages/Servers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352aca7445ea1a1a450d1980fbc10efe2acdc064", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Servers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formstyle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 57, true);
            WriteLiteral("\r\n\r\n<br>\r\n<br>\r\n<br>\r\n\r\n<h2>Server List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(154, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de7567305064dd79b90e750307ce9c6", async() => {
                BeginContext(175, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 6553, true);
            WriteLiteral(@"
</p>

<br>

<script>
    var expanded = false;

    function showCheckboxes() {
        var checkboxes = document.getElementById(""checkboxes"");
        if (!expanded) {
            checkboxes.style.display = ""block"";
            expanded = true;
        } else {
            checkboxes.style.display = ""none"";
            expanded = false;
        }
    }

</script>


<style>
    .multiselect {
        width: 30%;
    }

    .selectBox {
        position: relative;
    }

        .selectBox select {
            width: 100%;
            font-weight: bold;
            box-sizing: border-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            border: 1px solid #C2C2C2;
            box-shadow: 1px 1px 4px #EBEBEB;
            -moz-box-shadow: 1px 1px 4px #EBEBEB;
            -webkit-box-shadow: 1px 1px 4px #EBEBEB;
            border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
   ");
            WriteLiteral(@"         padding: 7px;
            outline: none;
        }

    .overSelect {
        position: absolute;
        left: 0;
        right: 0;
        top: 0;
        bottom: 0;
    }

    #checkboxes {
        display: none;
        border: 1px #dadada solid;
    }

        #checkboxes label {
            display: block;
        }

            #checkboxes label:hover {
                background-color: #1e90ff;
            }

    .form-style-2 {
        max-width: 100%;
        padding: 20px 12px 10px 20px;
        font: 13px Arial, Helvetica, sans-serif;
    }

    .form-style-2-heading {
        font-weight: bold;
        font-style: italic;
        border-bottom: 2px solid #ddd;
        margin-bottom: 20px;
        font-size: 15px;
        padding-bottom: 3px;
    }

    .form-style-2 label {
        display: block;
        margin: 0px 0px 15px 0px;
    }

        .form-style-2 label > span {
            width: 100px;
            font-weight: bold;
          ");
            WriteLiteral(@"  float: left;
            padding-top: 8px;
            padding-right: 5px;
        }

    .form-style-2 span.required {
        color: red;
    }

    .form-style-2 .tel-number-field {
        width: 40px;
        text-align: center;
    }

    .form-style-2 input.input-field, .form-style-2 .select-field {
        width: 48%;
    }

    .form-style-2 input.select-field {
        overflow: auto;
    }

    .form-style-2 input.input-field,
    .form-style-2 .tel-number-field,
    .form-style-2 .textarea-field,
    .form-style-2 .select-field {
        box-sizing: border-box;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        border: 1px solid #C2C2C2;
        box-shadow: 1px 1px 4px #EBEBEB;
        -moz-box-shadow: 1px 1px 4px #EBEBEB;
        -webkit-box-shadow: 1px 1px 4px #EBEBEB;
        border-radius: 3px;
        -webkit-border-radius: 3px;
        -moz-border-radius: 3px;
        padding: 7px;
        outline: none;
    }

     ");
            WriteLiteral(@"   .form-style-2 .input-field:focus,
        .form-style-2 .tel-number-field:focus,
        .form-style-2 .textarea-field:focus,
        .form-style-2 .select-field:focus {
            border: 1px solid #848484;
        }

    .form-style-2 .textarea-field {
        height: 100px;
        width: 55%;
    }

    .form-style-2 input[type=submit],
    .form-style-2 input[type=reset],
    .form-style-2 input[type=button] {
        float: right;
        border: none;
        padding: 8px 15px 8px 15px;
        background: #0069af;
        color: #fff;
        box-shadow: 1px 1px 4px #DADADA;
        -moz-box-shadow: 1px 1px 4px #DADADA;
        -webkit-box-shadow: 1px 1px 4px #DADADA;
        border-radius: 3px;
        -webkit-border-radius: 3px;
        -moz-border-radius: 3px;
    }

        .form-style-2 input[type=submit]:hover,
        .form-style-2 input[type=reset]:hover,
        .form-style-2 input[type=button]:hover {
            background: #00558e;
            color: #ff");
            WriteLiteral(@"f;
        }

    .formstyle input[type=submit],
    .formstyle input[type=reset],
    .formstyle input[type=button] {
        border: none;
        padding: 8px 15px 8px 15px;
        background: #0069af;
        color: #fff;
        box-shadow: 1px 1px 4px #DADADA;
        -moz-box-shadow: 1px 1px 4px #DADADA;
        -webkit-box-shadow: 1px 1px 4px #DADADA;
        border-radius: 3px;
        -webkit-border-radius: 3px;
        -moz-border-radius: 3px;
        float: right;
    }

        .formstyle input[type=submit]:hover,
        .formstyle input[type=reset]:hover,
        .formstyle input[type=button]:hover {
            background: #00558e;
            color: #fff;
        }

    .sub-entry {
        width: 50%;
        float: left;
    }

    .button {
        text-align: center;
        padding-top: 20px;
        clear: both;
    }

    .dropdown-check-list {
        display: inline-block;
    }

        .dropdown-check-list .anchor {
            position: r");
            WriteLiteral(@"elative;
            cursor: pointer;
            display: inline-block;
            padding: 5px 50px 5px 10px;
            border: 1px solid #ccc;
        }

            .dropdown-check-list .anchor:after {
                position: absolute;
                content: """";
                border-left: 2px solid black;
                border-top: 2px solid black;
                padding: 5px;
                right: 10px;
                top: 20%;
                -moz-transform: rotate(-135deg);
                -ms-transform: rotate(-135deg);
                -o-transform: rotate(-135deg);
                -webkit-transform: rotate(-135deg);
                transform: rotate(-135deg);
            }

            .dropdown-check-list .anchor:active:after {
                right: 8px;
                top: 21%;
            }

        .dropdown-check-list ul.items {
            padding: 2px;
            display: none;
            margin: 0;
            border: 1px solid #ccc;
          ");
            WriteLiteral(@"  border-top: none;
        }

            .dropdown-check-list ul.items li {
                list-style: none;
            }

        .dropdown-check-list.visible .anchor {
            color: #0094ff;
        }

        .dropdown-check-list.visible .items {
            display: block;
        }
</style>


<div>
    <div class=""form-style-2-heading"">Select your Servers</div>
</div>


");
            EndContext();
            BeginContext(6742, 2325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964d8d69e7d74dc7ac47d192e8b5267c", async() => {
                BeginContext(6780, 236, true);
                WriteLiteral("\r\n    <b><input type=\"submit\" value=\"Submit\" class=\"button\"></b>\r\n    <table class=\"table\" style=\"width:100%\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7017, 51, false);
#line 285 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].Index));

#line default
#line hidden
                EndContext();
                BeginContext(7068, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7136, 56, false);
#line 288 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].ServerName));

#line default
#line hidden
                EndContext();
                BeginContext(7192, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7260, 54, false);
#line 291 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].Location));

#line default
#line hidden
                EndContext();
                BeginContext(7314, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7382, 49, false);
#line 294 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].ICW));

#line default
#line hidden
                EndContext();
                BeginContext(7431, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7499, 60, false);
#line 297 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].WindowsVersion));

#line default
#line hidden
                EndContext();
                BeginContext(7559, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(7627, 61, false);
#line 300 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Server[0].RealtimeVersion));

#line default
#line hidden
                EndContext();
                BeginContext(7688, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 306 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
             for (int i = 0; i < Model.Server.Count; i++)
            {

#line default
#line hidden
                BeginContext(7868, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(7928, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe9b508056a5471cb8de9db4a7b5551c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 310 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.isItTho[i]);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7981, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8049, 39, false);
#line 313 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].Index));

#line default
#line hidden
                EndContext();
                BeginContext(8088, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8156, 44, false);
#line 316 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].ServerName));

#line default
#line hidden
                EndContext();
                BeginContext(8200, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8268, 42, false);
#line 319 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].Location));

#line default
#line hidden
                EndContext();
                BeginContext(8310, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8378, 37, false);
#line 322 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].ICW));

#line default
#line hidden
                EndContext();
                BeginContext(8415, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8483, 48, false);
#line 325 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].WindowsVersion));

#line default
#line hidden
                EndContext();
                BeginContext(8531, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8599, 49, false);
#line 328 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
               Write(Html.DisplayFor(m => m.Server[i].RealtimeVersion));

#line default
#line hidden
                EndContext();
                BeginContext(8648, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(8715, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f131202cb12468a8b63569dabc73730", async() => {
                    BeginContext(8771, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 331 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
                                           WriteLiteral(Model.Server[i].ID);

#line default
#line hidden
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
                EndContext();
                BeginContext(8779, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(8803, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ee7230a18f8436e808343fceb63ba4b", async() => {
                    BeginContext(8862, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 332 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
                                              WriteLiteral(Model.Server[i].ID);

#line default
#line hidden
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
                EndContext();
                BeginContext(8873, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(8897, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f7e53aa632a4bc19f0337c1f8bc5fe5", async() => {
                    BeginContext(8955, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 333 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
                                             WriteLiteral(Model.Server[i].ID);

#line default
#line hidden
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
                EndContext();
                BeginContext(8965, 46, true);
                WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
                EndContext();
#line 337 "C:\development\wureporting\UpdateHistory\Pages\Servers\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(9026, 34, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9067, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateHistory.Pages.Servers.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateHistory.Pages.Servers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateHistory.Pages.Servers.IndexModel>)PageContext?.ViewData;
        public UpdateHistory.Pages.Servers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591