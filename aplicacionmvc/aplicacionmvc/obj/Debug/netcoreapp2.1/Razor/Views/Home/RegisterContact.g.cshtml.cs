#pragma checksum "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1432a554f3642e7aee6bfe063785c5b051d18a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterContact), @"mvc.1.0.view", @"/Views/Home/RegisterContact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegisterContact.cshtml", typeof(AspNetCore.Views_Home_RegisterContact))]
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
#line 1 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\_ViewImports.cshtml"
using aplicacionmvc;

#line default
#line hidden
#line 2 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\_ViewImports.cshtml"
using aplicacionmvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1432a554f3642e7aee6bfe063785c5b051d18a65", @"/Views/Home/RegisterContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aba87c2356f2e13797a445e46d4bc05bc704852", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aplicacionmvc.Models.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
  
    ViewData["Title"] = "RegisterContact";


#line default
#line hidden
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(96, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
            BeginContext(132, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(152, 37, false);
#line 15 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.LabelFor(Model => Model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(189, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(200, 38, false);
#line 16 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.EditorFor(Model => Model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(238, 35, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(274, 39, false);
#line 20 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.LabelFor(Model => Model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(313, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(324, 40, false);
#line 21 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.EditorFor(Model => Model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(364, 35, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(400, 36, false);
#line 25 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.LabelFor(Model => Model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(436, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(447, 37, false);
#line 26 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.EditorFor(Model => Model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(484, 35, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(520, 34, false);
#line 30 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.LabelFor(Model => Model.edad));

#line default
#line hidden
            EndContext();
            BeginContext(554, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(565, 35, false);
#line 31 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.EditorFor(Model => Model.edad));

#line default
#line hidden
            EndContext();
            BeginContext(600, 35, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(636, 39, false);
#line 35 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.LabelFor(Model => Model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(675, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(686, 40, false);
#line 36 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
   Write(Html.EditorFor(Model => Model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(726, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(742, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Enviar\" />\r\n");
            EndContext();
#line 40 "C:\Users\rolandoc\source\repos\aplicacionmvc\aplicacionmvc\Views\Home\RegisterContact.cshtml"
}

#line default
#line hidden
            BeginContext(789, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aplicacionmvc.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
