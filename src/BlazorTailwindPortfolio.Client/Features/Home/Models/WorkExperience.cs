namespace BlazorTailwindPortfolio.Client.Features.Home.Models
{
    public record WorkExperience(Company Company, string Role, Duration Duration, String[] Responsabilities, String[] Stacks, DisplayOptions DisplayOptions);

    public record Company(string Name, string Url);
    
    public record Duration(string ShortDate, string LongDate);
}
 