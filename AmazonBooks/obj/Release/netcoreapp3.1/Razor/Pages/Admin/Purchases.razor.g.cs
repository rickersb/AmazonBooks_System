#pragma checksum "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4267fcf718f7287eef094a66639ea7ad2412168b"
// <auto-generated/>
#pragma warning disable 1591
namespace AmazonBooks.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/_Imports.razor"
using AmazonBooks.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<iPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Purchases</h3>\n");
            __builder.OpenComponent<AmazonBooks.Pages.Admin.PurchaseTable>(1);
            __builder.AddAttribute(2, "TableTitle", "Uncollected Payment");
            __builder.AddAttribute(3, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<AmazonBooks.Models.Purchases>>(
#nullable restore
#line 8 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
                                                           UncollectedPayments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ButtonLabel", "Shipped");
            __builder.AddAttribute(5, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
                                                                                                                        CollectPayment

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenComponent<AmazonBooks.Pages.Admin.PurchaseTable>(7);
            __builder.AddAttribute(8, "TableTitle", "Collected Payment");
            __builder.AddAttribute(9, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<AmazonBooks.Models.Purchases>>(
#nullable restore
#line 10 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
                                                         CollectedPayments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ButtonLabel", "Reset");
            __builder.AddAttribute(11, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 10 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
                                                                                                                  ResetPayment

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-info");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
                                         x=>UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Refresh Data");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Purchases.razor"
      
    public iPurchaseRepository repo => Service;

    public IEnumerable<AmazonBooks.Models.Purchases> AllPurchases { get; set; }
    public IEnumerable<AmazonBooks.Models.Purchases> UncollectedPayments { get; set; }
    public IEnumerable<AmazonBooks.Models.Purchases> CollectedPayments { get; set; }


    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }
    public async Task UpdateData()
    {
        AllPurchases = await repo.Purchases.ToListAsync();
        UncollectedPayments = AllPurchases.Where(x => !x.PurchaseReceived);
        CollectedPayments = AllPurchases.Where(x => x.PurchaseReceived);
    }

    public void CollectPayment(int id) => UpdatePayment(id, true);
    public void ResetPayment(int id) => UpdatePayment(id, false);

    private void UpdatePayment(int id, bool purchased)
    {
        AmazonBooks.Models.Purchases p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.PurchaseReceived = purchased;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591