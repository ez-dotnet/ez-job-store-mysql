using Xunit;
using EZJob.Store.MySQL;
using Xunit;

namespace EZ.Job.Store.MySQL.Tests;

public sealed class MySqlJobStoreTests
{
    private const string ConnectionString = "Host=localhost;Database=ez_jobs_test;User Id=root;Password=root";

    [Fact(Skip = "Requires MySQL container")]
    public async Task AddAsync_should_store_job()
    {
        var store = new MySqlJobStore(ConnectionString);
        var job = new EZ.Job.Core.Job("test-id", "T", "M", [], [], EZ.Job.Core.JobStatus.Enqueued, System.DateTime.UtcNow, null);

        await store.AddAsync(job);
        var result = await store.GetAsync("test-id");

        Assert.NotNull(result);
        Assert.Equal("test-id", result!.Id);
    }
}
