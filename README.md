# EZ.Job.Store.MySQL

Store **MySQL/MariaDB** para [EZ.Job.Core](https://github.com/ez-dotnet/ez-job-core).

## Performance

| Store  | Jobs | Workers | EZ.Job (ms) | Hangfire (ms) | Vezes mais rápido |
|--------|------|---------|-------------|---------------|-------------------|
| MySQL  | 100  | 1       | 18.77       | 56.95         | 3.03×             |
| MySQL  | 1000 | 4       | 115.64      | 299.05        | 2.59×             |

**Eficiência de memória:** EZ.Job aloca ~40% menos objetos por job comparado ao Hangfire, reduzindo pressão no GC.

## Instalação

```bash
dotnet add package EZ.Job.Core
dotnet add package EZ.Job.Store.MySQL
```

## Uso

```csharp
builder.Services.AddEZJob()
    .AddMySqlStore("Host=localhost;Database=ez_jobs;User Id=root;Password=root");
```

## Projetos relacionados

- [EZ.DotNet](https://github.com/ez-dotnet)
- [EZ.Job.Core](https://github.com/ez-dotnet/ez-job-core)
- [EZ.Job.Recurring](https://github.com/ez-dotnet/ez-job-recurring)
