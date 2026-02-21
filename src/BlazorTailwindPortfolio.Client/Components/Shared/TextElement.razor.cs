using Microsoft.AspNetCore.Components;

namespace BlazorTailwindPortfolio.Client.Components.Shared
{
    public partial class TextElement
    {
        [Parameter] public string Title { get; set; } = string.Empty;
        [Parameter] public string AriaLabel { get; set; } = string.Empty;
        [Parameter] public TextType Type { get; set; }
        [Parameter] public TextSize Size { get; set; }
        [Parameter] public TextWidth Width { get; set; }
        [Parameter] public TextPadding? Padding { get; set; }
        [Parameter] public bool IsBold { get; set; }
        [Parameter] public bool HasBackgroundColor { get; set; }
        [Parameter] public bool VisibleOnPrint { get; set; }

        private string AddClasses()
        {
            var hideOnPrint = VisibleOnPrint ? "screen:block" : "print:hidden";
            var isBold = IsBold ? "font-bold" : "font-normal";
            var textSize = GetTextSizeClass();
            var padding = GetPaddingClass();
            var maxWidth = Width.Equals(TextWidth.Medium) ? "max-w-md" : "text-full";
            var isDatePrintSize = AriaLabel.Contains("Date:") ? "print:text-sm" : "print:text-base";
            var hasBackgroundColor = HasBackgroundColor
                ? "border border-transparent bg-neutral-200 rounded-md text-foreground text-center"
                : "text-foreground/80";

            return $"text-pretty print:text-foreground {maxWidth} {textSize} {padding} {hideOnPrint} {isBold} {hasBackgroundColor} {isDatePrintSize}";
        }

        private string GetTextSizeClass()
        {
            return Size switch
            {
                TextSize.ExtraSmall => "text-xs",
                TextSize.Small => "text-sm",
                TextSize.Base => "text-base",
                _ => "text-base"
            };
        }

        private string GetPaddingClass()
        {
            return Padding switch
            {
                TextPadding.Small => "px-1 py-0",
                TextPadding.Medium => "px-2 py-1",
                _ => "p-0"
            };
        }
    }

    public enum TextSize
    {
        ExtraSmall, 

        Small,

        Base,
    }

    public enum TextType
    {
        Paragraph,

        List
    }

    public enum TextWidth
    {
        Medium,

        Full
    }

    public enum TextPadding
    {
        Small, 

        Medium
    }
}
