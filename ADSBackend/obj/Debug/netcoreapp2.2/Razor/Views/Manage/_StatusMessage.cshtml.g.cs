#pragma checksum "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4872bcc2fc03883633526244d5c6977610b3f3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__StatusMessage), @"mvc.1.0.view", @"/Views/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_StatusMessage.cshtml", typeof(AspNetCore.Views_Manage__StatusMessage))]
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
#line 1 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\_ViewImports.cshtml"
using ADSBackend;

#line default
#line hidden
#line 3 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\_ViewImports.cshtml"
using ADSBackend.Models;

#line default
#line hidden
#line 4 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\_ViewImports.cshtml"
using ADSBackend.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\_ViewImports.cshtml"
using ADSBackend.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_ViewImports.cshtml"
using ADSBackend.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4872bcc2fc03883633526244d5c6977610b3f3bd", @"/Views/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9308ee3fa29d1055595878c61468b8a203907937", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc00d9a71eb53dda49da25c55591594988a3cd5", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(131, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#line 6 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            BeginContext(197, 156, true);
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
            EndContext();
            BeginContext(354, 5, false);
#line 8 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(359, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 10 "C:\Users\eahscs\Documents\EastonCityGuide-Backend\ADSBackend\Views\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
