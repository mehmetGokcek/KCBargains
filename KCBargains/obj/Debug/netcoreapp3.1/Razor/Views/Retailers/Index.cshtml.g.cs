#pragma checksum "C:\Users\aldi\source\repos\KCBargains\KCBargains\Views\Retailers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52875320c438c468465dd3bd6a35cf24901a26f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Retailers_Index), @"mvc.1.0.view", @"/Views/Retailers/Index.cshtml")]
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
#line 1 "C:\Users\aldi\source\repos\KCBargains\KCBargains\Views\_ViewImports.cshtml"
using KCBargains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aldi\source\repos\KCBargains\KCBargains\Views\_ViewImports.cshtml"
using KCBargains.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aldi\source\repos\KCBargains\KCBargains\Views\_ViewImports.cshtml"
using KCBargains.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52875320c438c468465dd3bd6a35cf24901a26f5", @"/Views/Retailers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30803c5bdb524f085a2de5dbb9f076ffd81d6ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Retailers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\aldi\source\repos\KCBargains\KCBargains\Views\Retailers\Index.cshtml"
  
    ViewData["Title"] = "Retailers";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Portfolio Grid-->
<section class=""page-section bg-light"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center"">
            <h2 class=""section-heading text-uppercase"">Portfolio</h2>
            <h3 class=""section-subheading text-muted"">Lorem ipsum dolor sit amet consectetur.</h3>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal1"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/01-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 878, "\"", 884, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Threads</div>
                        <div class=""portfolio-caption-subheading text-muted"">Illustration</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal2"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/02-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1687, "\"", 1693, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Explore</div>
                        <div class=""portfolio-caption-subheading text-muted"">Graphic Design</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal3"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/03-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2498, "\"", 2504, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Finish</div>
                        <div class=""portfolio-caption-subheading text-muted"">Identity</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4 mb-lg-0"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal4"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/04-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3310, "\"", 3316, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Lines</div>
                        <div class=""portfolio-caption-subheading text-muted"">Branding</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4 mb-sm-0"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal5"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/05-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4121, "\"", 4127, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Southwest</div>
                        <div class=""portfolio-caption-subheading text-muted"">Website Design</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6"">
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-toggle=""modal"" href=""#portfolioModal6"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""assets/img/portfolio/06-thumbnail.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4929, "\"", 4935, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading"">Window</div>
                        <div class=""portfolio-caption-subheading text-muted"">Photography</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Portfolio Modals-->
<!-- Modal 1-->
<div class=""portfolio-modal modal fade"" id=""portfolioModal1"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Pro");
            WriteLiteral("ject Name</h2>\r\n                            <p class=\"item-intro text-muted\">Lorem ipsum dolor sit amet consectetur.</p>\r\n                            <img class=\"img-fluid d-block mx-auto\" src=\"assets/img/portfolio/01-full.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6187, "\"", 6193, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Threads</li>
                                <li>Category: Illustration</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal 2-->
<div class=""portfolio-");
            WriteLiteral(@"modal modal fade"" id=""portfolioModal2"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Project Name</h2>
                            <p class=""item-intro text-muted"">Lorem ipsum dolor sit amet consectetur.</p>
                            <img class=""img-fluid d-block mx-auto"" src=""assets/img/portfolio/02-full.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8033, "\"", 8039, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Explore</li>
                                <li>Category: Graphic Design</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal 3-->
<div class=""portfoli");
            WriteLiteral(@"o-modal modal fade"" id=""portfolioModal3"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Project Name</h2>
                            <p class=""item-intro text-muted"">Lorem ipsum dolor sit amet consectetur.</p>
                            <img class=""img-fluid d-block mx-auto"" src=""assets/img/portfolio/03-full.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9881, "\"", 9887, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Finish</li>
                                <li>Category: Identity</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal 4-->
<div class=""portfolio-modal");
            WriteLiteral(@" modal fade"" id=""portfolioModal4"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Project Name</h2>
                            <p class=""item-intro text-muted"">Lorem ipsum dolor sit amet consectetur.</p>
                            <img class=""img-fluid d-block mx-auto"" src=""assets/img/portfolio/04-full.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11722, "\"", 11728, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Lines</li>
                                <li>Category: Branding</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal 5-->
<div class=""portfolio-modal ");
            WriteLiteral(@"modal fade"" id=""portfolioModal5"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Project Name</h2>
                            <p class=""item-intro text-muted"">Lorem ipsum dolor sit amet consectetur.</p>
                            <img class=""img-fluid d-block mx-auto"" src=""assets/img/portfolio/05-full.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13562, "\"", 13568, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Southwest</li>
                                <li>Category: Website Design</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal 6-->
<div class=""portfo");
            WriteLiteral(@"lio-modal modal fade"" id=""portfolioModal6"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""close-modal"" data-dismiss=""modal""><img src=""assets/img/close-icon.svg"" alt=""Close modal"" /></div>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8"">
                        <div class=""modal-body"">
                            <!-- Project Details Go Here-->
                            <h2 class=""text-uppercase"">Project Name</h2>
                            <p class=""item-intro text-muted"">Lorem ipsum dolor sit amet consectetur.</p>
                            <img class=""img-fluid d-block mx-auto"" src=""assets/img/portfolio/06-full.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15412, "\"", 15418, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                            <ul class=""list-inline"">
                                <li>Date: January 2020</li>
                                <li>Client: Window</li>
                                <li>Category: Photography</li>
                            </ul>
                            <button class=""btn btn-primary"" data-dismiss=""modal"" type=""button"">
                                <i class=""fas fa-times mr-1""></i>
                                Close Project
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
