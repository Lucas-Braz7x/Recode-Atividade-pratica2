#pragma checksum "D:\web\Aulas\C-sharp\AgenciaViagens\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ba7c4c1d7a50a1acc261624626440ebee67ef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\web\Aulas\C-sharp\AgenciaViagens\Views\_ViewImports.cshtml"
using AgenciaViagens;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\web\Aulas\C-sharp\AgenciaViagens\Views\_ViewImports.cshtml"
using AgenciaViagens.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ba7c4c1d7a50a1acc261624626440ebee67ef3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52edf097be48c9b4099430fad1cd5400a363b03e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\web\Aulas\C-sharp\AgenciaViagens\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center bg-viagem"">
    <h1 class=""display-4"">Passo&Certo</h1>
    <p>Seja Bem-Vindo!</p>
    <p>""Faça dos seus pequenos momentos histórias inesquecíveis!""</p>
</div>


<div class=""pacote-viagens"">
    <h2>Pacotes de viagens:</h2>

    <div id=""carouselExampleIndicators"" class=""carousel slide carousel-viagens"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""3""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <div class=""d-block w-100 imagem1"" alt=""Primeiro Slide""></div>
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Viage");
            WriteLiteral(@"ns de verão</h5>
                    <p>Praias, Caribe, Havaí...</p>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""d-block w-100 imagem2"" alt=""Segundo Slide""></div>
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Viagens rústicas</h5>
                    <p>Castelos européus, Luxemburgo, entre outros...</p>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""d-block w-100 imagem3"" alt=""Terceiro Slide""></div>
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Viagens aventureiras</h5>
                    <p>Montanhas, trilhas, cachoeiras e desertos...</p>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""d-block w-100 imagem4"" alt=""Quarto Slide""></div>
                <div class=""carousel-caption d-none d-md-block"">
                 ");
            WriteLiteral(@"   <h5>Viagens românticas</h5>
                    <p>Veneza, Paris, entre outros...</p>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Anterior</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Próximo</span>
        </a>
    </div>
</div>
<div class=""sobre"">
    <h2>Sobre nós:</h2>
    <p>Somos uma agência de viagens com o foco na sua experiência.
        Existimos para lhe propor momentos inesquecíveis, para eternizar os
        pequenos momentos felizes da vida e para abalar o seu mundo
        te tirando do ócio e do tédio. Venha com a gente e vivenciar uma
        ex");
            WriteLiteral("periência única!</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
