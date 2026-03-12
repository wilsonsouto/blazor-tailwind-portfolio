namespace BlazorTailwindPortfolio.Client.Features.Home.Models
{
    public record Profile(Identity Identity, string Introduction, List<WorkExperience> WorkExperiences, Education Education, List<Skills> Skills);
}
