#pragma checksum "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b9d77fd340b3e984b05c5bb2aa34dfbcfda4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutHistory), @"mvc.1.0.view", @"/Views/Order/CheckoutHistory.cshtml")]
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
#line 1 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\_ViewImports.cshtml"
using SISEcommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\_ViewImports.cshtml"
using SISEcommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\_ViewImports.cshtml"
using SISEcommerce.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\_ViewImports.cshtml"
using SISEcommerce.Web.Models.Baskets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\_ViewImports.cshtml"
using SISEcommerce.Web.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b9d77fd340b3e984b05c5bb2aa34dfbcfda4d1", @"/Views/Order/CheckoutHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed941afa6e895e57b1dd0168398b496c9fe239e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
  
    ViewData["Title"] = "CheckoutHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">??deme ge??mi??im</h5>\r\n\r\n");
#nullable restore
#line 15 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                 if (Model.Any())
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped table-bordered"">

                        <tr>
                            <th>Sipari??(??deme) no</th>
                            <th>Sat??n alma tarih</th>
                            <th>Detaylar</th>
                        </tr>
");
#nullable restore
#line 25 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 29 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                               Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <table class=""table table-striped"">

                                        <tr>
                                            <th>Kurs ismi</th>
                                            <th>Kurs fiyat</th>
                                        </tr>
");
#nullable restore
#line 38 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                                         foreach (var orderItem in item.OrderItems)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 41 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                                               Write(orderItem.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 42 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                                               Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 44 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </table>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 48 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n");
#nullable restore
#line 50 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">Sat??n ald??????n??z herhangi bir kurs bulunmamaktad??r.</div>\r\n");
#nullable restore
#line 55 "D:\Dogan\Project\SIS.Ecoommerce\SISEcommerce\Client\MVC-Core\SISEcommerce.Web\Views\Order\CheckoutHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
