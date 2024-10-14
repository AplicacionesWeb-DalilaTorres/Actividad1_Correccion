namespace Catchup_Platform.News.Domain.Model.Commands
{
    public record CreateFavoriteSourceCommand(string NewsApiKey, string SourceId);

}
