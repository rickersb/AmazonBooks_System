// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
