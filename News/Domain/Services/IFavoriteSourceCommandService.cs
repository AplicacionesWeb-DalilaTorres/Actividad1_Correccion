using CatchUpPlatform.News.Domain.Model.Aggregates;
using Catchup_Platform.News.Domain.Model.Commands;

namespace CatchUpPlatform.News.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task Handle(CreateFavoriteSourceCommand command);
        Task Handle(UpdateFavoriteSourceCommand command);
        Task Handle(DeleteFavoriteSourceCommand command);
    }
}
