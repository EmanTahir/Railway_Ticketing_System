#pragma checksum "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c48f685e65df845e95da15f6070675a377f83c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageTrainsSchedule), @"mvc.1.0.view", @"/Views/Admin/ManageTrainsSchedule.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\_ViewImports.cshtml"
using RTS_Term_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\_ViewImports.cshtml"
using RTS_Term_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c48f685e65df845e95da15f6070675a377f83c", @"/Views/Admin/ManageTrainsSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a526dc09625769d33a67beae8182d55c9d0af9be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageTrainsSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/webPages/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/webPages/css/ManageStations.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 800px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/ManageTrainsSchedule"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0px 40px 0px 40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/webPages/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/webPages/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
  
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
    con.Open();
    SqlCommand cmd = new SqlCommand("select Train.train_id, train_name, available_seats, from_schedule_time, to_schedule_time, schedule_date, (Select station_name from Station where station_id = Train_Schedule.from_station_id), (Select station_name from Station where station_id = Train_Schedule.to_station_id), price_per_person from Train_Schedule inner join Train on Train_Schedule.train_id = Train.train_id", con);
    SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
    DataSet data = new DataSet();
    adaptor.Fill(data);
    DataTable table = data.Tables[0];
    cmd.ExecuteNonQuery();
    con.Close();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c10554", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63c48f685e65df845e95da15f6070675a377f83c10931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63c48f685e65df845e95da15f6070675a377f83c12111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <title>Manage Train Schedule</title>
    <style>
        footer {
            text-align: center;
            padding: 3px;
            color: #fff;
            background-color: darkgreen;
        }
    </style>
    <script>
        function Edit(i) {
            event.preventDefault();

            //alert(document.getElementById(""myTable"").rows[i].cells[1].innerHTML);
            //alert(document.getElementById(""myTable"").rows[i].cells[2].innerHTML);
            document.getElementById('tr_id').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[0].innerHTML);
            document.getElementById('tr_name').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[1].innerHTML);
            document.getElementById('avbl').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[2].innerHTML);
            document.getElementById('f_time').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[3].innerHTML);
            doc");
                WriteLiteral(@"ument.getElementById('t_time').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[4].innerHTML);
            document.getElementById('Dt').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[5].innerHTML);
            document.getElementById('f_st').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[6].innerHTML);
            document.getElementById('t_st').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[7].innerHTML);
            document.getElementById('sc_p').setAttribute(""value"", document.getElementById(""myTable"").rows[i].cells[8].innerHTML);
            return true;
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c15784", async() => {
                WriteLiteral(@"
    <div class=""first"">
        <h1 class=""heading"">BOOK YOUR TRAIN</h1>
    </div>
    <div class=""second"">
        <nav class=""navbar navbar-expand-lg navbar-light"">
            <a class=""navbar-brand"" href=""#""></a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/index"">Home</a>
                    </li>
                    <li class=""nav-item active"" style=""text-align: right;"">
                        <a class=""nav-link"" href=""/Home/UserLogin"">Logout</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Ho");
                WriteLiteral(@"me/AboutUs"">About Us</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <br><br><br>
    <div class=""text-center"">
        <h1>Manage Trains Schedule</h1><hr>
    </div><br><br>
    <div class=""header"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c17430", async() => {
                    WriteLiteral(@"
            <i class=""fas fa-search"" aria-hidden=""true""></i>
            <input class=""form-control form-control-sm ml-3 w-75"" type=""text"" placeholder=""Search"" aria-label=""Search"" required>
            <button type=""submit"" name =""button1"" value=""Search2"" class=""btn btn-sm btn-block"" style=""width: 20%; background-color: darkgreen; color: #ffffff;"">Search</button>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div><br>
    
          <table class=""table table-striped"" id=""myTable"" name=""myTable"">
              <thead>
                  <tr class=""container"">
                      <th scope=""col"" style=""text-align: center;"">&nbsp; Train No</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; Train Name</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; Available Seats</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; From Time</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; To Time</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; Date</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; From Station</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; To Station</th>
                      <th scope=""col"" style=""text-align: center;"">&nbsp; Price</th>
                      <th scope=""col"" style=""text-align: cen");
                WriteLiteral("ter;\">&nbsp; Actions </th>\r\n                  </tr>\r\n              </thead>\r\n              <tbody>\r\n");
#nullable restore
#line 108 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                   for (int i = 0; i < table.Rows.Count; i++)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <tr>\r\n                      <td scope=\"row\" style=\"text-align: center;\">");
#nullable restore
#line 111 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                             Write(table.Rows[i].ItemArray[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 112 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 113 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 114 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[3]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 115 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[4]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 116 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[5]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 117 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[6]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 118 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[7]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td style=\"text-align: center;\">");
#nullable restore
#line 119 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                                                 Write(table.Rows[i].ItemArray[8]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                      <td>\r\n                          <a");
                BeginWriteAttribute("href", " href=\"", 6728, "\"", 6735, 0);
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return confirm(\'Do you want to delete?\')\">\r\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c24386", async() => {
                    WriteLiteral("\r\n                                  <input type=\"hidden\" name=\"sc_no\"");
                    BeginWriteAttribute("value", " value=\"", 6946, "\"", 6981, 1);
#nullable restore
#line 123 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
WriteAttributeValue("", 6954, table.Rows[i].ItemArray[0], 6954, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                  <button type=\"submit\" name=\"button1\" value=\"Delete2\" style=\"width:100%\">Delete</button>\r\n                              ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                          </a>\r\n                      </td>\r\n                      <td>\r\n                          <a");
                BeginWriteAttribute("href", " href=\"", 7266, "\"", 7273, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c26945", async() => {
                    WriteLiteral("\r\n                                  <input type=\"hidden\"");
                    BeginWriteAttribute("name", " name=\"", 7400, "\"", 7407, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("value", " value=\"", 7408, "\"", 7443, 1);
#nullable restore
#line 131 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
WriteAttributeValue("", 7416, table.Rows[i].ItemArray[0], 7416, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                  <button type=\"submit\" name=\"button1\" value=\"Update2\" style=\"width:100%\"");
                    BeginWriteAttribute("onclick", " onclick=\"", 7554, "\"", 7588, 5);
                    WriteAttributeValue("", 7564, "return", 7564, 6, true);
                    WriteAttributeValue(" ", 7570, "Edit(", 7571, 6, true);
#nullable restore
#line 132 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
WriteAttributeValue("", 7576, i, 7576, 2, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 7578, "+1,", 7578, 3, true);
                    WriteAttributeValue(" ", 7581, "event)", 7582, 7, true);
                    EndWriteAttribute();
                    WriteLiteral(">Update</button>\r\n                              ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                          </a>\r\n                      </td>\r\n                      <td></td>\r\n                  </tr>\r\n");
#nullable restore
#line 139 "C:\Users\rayan\Desktop\sem5\SE Lab\RTS_term_project\Views\Admin\ManageTrainsSchedule.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("              </tbody>\r\n          </table>\r\n    <hr/>\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c30526", async() => {
                    WriteLiteral(@" 
        <div class=""row"">
            <div class=""col"">
                <input type=""text"" name=""tr_id"" id=""tr_id"" class=""form-control form-control-sm"" placeholder=""Train id"" readonly>
            </div>
            <div class=""col"">
                <input type=""text"" name=""tr_name"" id=""tr_name"" class=""form-control form-control-sm"" placeholder=""Train Name"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""avbl"" id=""avbl"" class=""form-control form-control-sm"" placeholder=""Available Seats"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""f_time"" id=""f_time"" class=""form-control form-control-sm"" placeholder=""From Time"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""t_time"" id=""t_time"" class=""form-control form-control-sm"" placeholder=""To Time"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""Dt");
                    WriteLiteral(@""" id=""Dt"" class=""form-control form-control-sm"" placeholder=""Date"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""f_st"" id=""f_st"" class=""form-control form-control-sm"" placeholder=""From Station"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""t_st"" id=""t_st"" class=""form-control form-control-sm"" placeholder=""To Station"" required>
            </div>
            <div class=""col"">
                <input type=""text"" name=""sc_p"" id=""sc_p"" class=""form-control form-control-sm"" placeholder=""Price"" required>
            </div>
            <div class=""text-for-right"">
                <button type=""submit"" name=""button1"" value=""Insert2"" class=""btn btn-sm"" , style=""background-color: darkgreen; color: #ffffff;"">Add</button>
                <button type=""submit"" name=""button1"" value=""Save2"" class=""btn btn-sm"" , style=""background-color: darkgreen; color: #ffffff;"">Save</button><br>
            </div>
        ");
                    WriteLiteral("</div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <br><br><br><br>\r\n");
                WriteLiteral(@"    <div class=""rightButton"">
        <button type=""button"" class=""btn btn-lg"" style=""background-color: darkgreen; color: #ffffff;""><a href=""/Admin/AfterAdminLogin"" style=""color: white;"">Back</a></button><br>
    </div>
    </div>
    <br><br><br><br>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c34812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c48f685e65df845e95da15f6070675a377f83c35913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
