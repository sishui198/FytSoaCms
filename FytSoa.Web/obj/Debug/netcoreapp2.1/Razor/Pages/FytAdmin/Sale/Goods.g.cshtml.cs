#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62a55442b18c2a2345b18e7d841b45d1fcad7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Goods), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/Goods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/Goods.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Goods), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62a55442b18c2a2345b18e7d841b45d1fcad7af", @"/Pages/FytAdmin/Sale/Goods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_Goods : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
  
    ViewData["Title"] = "销售商品明细";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 362, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入订单号"">
            </div>
            <div class=""layui-inline"">
                <select id=""shops"" lay-search="""">
                    ");
            EndContext();
            BeginContext(506, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871773ef651345d499b89f58ab336956", async() => {
                BeginContext(523, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                      
                        foreach (var item in Model.shopList)
                        {

#line default
#line hidden
            BeginContext(658, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(686, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa5864b7698e4a8293f346e87c1aa5f1", async() => {
                BeginContext(714, 13, false);
#line 19 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                                                  Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 19 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(736, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(788, 159, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"branks\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(947, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7b5f3710ce45808d702305fb445fae", async() => {
                BeginContext(964, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(984, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                      
                        foreach (var item in Model.codeList)
                        {

#line default
#line hidden
            BeginContext(1099, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1127, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0710651106044d1fbb5d4a026e609551", async() => {
                BeginContext(1155, 9, false);
#line 30 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 30 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1225, 157, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"size\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1382, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ebc611415174450a7b6058c7e635697", async() => {
                BeginContext(1399, 11, true);
                WriteLiteral("--可根据尺码搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                      
                        foreach (var item in Model.sizeCodeList)
                        {

#line default
#line hidden
            BeginContext(1538, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1566, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d036242523a94a44b3e043c4f4de2e78", async() => {
                BeginContext(1594, 9, false);
#line 41 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 41 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1612, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Goods.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1664, 373, true);
            WriteLiteral(@"                </select>
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <div class=""layui-inline lay-time-icon"">
                <select id=""backStatus"">
                    ");
            EndContext();
            BeginContext(2037, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9de31e9fc44a3aba02f8f029bd7f50", async() => {
                BeginContext(2054, 8, true);
                WriteLiteral("--退单状态--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2071, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2093, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d46e7a158349cb9c55bad2acd54223", async() => {
                BeginContext(2111, 1, true);
                WriteLiteral("无");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2121, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2143, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1517c6100fa48ec9bda49bcb24e7a2f", async() => {
                BeginContext(2161, 1, true);
                WriteLiteral("是");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2171, 163, true);
            WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"layui-inline lay-time-icon\">\r\n                <select id=\"saleType\">\r\n                    ");
            EndContext();
            BeginContext(2334, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc4177bfb4c4f8699ba91f502cc995c", async() => {
                BeginContext(2351, 8, true);
                WriteLiteral("--销售类型--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2368, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2390, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b9d5958338f47eab7c769a96ce56e3e", async() => {
                BeginContext(2408, 4, true);
                WriteLiteral("正常销售");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2421, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2443, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0253a6abe6044ee8927a4616f0744510", async() => {
                BeginContext(2461, 5, true);
                WriteLiteral("残次品销售");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2475, 4895, true);
            WriteLiteral(@"
                </select>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <h4>销售商品明细</h4>
        </div>
    </script>
    <script>
                layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'form', 'common', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form;
                form.render('select');
                laydate.render({
                    elem: '#times'
                    , theme: '#");
            WriteLiteral(@"393D49'
                    , format: 'yyyy/MM/dd'
                    , range: true
                });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/sale/goods/list',
                    cellMinWidth: 110,
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'orderNumber', width: 160, title: '订单号', fixed: 'left' },
                            { field: 'shopName', width: 200, title: '加盟商', fixed: 'left' },
                            {
                                field: 'activityName', width: 120, title: '活动信息',templet:function(res) { 
                                    if (res.activityName != 'undefined' && res.activityName) {
                                        return '<span class=""layui-badge layui-bg-blue"">' + res.activityName+'</span>';
                                    } else {
");
            WriteLiteral(@"                                        return '<span class=""layui-badge-dot layui-bg-cyan""></span>';
                                    }
                            } },
                            { field: 'code', width: 200, title: '条形码' },
                            {
                                field: 'brandName', width: 240,title: '商品名称', templet: function (res) { 
                                    return res.brandName + res.styleName + res.seasonName;
                            } },
                            { field: 'counts', title: '销售数' },
                            {
                                field: 'backCounts', title: '是否退单', templet: function (res) { 
                                    return res.backCounts == 0 ? """" : '<span class=""layui-badge-dot""></span>';
                                }
                            },
                            {
                                field: 'saleType', title: '销售类型', templet: function (res) {
                 ");
            WriteLiteral(@"                   return res.saleType == 1 ? '正常销售' : '<span class=""layui-badge layui-bg-orange"">残次品销售</span>';
                                }
                            },
                            { field: 'money', title: '商品金额' },
                            { field: 'addDate', width: 200, title: '下单时间' }
                        ]
                    ],
                    page: { limits: [15, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 15,
                    id: 'tables'
                });


                var active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $('#key').val(),
                                    brank: $('#branks').val(),
                          ");
            WriteLiteral(@"          size: $('#size').val(),
                                    time: $('#times').val(),
                                    shopGuid: $(""#shops"").val(),
                                    backStatus: $(""#backStatus"").val(),
                                    saleType: $(""#saleType"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };
                
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
            });
    </script>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.GoodsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.GoodsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.GoodsModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.GoodsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591