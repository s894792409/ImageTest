#pragma checksum "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f6cb59ca0d2be8adb56e77a7752ae680ac477e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\_ViewImports.cshtml"
using ImageTest;

#line default
#line hidden
#line 2 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\_ViewImports.cshtml"
using ImageTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f6cb59ca0d2be8adb56e77a7752ae680ac477e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff4d455eba596a7ca24360b5d57b53c0d7ebaa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("show-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/tapmodo-Jcrop-1902fbc/demos/demo_files/sago.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cut-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
  
    ViewBag.Title = "文件上传";

#line default
#line hidden
            BeginContext(36, 7, true);
            WriteLiteral("\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 43, "\"", 110, 1);
#line 5 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 50, Url.Content("~/tapmodo-Jcrop-1902fbc/css/jquery.Jcrop.css"), 50, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 27, true);
            WriteLiteral(" rel=\"stylesheet\" />\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 138, "\"", 200, 1);
#line 6 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 145, Url.Content("~/bootstrap-fileinput/css/fileinput.css"), 145, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 77, true);
            WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n<br />\r\n<div class=\"row\" style=\"width:auto;\">\r\n\r\n    ");
            EndContext();
            BeginContext(278, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0672c085173b4026b08016c0298836d3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(405, 716, true);
            WriteLiteral(@"
    <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">上传头像</button>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"" style=""width:auto;"">
    <div class=""modal-dialog"" style=""width:auto;"">
        <div class=""modal-content"" >
            <div class=""modal-header"" >
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h4 class=""modal-title"" id=""myModalLabel"">图片上传</h4>
            </div>
            <div class=""modal-body "" >
                <div class=""row"">
                    <div class=""col-md-6"">
                        ");
            EndContext();
            BeginContext(1121, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea4d53798bc5459a9ef34f4bfb17b208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1213, 506, true);
            WriteLiteral(@"<br />
                    </div>
                    <div class=""col-md-5"">
                        <input type=""file"" name=""txt_file"" id=""txt_file"" multiple class=""file-loading"" /><br />
                        <h4>图片说明：</h4>
                        <p>1、图片格式需要jpg、gif、png为后缀名.</p>
                        <p>2、图片可以在线裁剪大小,以裁剪后为最终结果.</p>
                        <p>3、图片上传完毕即可关闭窗口.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1736, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1749, "\"", 1813, 1);
#line 42 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1755, Url.Content("~/tapmodo-Jcrop-1902fbc/js/jquery.Jcrop.js"), 1755, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1814, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1837, "\"", 1896, 1);
#line 43 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1843, Url.Content("~/bootstrap-fileinput/js/fileinput.js"), 1843, 53, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1897, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1920, "\"", 1980, 1);
#line 44 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1926, Url.Content("~/bootstrap-fileinput/js/locales/zh.js"), 1926, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1981, 2216, true);
                WriteLiteral(@"></script>
    <script type=""text/javascript"">

        //http://code.ciaoca.com/jquery/jcrop/
        //http://code.ciaoca.com/jquery/jcrop/demo/animation
        //http://plugins.krajee.com/file-input
        //http://plugins.krajee.com/file-advanced-usage-demo#advanced-example-5

        var tailorInfo = """";

        //初始化fileinput
        function FileInput() {
            var oFile = new Object();

            oFile.Init = function (ctrlName, uploadUrl) {
                var control = $('#' + ctrlName);
                //初始化上传控件的样式
                control.fileinput({
                    language: 'zh', //设置语言
                    browseLabel: '选择',
                    browseIcon: ""<i class=\""glyphicon glyphicon-picture\""></i> "",
                    browseClass: ""btn btn-primary"", //按钮样式
                    uploadUrl: uploadUrl, //上传的地址
                    allowedFileExtensions: ['jpg', 'gif', 'png'],//接收的文件后缀
                    showUpload: true, //是否显示上传按钮
                    sho");
                WriteLiteral(@"wCaption: true,//是否显示标题
                    showPreview: false,//隐藏预览
                    dropZoneEnabled: false,//是否显示拖拽区域
                    uploadAsync: true,//采用异步
                    autoReplace: true,
                    //minImageWidth: 50,
                    //minImageHeight: 50,
                    //maxImageWidth: 1000,
                    //maxImageHeight: 1000,
                    //maxFileSize: 0,//单位为kb，如果为0表示不限制文件大小
                    //minFileCount: 0,
                    maxFileCount: 1, //表示允许同时上传的最大文件个数
                    enctype: 'multipart/form-data',
                    validateInitialCount: true,
                    previewFileIcon: ""<i class='glyphicon glyphicon-king'></i>"",
                    msgFilesTooMany: ""选择上传的文件数量({n}) 超过允许的最大数值{m}！"",
                    uploadExtraData: function () {
                        return { ""tailorInfo"": tailorInfo };
                    }
                });
            }

            return oFile;
        };

        fun");
                WriteLiteral("ction PageInit() {\r\n            var jcorp = null;\r\n            var _this = this;\r\n            var fileInput = new FileInput();\r\n            fileInput.Init(\"txt_file\", \"");
                EndContext();
                BeginContext(4198, 24, false);
#line 98 "C:\Users\L33540.NYPSIT\source\repos\ImageTest\ImageTest\Views\Home\Index.cshtml"
                                   Write(Url.Action("UpLoadFile"));

#line default
#line hidden
                EndContext();
                BeginContext(4222, 2952, true);
                WriteLiteral(@""");
            var input = $('#txt_file');

            //图片上传完成后
            input.on(""fileuploaded"", function (event, data, previewId, index) {
                if (data.response.success) {
                    jcorp.destroy();
                    var str = data.response.message;
                    $('#cut-img').removeAttr('style');
                    $('#cut-img').attr('src', data.response.newImage);//Data URI Scheme形式
                    //$('#cut-img').width(data.response.width).height(data.response.height);
                    $('#show-img').attr('src', data.response.newImage);//Data URI Scheme形式
                    alert(str);
                    //$('#cut-img').attr('src', data.response.newImage + ""?t="" + Math.random());//加尾巴解决缓存问题
                }
            });

            //选择图片后触发
            input.on('change', function (event, data, previewId, index) {
                var img = $('#cut-img');
                if (input[0].files && input[0].files[0]) {
                    v");
                WriteLiteral(@"ar reader = new FileReader();
                    reader.readAsDataURL(input[0].files[0]);
                    reader.onload = function (e) {
                        img.removeAttr('src');
                        img.attr('src', e.target.result);
                        img.Jcrop({
                            setSelect: [0, 0, 150, 150],
                            //handleSize: 10,
                            aspectRatio: 1,//选框宽高比
                            bgFade: false,
                            bgColor: 'black',
                            bgOpacity: 0.3,
                            onSelect: updateCords
                        }, function () {
                            jcorp = this;
                        });
                    };
                    if (jcorp != undefined) {
                        jcorp.destroy();
                    }
                }
                function updateCords(obj) {
                    tailorInfo = JSON.stringify({ ""PictureWidth"": $('.jcrop-h");
                WriteLiteral(@"older').css('width'), ""PictureHeight"": $('.jcrop-holder').css('height'), ""CoordinateX"": obj.x, ""CoordinateY"": obj.y, ""CoordinateWidth"": obj.w, ""CoordinateHeight"": obj.h });
                    console.log(tailorInfo);
                }
            });

            //上传出现错误
            input.on('fileuploaderror', function (event, data, msg) {
                alert(event + msg);
                
                //jcorp.destroy();
                //$('#cut-img').attr('src', '/Content/defaultAvatar.jpg');
                return false;
            });

            //移除图片
            input.on('fileclear', function (event) {
                console.log(""fileclear"");

                jcorp.destroy();
                $('#cut-img').attr('src', '/Content/defaultAvatar.jpg');
            });
        };

        $(function () {
            PageInit();
        });
    </script>
");
                EndContext();
            }
            );
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
