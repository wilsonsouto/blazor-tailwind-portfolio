namespace BlazorTailwindPortfolio.Client.Features.Home.Models
{
    public record WorkExperience(Company Company, string Role, Duration Duration, String[] Responsabilities, String[] Stack, DisplayOptions DisplayOptions);

    public record Company(string Name, string Url);
}
