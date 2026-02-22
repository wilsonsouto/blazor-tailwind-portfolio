using BlazorTailwindPortfolio.Domain.Enums;

namespace BlazorTailwindPortfolio.Domain.ValueObjects
{
    public record ContactLinks(string Label, string Url, string Icon, ContactType Type, DisplayOptions DisplayOptions);
}
