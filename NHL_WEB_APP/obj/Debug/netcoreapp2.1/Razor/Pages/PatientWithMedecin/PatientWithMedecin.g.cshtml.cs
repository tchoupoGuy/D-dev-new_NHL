#pragma checksum "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35aaa7aed3ff9227632746823470cd85ee9265dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NHL_WEB_APP.Pages.PatientWithMedecin.Pages_PatientWithMedecin_PatientWithMedecin), @"mvc.1.0.razor-page", @"/Pages/PatientWithMedecin/PatientWithMedecin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PatientWithMedecin/PatientWithMedecin.cshtml", typeof(NHL_WEB_APP.Pages.PatientWithMedecin.Pages_PatientWithMedecin_PatientWithMedecin), null)]
namespace NHL_WEB_APP.Pages.PatientWithMedecin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\new_NHL\NHL_WEB_APP\Pages\_ViewImports.cshtml"
using NHL_WEB_APP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35aaa7aed3ff9227632746823470cd85ee9265dc", @"/Pages/PatientWithMedecin/PatientWithMedecin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ea98fd01cf83b0cfc99ab675673be8b23c515f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PatientWithMedecin_PatientWithMedecin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
  
    ViewData["Title"] = "PatientWithMedecin";

#line default
#line hidden
            BeginContext(130, 221, true);
            WriteLiteral("\r\n<h2>PatientWithMedecin</h2>\r\n<div>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
             foreach(var items in Model.Medecins)
            {

#line default
#line hidden
            BeginContext(417, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(456, 16, false);
#line 21 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
               Write(items.Id_Medecin);

#line default
#line hidden
            EndContext();
            BeginContext(472, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(500, 17, false);
#line 22 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
               Write(items.Nom_Medecin);

#line default
#line hidden
            EndContext();
            BeginContext(517, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(545, 20, false);
#line 23 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
               Write(items.Prenom_Medecin);

#line default
#line hidden
            EndContext();
            BeginContext(565, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(593, 24, false);
#line 24 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
               Write(items.Specialite_Medecin);

#line default
#line hidden
            EndContext();
            BeginContext(617, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(645, 14, false);
#line 25 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
               Write(items.Patients);

#line default
#line hidden
            EndContext();
            BeginContext(659, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "D:\new_NHL\NHL_WEB_APP\Pages\PatientWithMedecin\PatientWithMedecin.cshtml"
            }

#line default
#line hidden
            BeginContext(700, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NHL_WEB_APP.Pages.PatientWithMedecin.PatientWithMedecinModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NHL_WEB_APP.Pages.PatientWithMedecin.PatientWithMedecinModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NHL_WEB_APP.Pages.PatientWithMedecin.PatientWithMedecinModel>)PageContext?.ViewData;
        public NHL_WEB_APP.Pages.PatientWithMedecin.PatientWithMedecinModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
