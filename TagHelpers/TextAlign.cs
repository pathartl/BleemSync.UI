using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleemSync.UI.TagHelpers
{
    [HtmlTargetElement(Attributes = "text-left")]
    public class TextLeftTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.AddClass("text-left");
        }
    }

    [HtmlTargetElement(Attributes = "text-center")]
    public class TextCenterTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.AddClass("text-center");
        }
    }

    [HtmlTargetElement(Attributes = "text-right")]
    public class TextRightTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.AddClass("text-right");
        }
    }
}
