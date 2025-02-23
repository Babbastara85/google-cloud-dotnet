# Version history

## Version 2.12.0, released 2024-02-09

### Documentation improvements

- Fix typo in comment ([commit 84266b6](https://github.com/googleapis/google-cloud-dotnet/commit/84266b6099a52b845e28fae19300d1fa034309fc))
## Version 2.11.0, released 2024-01-08

### New features

- Added enum value EventType.GOVERNANCE_RULE_PROCESSING ([commit d69b53d](https://github.com/googleapis/google-cloud-dotnet/commit/d69b53d698d7473699414f3686aa8f9e08ebf927))

### Documentation improvements

- Fix the comment for `ignore_null` field to clarify its applicability on data quality rules ([commit df58fbb](https://github.com/googleapis/google-cloud-dotnet/commit/df58fbbfc3c5912724d0253ef3fd959ddf47d811))
- Added documentation of page_size default and maximum value for ListEntries and RetrieveAspects ([commit df58fbb](https://github.com/googleapis/google-cloud-dotnet/commit/df58fbbfc3c5912724d0253ef3fd959ddf47d811))

## Version 2.10.0, released 2023-12-04

### New features

- Add data quality score to DataQualityResult ([commit 1d5d4bc](https://github.com/googleapis/google-cloud-dotnet/commit/1d5d4bccfa052038b2ddf87c8fdb3c0143f60b0e))
- Added DataQualityResult.score, dimension_score, column_score ([commit 4514953](https://github.com/googleapis/google-cloud-dotnet/commit/4514953ce68393f342bd13e9217b4d44d589d180))
- New event types GOVERNANCE_RULE_MATCHED_RESOURCES, GOVERNANCE_RULE_SEARCH_LIMIT_EXCEEDS, GOVERNANCE_RULE_ERRORS ([commit 4514953](https://github.com/googleapis/google-cloud-dotnet/commit/4514953ce68393f342bd13e9217b4d44d589d180))

## Version 2.9.0, released 2023-11-07

### New features

- DataQualityDimension is now part of the DataQualityDimensionResult message ([commit a879994](https://github.com/googleapis/google-cloud-dotnet/commit/a879994e8fce714e0e43135849dd392ebdd35741))
- Add relativeResourceName and linkedResourceName to search result ([commit a879994](https://github.com/googleapis/google-cloud-dotnet/commit/a879994e8fce714e0e43135849dd392ebdd35741))

### Documentation improvements

- Updated comments for `DataQualityResult.dimensions` field ([commit 51657c7](https://github.com/googleapis/google-cloud-dotnet/commit/51657c71b91c57aee2c8ca95bd06eb81a4887dad))

## Version 2.8.0, released 2023-10-30

### New features

- DataQualityDimension is now part of the DataQualityDimensionResult message ([commit 67025d5](https://github.com/googleapis/google-cloud-dotnet/commit/67025d5655432b841e329fcae10f15a2afebeba1))

## Version 2.7.0, released 2023-09-25

### New features

- Additional HTTP bindings for IAM methods ([commit b904305](https://github.com/googleapis/google-cloud-dotnet/commit/b904305dc867d732f7fac4db82aeb0d014aa2dce))

## Version 2.6.0, released 2023-09-06

### Bug fixes

- Remove unused annotation in results_table ([commit 78ebeac](https://github.com/googleapis/google-cloud-dotnet/commit/78ebeace797b97e5ec53e9908f860f688a25e8c2))

## Version 2.5.0, released 2023-08-04

### New features

- New service DataTaxonomyService and related messages ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- DataProfileSpec message with DataProfileScan related settings ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added TopNValue.ratio ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added DataQualitySpec.sampling_percent, row_filter ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added DataQualityRule.name, description ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added ListDataScanJobsRequest.filter to filter ListDataScanJob results ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added JobEvent.execution_trigger ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added DataScanEvent.data_profile_configs, data_quality_configs, post_scan_actions_result ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added RunTaskRequest.labels, args ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))
- Added Job.labels, trigger, execution_spec ([commit ad1c59f](https://github.com/googleapis/google-cloud-dotnet/commit/ad1c59fab41af76e678bce4a8d902a755d50e800))

## Version 2.4.0, released 2023-05-03

### New features

- Added new Dataplex APIs and new features for existing APIs (e.g. DataScans) ([commit 5da3cc6](https://github.com/googleapis/google-cloud-dotnet/commit/5da3cc6e696341f295a3518a64b1fb6fceb7d7a9))

### Documentation improvements

- Updated comments for multiple Dataplex APIs ([commit 5da3cc6](https://github.com/googleapis/google-cloud-dotnet/commit/5da3cc6e696341f295a3518a64b1fb6fceb7d7a9))

## Version 2.3.0, released 2023-02-08

### New features

- Enable REST transport in C# ([commit 44c6d16](https://github.com/googleapis/google-cloud-dotnet/commit/44c6d16ce10fbea5debaae0eb22ea2f2dbda1b59))
- DataScans service ([commit 300ee9a](https://github.com/googleapis/google-cloud-dotnet/commit/300ee9a5046e902fa445ddd2e102249ef3b80b80))
- Added StorageFormat.iceberg ([commit 300ee9a](https://github.com/googleapis/google-cloud-dotnet/commit/300ee9a5046e902fa445ddd2e102249ef3b80b80))

### Documentation improvements

- Improvements to DataScan API documentation ([commit f4c2568](https://github.com/googleapis/google-cloud-dotnet/commit/f4c2568c5fb6fe0f674e298b5b332a04ed1ef51b))
- Fix minor docstring formatting ([commit 0117520](https://github.com/googleapis/google-cloud-dotnet/commit/01175207962b27b34e86db961ab2cd93039e9c90))
- Fix minor docstring formatting ([commit 66e3386](https://github.com/googleapis/google-cloud-dotnet/commit/66e338638742deadf1f2495e87a478b5e484d8d3))

## Version 2.2.0, released 2022-10-17

### New features

- Add support for notebook tasks ([commit 747c3cc](https://github.com/googleapis/google-cloud-dotnet/commit/747c3cce51f655e638db69943faa9df0f3a49488))

## Version 2.1.0, released 2022-07-25

### New features

- Add IAM support for Explore content APIs ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for custom container for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for cross project for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for custom encryption key to be used for encrypt data on the PDs associated with the VMs in your Dataproc cluster for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for Latest job in Task resource ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- User mode filter in Explore list sessions API ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Support logging sampled file paths per partition to Cloud logging for Discovery event ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))

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


## Version 1.0.0, released 2022-03-14

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2022-02-22

### New features

- New Content APIs ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
- Create|Update|Delete Metadata APIs (e.g. Entity and/or Partition) ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
## Version 1.0.0-beta01, released 2022-02-16

Initial release.
