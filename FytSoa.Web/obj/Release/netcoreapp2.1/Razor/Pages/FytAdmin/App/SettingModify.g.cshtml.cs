#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd64341e94d7a9cd17c645ccca2021d3ce9edf63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.App.Pages_FytAdmin_App_SettingModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/App/SettingModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/App/SettingModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.App.Pages_FytAdmin_App_SettingModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.App
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd64341e94d7a9cd17c645ccca2021d3ce9edf63", @"/Pages/FytAdmin/App/SettingModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_App_SettingModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
  
    ViewData["Title"] = "修改APP版本更新";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 2223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96636da189e04068a38fe4f59c65d842", async() => {
                BeginContext(202, 187, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">安卓版本号</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"number\" name=\"AndroidVersion\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 389, "\"", 431, 1);
#line 11 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
WriteAttributeValue("", 397, Model.SettingModel.AndroidVersion, 397, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(432, 329, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">安卓更新文件</label>
        <div class=""layui-input-block fytui-file"">
            <input type=""text"" id=""file1"" name=""AndroidFile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 761, "\"", 800, 1);
#line 17 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
WriteAttributeValue("", 769, Model.SettingModel.AndroidFile, 769, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(801, 339, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input""><button id=""AndroidFile"" class=""layui-btn layui-btn-normal"" type=""button"">文件上传</button>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">Ios版本号</label>
        <div class=""layui-input-block"">
            <input type=""number"" name=""IosVersion""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1140, "\"", 1178, 1);
#line 23 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
WriteAttributeValue("", 1148, Model.SettingModel.IosVersion, 1148, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1179, 337, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label fytui-file"">Ios更新文件</label>
        <div class=""layui-input-block fytui-file"">
            <input type=""text"" id=""file2"" name=""IosFile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1516, "\"", 1551, 1);
#line 29 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
WriteAttributeValue("", 1524, Model.SettingModel.IosFile, 1524, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1552, 368, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input""><button id=""IosFile"" class=""layui-btn layui-btn-normal"" type=""button"">文件上传</button>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">IOS审核</label>
        <div class=""layui-input-block"">
            <input type=""checkbox"" name=""IosAudit"" lay-skin=""switch"" lay-text=""开|关"" ");
                EndContext();
                BeginContext(1922, 47, false);
#line 35 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
                                                                                Write(Model.SettingModel.IosAudit==1 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1970, 366, true);
                WriteLiteral(@">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2336, "\"", 2368, 1);
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\SettingModify.cshtml"
WriteAttributeValue("", 2344, Model.SettingModel.Guid, 2344, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2369, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2381, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2383, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70e7944c261048cb8bb5ea9fc42f3d0f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2474, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2493, 1988, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form', 'upload'], function () {
            var form = layui.form, $ = layui.jquery, os = layui.common, upload = layui.upload;
            var index = parent.layer.getFrameIndex(window.name);
            upload.render({
                elem: '#AndroidFile'
                , url: '/api/upload/index'
                , accept: 'file' //普通文件
                , done: function (res) {
                    if (res.code == 200) {
                        $(""#file1"").val('/' + res.data);
                    } else { 
                        os.error(res.msg);
                    }
                }
            });
            upload.render({
                elem: '#IosFile'
                , url: '/api/upload/index'
                , accept: 'file' //普通文件
                , done: function (res) {
                    if (res.code == 200) {
                        $(""#file2"").va");
                WriteLiteral(@"l('/' + res.data);
                    } else {
                        os.error(res.msg);
                    }
                }
            });
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/setting/add"";
                if ($(""#Guid"").val()) {
                    urls = ""api/setting/edit"";
                }
                data.field.IosAudit = data.field.IosAudit === 'on' ? 1 : 0;
                os.ajax(urls, data.field, function (res) {
                    if (res.statusCode == 200) {
                        parent.layer.close(index);
                    }
                    else {
                        os.error(res.message);
                    }
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4484, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.App.SettingModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.App.SettingModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.App.SettingModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.App.SettingModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
