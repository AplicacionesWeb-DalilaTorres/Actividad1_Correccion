namespace Catchup_Platform.News.Domain.Model.Commands
{
    public record UpdateFavoriteSourceCommand(int Id, string NewsApiKey, string SourceId);

}
