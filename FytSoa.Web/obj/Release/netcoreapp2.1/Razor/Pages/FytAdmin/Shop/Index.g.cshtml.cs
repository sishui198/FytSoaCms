#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5550366adc2f92ac598a78e1acfd80ce7a54a5c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_Index), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5550366adc2f92ac598a78e1acfd80ce7a54a5c4", @"/Pages/FytAdmin/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\Index.cshtml"
  
    ViewData["Title"] = "店铺管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(142, 17884, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"" style=""margin-top:10px;"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""shopkey"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <div class=""layui-row"">
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md6"">
            <div class=""list-wall"" style=""padding-top:0px; padding-right:6px;"">
                <table class=""layui-hide"" id=""table-act"" lay-filter=""acttool""></table>
            </div>
        </div>
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md6"">
            <div class=""list-wall"" style=""padding-top:0px;padding-left:6px;"">
                <table class=""layui-hide"" id=""");
            WriteLiteral(@"table-user"" lay-filter=""usertool""></table>
            </div>
        </div>
    </div>
    <script type=""text/html"" id=""toolbar-shop"">
        <div class=""layui-btn-container list-search"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolDel""><i class=""layui-icon""></i> 删除</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolActivity""><i class=""layui-icon layui-icon-app""></i> 添加全局活动</button>
        </div>
    </script>
    <script type=""text/html"" id=""toolbar-act"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolActAdd""><i class=""layui-icon""></i> 添加活动</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolActDel""><i class=""layui-icon""></i> 删除活动</button>
        </div>
    </script>
    <script ");
            WriteLiteral(@"type=""text/html"" id=""toolbar-user"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolUserAdd""><i class=""layui-icon""></i> 添加员工</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolUserDel""><i class=""layui-icon""></i> 删除员工</button>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
                var tabH = $(window).height() - 645;
                table.render({
                    toolbar: '#toolbar-shop',
                    elem: '#tablist',
                    url: '/api/shops/list',
                    height: 460,
                    cols: [
    ");
            WriteLiteral(@"                    [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'shopName', title: '加盟商名称', sort: true, fixed: 'left', event: 'gotool' },
                            { field: 'loginName', title: '登录账号', event: 'gotool' },
                            { field: 'adminName', title: '负责人', event: 'gotool' },
                            { field: 'mobile', title: '联系方式', sort: true, event: 'gotool' },
                            { field: 'shopCity', title: '所在地区', sort: true, event: 'gotool' },
                            { field: 'regDate', title: '添加时间', event: 'gotool' },
                            { width: 200, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    id: 'tables'
                });

                //活动
                table.render({
                    toolbar: '#toolbar-act',
     ");
            WriteLiteral(@"               elem: '#table-act',
                    url: '/api/shops/actlist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'methodName', width: 100, title: '活动方式' },
                            { field: 'countNum', width: 80, title: '折扣数' },
                            { field: 'beginDate', title: '开始时间', sort: true },
                            { field: 'endDate', title: '结束时间', sort: true },
                            { field: 'status', width: 100, title: '状态' },
                            { title: '操作', width: 100, templet: '#acttool' }
                        ]
                    ],
                    page: true,
                    limit: 10,
                    height: tabH,
                    id: 'act-tables'
                });

                //会员
                table.render({
                    toolbar: '#toolbar-user',
                    elem: '#table-us");
            WriteLiteral(@"er',
                    url: '/api/shops/stafflist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'trueName', width: 100, title: '姓名', sort: true, fixed: 'left' },
                            { field: 'mobile', width: 120, title: '手机号码' },
                            { field: 'sex', width: 60, title: '性别' },
                            { field: 'addDate', title: '注册时间' },
                            { field: 'lastLoginDate', title: '最后登录时间' },
                            { title: '操作', width: 100, templet: '#usertool' }
                        ]
                    ],
                    page: true,
                    limit: 10,
                    height: tabH,
                    id: 'user-tables',
                    where: { guid: 'all' }
                });

                var shopGuid = '', active = {
                    //加盟商重载
                    reload: function () {");
            WriteLiteral(@"
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#shopkey"").val()
                                }
                            });
                    },
                    //点击加盟商查询活动和加盟商会员
                    reloadActAndUser: function () {
                        table.reload('act-tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    guid: shopGuid
                                }
                            });
                        table.reload('user-tables',
                            {
                                page: {
                                    curr:");
            WriteLiteral(@" 1
                                },
                                where: {
                                    guid: shopGuid,
                                    types: 1
                                }
                            });
                    },
                    //加盟商搜索
                    toolSearch: function () {
                        active.reload();
                    },
                    //添加全局活动
                    toolActivity: function () {
                        os.Open('添加活动', '/fytadmin/shop/activitymodify?shop=all', '850px', '450px', function () {
                            active.reloadActAndUser();
                        });
                    },
                    //添加加盟商活动
                    toolActAdd: function () {
                        if (shopGuid === '') {
                            os.warning('请选择加盟商~'); return;
                        }
                        os.Open('添加活动', '/fytadmin/shop/activitymodify?shop=' + shopGuid, '85");
            WriteLiteral(@"0px', '450px', function () {
                            active.reloadActAndUser();
                        });
                    },
                    //删除活动
                    toolActDel: function () {
                        var checkStatus = table.checkStatus('act-tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/shops/deleteact/', ");
            WriteLiteral(@"{ parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reloadActAndUser();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    //添加会员
                    toolUserAdd: function () {
                        if (shopGuid === '') {
                            os.warning('请选择加盟商~'); return;
                        }
                        os.Open('添加员工', '/fytadmin/shop/staffmodify?shop=' + shopGuid, '700px', '460px', function () {
                            active.reloadActAndUser();
                        });
                    },
                    //删除会员
                    toolUserDel: function () {
          ");
            WriteLiteral(@"              var checkStatus = table.checkStatus('user-tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/shops/deletestaff/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reloadActAndUser();
    ");
            WriteLiteral(@"                                os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    //添加店铺
                    toolAdd: function () {
                        os.Open('添加加盟商', '/fytadmin/shop/shopmodify', '850px', '500px', function () {
                            active.reload();
                        });
                    },
                    //删除店铺
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
       ");
            WriteLiteral(@"                     str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/shops/delete/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.ev");
            WriteLiteral(@"ent].call(this) : '';
                });
                table.on('toolbar(acttool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                table.on('toolbar(usertool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑加盟商', '/fytadmin/shop/shopmodify/?guid=' + data.guid, '850px', '500px', function () {
                            active.reload();
                        })
                    }
                    if (obj.event === 'gotool') {
   ");
            WriteLiteral(@"                     shopGuid = data.guid;
                        active.reloadActAndUser();
                    }
                    if (obj.event === 'staff') {
                        var winH = $(window).height(), winW = $(window).width() - 500;
                        layuiIndex = layer.open({
                            title: '会员管理'
                            , type: 2
                            , area: [winW + 'px', winH - 60 + 'px']
                            , shade: [0.1, '#333']
                            , resize: false
                            , anim: -1
                            , offset: 'rb'
                            , shadeClose: false
                            , skin: 'layer-anim-07'
                            , content: ""/fytadmin/member/index/?shop="" + data.guid
                            , cancel: function (index) {
                                var $layero = $('#layui-layer' + layuiIndex);
                                $layero.animate({
          ");
            WriteLiteral(@"                          left: $layero.offset().left + $layero.width()
                                }, 300, function () {
                                    layer.close(index);
                                });
                                return false;
                            }
                        });
                        $(""#layui-layer-shade"" + layuiIndex).click(function () {
                            var $layero = $('#layui-layer' + layuiIndex);
                            $layero.animate({
                                left: $layero.offset().left + $layero.width()
                            }, 300, function () {
                                layer.close(layuiIndex);
                            });
                        });
                    }
                });
                //监听工具条
                table.on('tool(acttool)', function (obj) {
                    var data = obj.data;
                    if (data.types != 1) {
                        os");
            WriteLiteral(@".error('全局活动不能修改');
                        return;
                    }
                    if (obj.event === 'edit') {
                        os.Open('编辑活动', '/fytadmin/shop/activitymodify/?guid=' + data.guid + ""&shop="" + shopGuid, '850px', '500px', function () {
                            active.reloadActAndUser();
                        })
                    }
                });
                //监听工具条
                table.on('tool(usertool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑员工', '/fytadmin/shop/staffmodify/?guid=' + data.guid, '700px', '460px', function () {
                            active.reloadActAndUser();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
        <a");
            WriteLiteral(@" class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""staff""><i class=""layui-icon""></i> 会员管理</a>
    </script>
    <script type=""text/html"" id=""acttool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
    <script type=""text/html"" id=""usertool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
