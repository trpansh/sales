﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Sales;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Loyalty/GiftCards/AddFund/Verification.cshtml")]
    public partial class _Views_Loyalty_GiftCards_AddFund_Verification_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Loyalty_GiftCards_AddFund_Verification_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Loyalty\GiftCards\AddFund\Verification.cshtml"
  
    ViewBag.Title = "Gift Card Funds Verification";
    Layout = ViewBag.SalesLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    .modal iframe {\r\n        width: 100%;\r\n        border: none;\r\n    " +
"    height: 700px;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%; padding: 3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Gift Card Fund Verification</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"AddNewButton\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" style=\"\"");

WriteLiteral(" href=\"/dashboard/loyalty/tasks/gift-cards/add-fund/entry\"");

WriteLiteral(">\r\n            Add New\r\n        </a>\r\n        <a");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"VerificationApproveButton\"");

WriteLiteral(">Approve</a>\r\n        <a");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"VerificationRejectButton\"");

WriteLiteral(">Reject</a>\r\n\r\n        <div");

WriteLiteral(" class=\"ui icon top left pointing dropdown basic button\"");

WriteLiteral(" id=\"ExportDropDown\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(">\r\n            <span>\r\n                Export\r\n            </span>\r\n            <" +
"div");

WriteLiteral(" class=\"menu\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n                    Export This Document\r\n                </div>\r\n            " +
"    <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createDoc();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file word outline blue icon\"");

WriteLiteral("></i> Export to Doc\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createXls();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file excel outline green icon\"");

WriteLiteral("></i> Export to Excel\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createPDF();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file pdf outline red icon\"");

WriteLiteral("></i> Export to PDF\r\n                </a>\r\n            </div>\r\n        </div>\r\n  " +
"      <a");

