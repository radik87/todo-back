#pragma checksum "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42d3bebe894988b7bc7390d321d61686f5acfd1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\_ViewImports.cshtml"
using TODOApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\_ViewImports.cshtml"
using TODOApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d3bebe894988b7bc7390d321d61686f5acfd1d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f365ae90f1ccbaeeb5184e702e9553b7fecee643", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TODOApplication.Models.TaskTodo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Task ");
#nullable restore
#line 5 "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\Home\Details.cshtml"
    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Identifier</dt>\r\n        <dd>");
#nullable restore
#line 9 "D:\TestTaskOleg\TODOapp\todo-app\todo-backend\TODOApplication\Views\Home\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TODOApplication.Models.TaskTodo> Html { get; private set; }
    }
}
#pragma warning restore 1591
