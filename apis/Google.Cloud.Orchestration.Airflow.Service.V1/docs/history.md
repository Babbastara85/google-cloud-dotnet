# Version history

## Version 2.5.0, released 2024-02-20

### New features

- Added ListWorkloads RPC ([commit 2f0cfc6](https://github.com/googleapis/google-cloud-dotnet/commit/2f0cfc682d783c0629519bda7c3706ff1c271ea0))
- Added field data_retention_config to EnvironmentConfig ([commit 2f0cfc6](https://github.com/googleapis/google-cloud-dotnet/commit/2f0cfc682d783c0629519bda7c3706ff1c271ea0))
- Added field web_server_plugins_mode to SoftwareConfig ([commit 2f0cfc6](https://github.com/googleapis/google-cloud-dotnet/commit/2f0cfc682d783c0629519bda7c3706ff1c271ea0))
- Added field storage_config to Environment ([commit 2f0cfc6](https://github.com/googleapis/google-cloud-dotnet/commit/2f0cfc682d783c0629519bda7c3706ff1c271ea0))

## Version 2.4.0, released 2023-06-20

### New features

- Added RPCs StopAirflowCommand, ExecuteAirflowCommand, PollAirflowCommand, DatabaseFailover, FetchDatabaseProperties ([commit 2e644b4](https://github.com/googleapis/google-cloud-dotnet/commit/2e644b42c98e20244cf95921f1ef074a4f469b42))

## Version 2.3.0, released 2023-05-03

### New features

- Add airflow_byoid_uri field to Cloud Composer API ([commit 19e546e](https://github.com/googleapis/google-cloud-dotnet/commit/19e546e093540a297e017b1f9bf1d9e6e4f1e8ec))

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.1.0, released 2022-12-14

### New features

- Added LoadSnapshot, SaveSnapshot RPCs ([commit c84f55a](https://github.com/googleapis/google-cloud-dotnet/commit/c84f55a6901a487e1f9494ac73a7ce0dcaf9dfa4))
- Added fields maintenance_window, workloads_config, environment_size, master_authorized_networks_config, recovery_config to EnvironmentConfig ([commit c84f55a](https://github.com/googleapis/google-cloud-dotnet/commit/c84f55a6901a487e1f9494ac73a7ce0dcaf9dfa4))
- Added field scheduler_count to SoftwareConfig ([commit c84f55a](https://github.com/googleapis/google-cloud-dotnet/commit/c84f55a6901a487e1f9494ac73a7ce0dcaf9dfa4))
- Added field enable_ip_masq_agent to NodeConfig ([commit c84f55a](https://github.com/googleapis/google-cloud-dotnet/commit/c84f55a6901a487e1f9494ac73a7ce0dcaf9dfa4))
- Added fields cloud_composer_network_ipv4_cidr_block, cloud_composer_network_ipv4_reserved_range, enable_privately_used_public_ips, cloud_composer_connection_subnetwork, networking_config to PrivateEnvironmentConfig ([commit c84f55a](https://github.com/googleapis/google-cloud-dotnet/commit/c84f55a6901a487e1f9494ac73a7ce0dcaf9dfa4))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.


## Version 1.0.0, released 2021-11-10

First GA release.

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2021-09-30

Initial release.