WriteLiteral(" id=\"PrintButton\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"print()\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(">\r\n            Print\r\n        </a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui stackable form segment\"");

WriteLiteral(" id=\"Annotation\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"From\"");

WriteLiteral(" id=\"FromInputDate\"");

WriteLiteral(" title=\"From\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-persist");

WriteLiteral(" placeholder=\"To\"");

WriteLiteral(" id=\"ToInputDate\"");

WriteLiteral(" title=\"To\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"TranCode\"");

WriteLiteral(" id=\"TranCodeInputText\"");

WriteLiteral(" title=\"TranCode\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Customer\"");

WriteLiteral(" id=\"CustomerNameInputText\"");

WriteLiteral(" title=\"Customer\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"ReferenceNumber\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" title=\"ReferenceNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"StatementReference\"");

WriteLiteral(" id=\"StatementReferenceInputText\"");

WriteLiteral(" title=\"StatementReference\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"PostedBy\"");

WriteLiteral(" id=\"PostedByInputText\"");

WriteLiteral(" title=\"PostedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Office\"");

WriteLiteral(" id=\"OfficeInputText\"");

WriteLiteral(" title=\"Office\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Status\"");

WriteLiteral(" id=\"StatusInputText\"");

WriteLiteral(" value=\"Unverified\"");

WriteLiteral(" title=\"Status\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"VerifiedBy\"");

WriteLiteral(" id=\"VerifiedByInputText\"");

WriteLiteral(" title=\"VerifiedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Reason\"");

WriteLiteral(" id=\"ReasonInputText\"");

WriteLiteral(" title=\"Reason\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"UserId\"");

WriteLiteral(" id=\"UserIdInputText\"");

WriteLiteral(" title=\"UserId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"OfficeId\"");

WriteLiteral(" id=\"OfficeIdInputText\"");

WriteLiteral(" title=\"OfficeId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(">Show</div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" id=\"JournalView\"");

WriteLiteral(" class=\"ui table segment\"");

WriteLiteral(@">
        <thead>
            <tr>
                <th>Actions</th>
                <th>Select</th>
                <th>TranId</th>
                <th>TranCode</th>
                <th>Value Date</th>
                <th>Book Date</th>
                <th>Customer Name</th>
                <th>Amount</th>
                <th>Ref#</th>
                <th>Statement Reference</th>
                <th>Posted By</th>
                <th>Office</th>
                <th>Status</th>
                <th>Verified By</th>
                <th>Verified On</th>
                <th>Reason</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>

</div>

<div");

WriteLiteral(" id=\"ActionModal\"");

WriteLiteral(" class=\"ui modal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui massive red header\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui inverted red content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui blue large dividing header\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"ReasonTextArea\"");

WriteLiteral(">Verification Reason</label>\r\n                <textarea");

WriteLiteral(" id=\"ReasonTextArea\"");

WriteLiteral("></textarea>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui buttons\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"ui red cancel button\"");

WriteLiteral(" value=\"Cancel\"");

WriteLiteral("/>\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"VerifyButton\"");

WriteLiteral(" class=\"ui green ok button\"");

WriteLiteral(" value=\"Verify\"");

WriteLiteral(" title=\"CTRL + RETURN\"");

WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"ui large advice modal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <iframe></iframe>\r\n</div>\r\n\r\n<script>\r\n    function displayTable(targe" +
"t, model) {\r\n        target.find(\"tbody\").html(\"\");\r\n        function getCell(te" +
"xt) {\r\n            const cell = $(\"<td />\");\r\n\r\n            cell.text(text || \"\"" +
");\r\n\r\n            return cell;\r\n        };\r\n\r\n        function getActionCell(tra" +
"nId) {\r\n            const cell = $(\"<td />\");\r\n\r\n            const checklistAnch" +
"or = $(\"<a title=\'Checklist Window\'><i class=\'list icon\'></i></a>\");\r\n          " +
"  checklistAnchor.attr(\"href\", \"/dashboard/sales/tasks/entry/checklist/\" + tranI" +
"d);\r\n\r\n            const journalAdviceAnchor = $(\"<a title=\'View Journal Advice\'" +
"><i class=\'print icon\'></i></a>\");\r\n            journalAdviceAnchor.attr(\"href\"," +
" \"javascript:void(0);\");\r\n            journalAdviceAnchor.attr(\"onclick\", \"showJ" +
"ournalAdvice(\" + tranId + \");\");\r\n\r\n            const salesAdvice = $(\"<a title=" +
"\'View Sales Invoice\'><i class=\'zoom icon\'></i></a>\");\r\n            salesAdvice.a" +
"ttr(\"href\", \"javascript:void(0);\");\r\n\r\n\r\n            cell.append(checklistAnchor" +
");\r\n            cell.append(journalAdviceAnchor);\r\n            cell.append(sales" +
"Advice);\r\n            return cell;\r\n        };\r\n\r\n        function getSelectionC" +
"ell() {\r\n            const cell = $(\"<td />\");\r\n            const checkbox = $(\"" +
"<div class=\'ui toggle checkbox\'/>\");\r\n            const input = $(\"<input type=\'" +
"checkbox\' />\");\r\n            const label = $(\"<label />\");\r\n\r\n            checkb" +
"ox.append(input);\r\n            checkbox.append(label);\r\n\r\n            cell.appen" +
"d(checkbox);\r\n\r\n            return cell;\r\n        };\r\n\r\n        $.each(model, fu" +
"nction () {\r\n            const item = this;\r\n\r\n            const row = $(\"<tr />" +
"\");\r\n\r\n            row.append(getActionCell(item.TransactionMasterId));\r\n       " +
"     row.append(getSelectionCell(item.TransactionMasterId));\r\n            row.ap" +
"pend(getCell(item.TransactionMasterId));\r\n            row.append(getCell(item.Tr" +
"ansactionCode));\r\n            row.append(getCell(item.ValueDate));\r\n            " +
"row.append(getCell(item.BookDate));\r\n            row.append(getCell(item.Custome" +
"rName));\r\n            row.append(getCell(item.Amount));\r\n            row.append(" +
"getCell(item.ReferenceNumber));\r\n            row.append(getCell(item.StatementRe" +
"ference));\r\n            row.append(getCell(item.PostedBy));\r\n            row.app" +
"end(getCell(item.OfficeName));\r\n            row.append(getCell(item.Status));\r\n " +
"           row.append(getCell(item.VerifiedBy));\r\n            row.append(getCell" +
"(item.LastVerifiedOn));\r\n            row.append(getCell(item.VerificationReason)" +
");\r\n\r\n            target.find(\"tbody\").append(row);\r\n        });\r\n    };\r\n\r\n    " +
"function processQuery() {\r\n        function getModel() {\r\n            const mode" +
"l = window.serializeForm($(\"#Annotation\"));\r\n\r\n            const filters = [];\r\n" +
"\r\n            filters.push(window.getAjaxColumnFilter(\"WHERE\", \"OfficeId\", \"int\"" +
", window.FilterConditions.IsEqualTo, window.metaView.OfficeId));\r\n            fi" +
"lters.push(window.getAjaxColumnFilter(\"WHERE\", \"ValueDate\", \"System.DateTime\", w" +
"indow.FilterConditions.IsGreaterThanEqualTo, model.From));\r\n            filters." +
"push(window.getAjaxColumnFilter(\"WHERE\", \"ValueDate\", \"System.DateTime\", window." +
"FilterConditions.IsLessThanEqualTo, model.To));\r\n            filters.push(window" +
".getAjaxColumnFilter(\"WHERE\", \"TransactionCode\", \"string\", window.FilterConditio" +
"ns.IsLike, model.TranCode));\r\n            filters.push(window.getAjaxColumnFilte" +
"r(\"WHERE\", \"CustomerName\", \"string\", window.FilterConditions.IsLike, model.Custo" +
"merName));\r\n            filters.push(window.getAjaxColumnFilter(\"WHERE\", \"Refere" +
"nceNumber\", \"string\", window.FilterConditions.IsLike, model.ReferenceNumber));\r\n" +
"            filters.push(window.getAjaxColumnFilter(\"WHERE\", \"StatementReference" +
"\", \"string\", window.FilterConditions.IsLike, model.StatementReference));\r\n      " +
"      filters.push(window.getAjaxColumnFilter(\"WHERE\", \"PostedBy\", \"string\", win" +
"dow.FilterConditions.IsLike, model.PostedBy));\r\n            filters.push(window." +
"getAjaxColumnFilter(\"WHERE\", \"OfficeName\", \"string\", window.FilterConditions.IsL" +
"ike, model.Office));\r\n            filters.push(window.getAjaxColumnFilter(\"WHERE" +
"\", \"Status\", \"string\", window.FilterConditions.IsLike, model.Status));\r\n        " +
"    filters.push(window.getAjaxColumnFilter(\"WHERE\", \"VerifiedBy\", \"string\", win" +
"dow.FilterConditions.IsLike, model.VerifiedBy));\r\n            filters.push(windo" +
"w.getAjaxColumnFilter(\"WHERE\", \"VerificationReason\", \"string\", window.FilterCond" +
"itions.IsLike, model.Reason));\r\n\r\n\r\n            return filters;\r\n        };\r\n\r\n " +
"       function displayGrid(target) {\r\n            function request(model) {\r\n  " +
"              const url = \"/api/views/sales/gift-card-transaction-view/get-where" +
"/-1\";\r\n                const data = JSON.stringify(model);\r\n                retu" +
"rn window.getAjaxRequest(url, \"POST\", data);\r\n            };\r\n\r\n            cons" +
"t model = getModel();\r\n\r\n            const ajax = request(model);\r\n\r\n           " +
" ajax.success(function (response) {\r\n                displayTable(target, respon" +
"se);\r\n                target.removeClass(\"loading\");\r\n            });\r\n\r\n       " +
"     ajax.fail(function (xhr) {\r\n                alert(JSON.stringify(xhr));\r\n  " +
"          });\r\n        };\r\n\r\n        const view = $(\"#JournalView\").addClass(\"lo" +
"ading\");\r\n\r\n        displayGrid(view);\r\n    };\r\n\r\n    $(\"#ShowButton\")\r\n        " +
".unbind(\"click\")\r\n        .bind(\"click\",\r\n            function() {\r\n            " +
"    processQuery();\r\n            });\r\n\r\n    setTimeout(function () {\r\n        pr" +
"ocessQuery();\r\n    }, 1000);\r\n</script>\r\n\r\n<script>\r\n    var reasonTextArea = $(" +
"\"#ReasonTextArea\");\r\n    var journalView = $(\"#JournalView\");\r\n    var modal = $" +
"(\"#ActionModal\");\r\n    var verifyButton = $(\"#VerifyButton\");\r\n    var tranId;\r\n" +
"    var approve;\r\n\r\n    function getSelectedItem() {\r\n        const selected = j" +
"ournalView.find(\"input:checked\").first();\r\n        \r\n        if (selected.length" +
") {\r\n            const row = selected.parent().parent().parent();\r\n            c" +
"onst id = row.find(\"td:nth-child(3)\").html();\r\n            return parseInt(id);\r" +
"\n        };\r\n\r\n        return 0;\r\n    };\r\n\r\n    function showModal() {\r\n        " +
"const header = modal.find(\".ui.massive.header\");\r\n        const subheader = moda" +
"l.find(\".ui.dividing.header\");\r\n\r\n        header.html(\"Reject Transaction\");\r\n  " +
"      subheader.html(window.stringFormat(\"TranId: #{0}\", tranId));\r\n        head" +
"er.removeClass(\"green\").addClass(\"red\");\r\n\r\n        if (approve) {\r\n            " +
"header.html(\"Approve Transaction\");\r\n            header.removeClass(\"red\").addCl" +
"ass(\"green\");\r\n        };\r\n\r\n        modal.modal(\'setting\', \'closable\', false).m" +
"odal(\'show\');\r\n    };\r\n\r\n    $(\"#VerificationApproveButton\").click(function () {" +
"\r\n        tranId = getSelectedItem();\r\n\r\n        if (tranId) {\r\n            appr" +
"ove = true;\r\n            showModal();\r\n        };\r\n    });\r\n\r\n    $(\"#Verificati" +
"onRejectButton\").click(function () {\r\n        tranId = getSelectedItem();\r\n\r\n   " +
"     if (tranId) {\r\n            approve = false;\r\n            showModal();\r\n    " +
"    };\r\n    });\r\n\r\n    function removeRow(index, callback) {\r\n        journalVie" +
"w.find(\"tr\").eq(index + 1).addClass(\"negative\").fadeOut(500, function () {\r\n    " +
"        $(this).remove();\r\n\r\n            if (typeof (callback) === \"function\") {" +
"\r\n                callback();\r\n            };\r\n        });\r\n    };\r\n\r\n    functi" +
"on hideModal() {\r\n        modal.modal(\"hide\");\r\n    };\r\n\r\n    verifyButton.click" +
"(function () {\r\n        function getModel() {\r\n            const reason = reason" +
"TextArea.val();\r\n\r\n            return {\r\n                TranId: tranId,\r\n      " +
"          Reason: reason\r\n            };\r\n        };\r\n\r\n        function request" +
"(model, type) {\r\n            const url = \"/dashboard/loyalty/tasks/gift-cards/ad" +
"d-fund/verification/\" + type;\r\n            const data = JSON.stringify(model);\r\n" +
"\r\n            return window.getAjaxRequest(url, \"POST\", data);\r\n        }\r\n\r\n   " +
"     const model = getModel();\r\n        const type = approve ? \"approve\" : \"reje" +
"ct\";\r\n\r\n        const ajax = request(model, type);\r\n\r\n        ajax.success(funct" +
"ion (response) {\r\n            var cascadingTranId = parseFloat(response);\r\n\r\n   " +
"         if (cascadingTranId) {\r\n                journalView.find(\"tr td:nth-chi" +
"ld(3)\").each(function (i) {\r\n                    const tranId = parseFloat($(thi" +
"s).text() || 0);\r\n\r\n                    if (cascadingTranId === tranId) {\r\n     " +
"                   removeRow(i);\r\n                    };\r\n                });\r\n " +
"           };\r\n\r\n            journalView.find(\"input:checked\").first().parent()." +
"parent().parent().remove();\r\n            hideModal();\r\n        });\r\n\r\n        aj" +
"ax.fail(function (xhr) {\r\n            window.logAjaxErrorMessage(xhr);\r\n        " +
"});\r\n\r\n        return false;\r\n    });\r\n\r\n    $(document).keyup(function (e) {\r\n " +
"       if (e.ctrlKey) {\r\n            const rowNumber = e.keyCode - 47;\r\n\r\n      " +
"      if (rowNumber < 10) {\r\n                journalView.find(\"tr\").eq(rowNumber" +
").find(\"input\").trigger(\'click\');\r\n            };\r\n        };\r\n    });\r\n\r\n    sh" +
"ortcut.add(\"CTRL+K\", function () {\r\n        $(\"#ApproveButton\").trigger(\"click\")" +
";\r\n    });\r\n\r\n    shortcut.add(\"CTRL+RETURN\", function () {\r\n        if (modal.i" +
"s(\":visible\")) {\r\n            verifyButton.trigger(\"click\");\r\n        };\r\n    })" +
";\r\n\r\n    shortcut.add(\"CTRL+SHIFT+K\", function () {\r\n        $(\"#VerificationRej" +
"ectButton\").trigger(\"click\");\r\n    });\r\n\r\n    function showInvoice(tranId) {\r\n  " +
"      $(\".advice.modal iframe\").attr(\"src\", \"/dashboard/reports/source/Areas/Mix" +
"ERP.Sales/Reports/Invoice.xml?transaction_master_id=\" + tranId);\r\n\r\n        setT" +
"imeout(function () {\r\n            $(\".advice.modal\")\r\n                .modal(\'se" +
"tting\', \'transition\', \'horizontal flip\')\r\n                .modal(\"show\");\r\n\r\n   " +
"     }, 300);\r\n    };\r\n    function showJournalAdvice(tranId) {\r\n        $(\".mod" +
"al iframe\").attr(\"src\", \"/dashboard/reports/source/Areas/MixERP.Finance/Reports/" +
"JournalEntry.xml?transaction_master_id=\" + tranId);\r\n\r\n        setTimeout(functi" +
"on () {\r\n            $(\".advice.modal\")\r\n                .modal(\'setting\', \'tran" +
"sition\', \'horizontal flip\')\r\n                .modal(\"show\");\r\n\r\n        }, 300);" +
"\r\n    };\r\n\r\n</script>");

        }
    }
}
#pragma warning restore 1591