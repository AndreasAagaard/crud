#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5d70d2e7c312a87cc8b1d1b4058511975ad101"
// <auto-generated/>
#pragma warning disable 1591
namespace miniprojekt.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using miniprojekt.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using miniprojekt.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "date");
            __builder.AddAttribute(2, "placeholder", "Dato");
            __builder.AddAttribute(3, "onfocus", "(this.type=\'date\')");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                                                                          inputStartDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputStartDate = __value, inputStartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "<br>\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "date");
            __builder.AddAttribute(9, "placeholder", "Dato");
            __builder.AddAttribute(10, "onfocus", "(this.type=\'date\')");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                                                                          inputEndDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputEndDate = __value, inputEndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "<br>\n");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "number");
            __builder.AddAttribute(16, "placeholder", "Hvor mange bliver i?");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                                                               inputAntal

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputAntal = __value, inputAntal, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>\n");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "placeholder", "Skriv id på shelter");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                                                inputShelter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputShelter = __value, inputShelter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "<br>\n");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Indtast Bruger-id");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                                              inputBruger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputBruger = __value, inputBruger));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "<br>\n");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                  BookShelter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Book Shelter");
            __builder.CloseElement();
#nullable restore
#line 13 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table");
            __builder.OpenElement(36, "thead");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "<th>Date</th>\n                ");
            __builder.AddMarkupContent(39, "<th>Temp. (C)</th>\n                ");
            __builder.AddMarkupContent(40, "<th>Temp. (F)</th>\n                ");
            __builder.OpenElement(41, "th");
            __builder.AddContent(42, 
#nullable restore
#line 25 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                     forecasts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.OpenElement(44, "tbody");
#nullable restore
#line 29 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 32 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                         forecast.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 33 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                         forecast.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
       
    private shelter[] forecasts;
    Booking testBook;
    private DateTime inputStartDate;
    private DateTime inputEndDate;
    private int inputAntal;
    private string inputShelter;
    private string inputBruger;

    private void BookShelter()
    {
        testBook = new Booking(inputStartDate, inputEndDate, inputAntal, inputShelter, inputBruger);
        postUser(testBook);
    }

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<shelter[]>("WeatherForecast");
    }

    public Task<HttpResponseMessage> postUser(Booking booking)
    {
        return Http.PostAsJsonAsync<Booking>("WeatherForecast", booking);

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591