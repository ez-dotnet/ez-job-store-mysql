using EZ.Job.Core;
using EZJob.Store.MySQL;

namespace Microsoft.Extensions.DependencyInjection;

public static class EZJobMySqlExtensions
{
    public static IEZJobBuilder AddMySqlStore(this IEZJobBuilder builder, string connectionString)
    {
        return AddMySqlStore(builder, o => o.ConnectionString = connectionString);
    }

    public static IEZJobBuilder AddMySqlStore(this IEZJobBuilder builder, Action<MySqlStoreOptions> configure)
    {
        var options = new MySqlStoreOptions();
        configure(options);

        builder.Services.AddSingleton<IJobStore>(_ => new MySqlJobStore(options.ConnectionString));
        builder.Services.AddSingleton<IRecurringStore>(_ => new MySqlRecurringStore(options.ConnectionString));

        return builder;
    }
}
