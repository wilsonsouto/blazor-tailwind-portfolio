namespace BlazorTailwindPortfolio.Client.Features.Home.Models
{
    public record Education(Institution Institution, Duration Duration, string Degree);

    public record Institution(string Name, string Url);
}
