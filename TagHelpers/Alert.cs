using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace BleemSync.UI
{
    [HtmlTargetElement("alert")]
    public class AlertHelper : TagHelper
    {
        [HtmlAttributeName("success")]
        public bool Success { get; set; }

        [HtmlAttributeName("info")]
        public bool Info { get; set; }

        [HtmlAttributeName("warning")]
        public bool Warning { get; set; }

        [HtmlAttributeName("danger")]
        public bool Danger { get; set; }

        [HtmlAttributeName("close")]
        public bool Close { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.AddClass("alert pmd-alert pmd-z-depth");

            if (Success) output.AddClass("alert-success");
            if (Info) output.AddClass("alert-info");
            if (Warning) output.AddClass("alert-warning");
            if (Danger) output.AddClass("alert-danger");
            if (Close) output.AddClass("alert-dismissible");

            output.TagName = "div";
        }
    }
}
