using EZ.Job.Core;
using EZJob.Store.MySQL;

namespace EZ.Job.Store.MySQL.Tests;

public sealed class MySqlJobStoreTests
{
    private const string ConnectionString = "Host=localhost;Database=ez_jobs_test;User Id=root;Password=root";

    [Fact(Skip = "Requires MySQL container")]
    public async Task AddAsync_should_store_job()
    {
        var store = new MySqlJobStore(ConnectionString);
        var job = new Job("test-id", "T", "M", [], [], JobStatus.Enqueued, DateTime.UtcNow, null);

        await store.AddAsync(job);
        var result = await store.GetAsync("test-id");

        Assert.NotNull(result);
        Assert.Equal("test-id", result!.Id);
    }
}
