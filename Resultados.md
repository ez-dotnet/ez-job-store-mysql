# Resultados — Benchmark EZ.Job.Store.MySQL

## Ambiente

| Item           | Valor                         |
|----------------|-------------------------------|
| Hardware       | Intel i7-12700K, 64GB DDR5   |
| SO             | Ubuntu 24.04                  |
| .NET           | 10.0                          |
| Driver         | MySqlConnector 2.4.0          |
| MySQL          | 8.0 (Docker)                  |

## Resultados

| Jobs | Workers | EZ.Job (ms) | Hangfire (ms) | Vezes mais rápido |
|------|---------|-------------|---------------|-------------------|
| 100  | 1       | 18.77       | 56.95         | 3.03×             |
| 1000 | 4       | 115.64      | 299.05        | 2.59×             |

Ganho consistente de 2.6–3.0× em todos os cenários.

## Eficiência de Memória

| Métrica                | EZ.Job | Hangfire |
|------------------------|--------|----------|
| Alocações por job      | ~2.4 KB| ~4.1 KB  |
| Objetos por job        | ~18    | ~31      |
| Pressão Gen 0/1/2      | Baixa  | Moderada |
