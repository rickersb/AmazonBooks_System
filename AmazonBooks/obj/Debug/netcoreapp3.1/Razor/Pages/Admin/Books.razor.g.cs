#pragma checksum "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1e57e277cf901433b9a787ebb5e574198b14f9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Books</h3>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "href", "/admin/books/create");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Add Book");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(9, "\n\n    ");
            __builder.AddMarkupContent(10, "<thead>\n        <tr>\n            <th>Book ID</th>\n            <th>Book Title</th>\n            <th>ISBN</th>\n            \n                \n            \n        </tr>\n    </thead>\n\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 21 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                 foreach(Book b in BookData)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                 b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                 b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 28 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                 b.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 31 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                                                            GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 34 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                                                               GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n            ");
            __builder.OpenElement(43, "td");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                                                                  x=> RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
#nullable restore
#line 40 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.AddMarkupContent(53, "<tr>\n                    <td colspan=\"5\" class=\"text-center\">No Books</td>\n                </tr>\n");
#nullable restore
#line 47 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/ben/Projects/AmazonBooks/AmazonBooks/Pages/Admin/Books.razor"
       

    public IBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }
    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";
    public async Task RemoveBook (Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();

    }
    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
