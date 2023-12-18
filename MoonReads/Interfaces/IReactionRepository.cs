using MoonReads.Models;

namespace MoonReads.Interfaces;

public interface IReactionRepository
{
    Reaction? GetReaction(int reviewId, string userId);
    bool CreateReaction(Reaction reaction);
    bool UpdateReaction(Reaction reaction, int reviewId, string userId);
    bool DeleteReaction(int reviewId, string userId);
    bool ReactionExists(int reviewId, string userId);
    bool Save();
}