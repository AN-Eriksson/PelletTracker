namespace PelletTracker.Data;

using Dapper;
using System.Data;

public class PelletEntryRepository
{
    private readonly IDbConnection _db;

    public PelletEntryRepository(IDbConnection db)
    {
        _db = db;
    }

    public async Task<IEnumerable<PelletEntry>> GetAllPelletsAsync()
    {
        var sql = "SELECT * FROM PelletEntry";
        return await _db.QueryAsync<PelletEntry>(sql);
    }
}

