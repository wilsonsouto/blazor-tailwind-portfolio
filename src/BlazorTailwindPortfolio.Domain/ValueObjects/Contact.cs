using BlazorTailwindPortfolio.Domain.Enums;

namespace BlazorTailwindPortfolio.Domain.ValueObjects
{
    public record Contact(string Label, string Url, string Icon, ContactType Type, DisplayOptions DisplayOptions);
}
