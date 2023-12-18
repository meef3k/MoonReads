using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository;

public class ReactionRepository : IReactionRepository
{
    private readonly DataContext _context;

    public ReactionRepository(DataContext context)
    {
        _context = context;
    }

    public Reaction? GetReaction(int reviewId, string userId)
    {
        return _context
            .Reactions
            .Where(r => r.Review!.Id == reviewId)
            .FirstOrDefault(r => r.User!.Id == userId);
    }
    
    public bool CreateReaction(Reaction reaction)
    {
        _context.Add(reaction);

        return Save();
    }

    public bool UpdateReaction(Reaction reaction, int reviewId, string userId)
    {
        var currentReaction = GetReaction(reviewId, userId);

        currentReaction!.Like = reaction.Like;
        
        _context.Update(currentReaction);

        return Save();
    }

    public bool DeleteReaction(int reviewId, string userId)
    {
        var reaction = GetReaction(reviewId, userId);

        _context.Remove(reaction!);

        return Save();
    }
    
    public bool ReactionExists(int reviewId, string userId)
    {
        return _context.Reactions.Where(r => r.Review!.Id == reviewId).Any(r => r.User!.Id == userId);
    }
    
    public bool Save()
    {
        //_context.DataVersions.FirstOrDefault(d => d.Table == "Reactions")!.Version++;

        var saved = _context.SaveChanges();

        return saved > 0;
    }
}