using PelletTracker.Data;

namespace PelletTracker;

public class PelletEntryService
{
    private readonly PelletEntryRepository _repo;

    public PelletEntryService(PelletEntryRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<PelletEntry>> GetAllPelletsAsync()
    {
        return await _repo.GetAllPelletsAsync();
    }
}