# Version history

## Version 1.4.0, released 2023-11-07

### New features

- Add new field in `GenerateClientCertificate` v1 API to allow AlloyDB connectors request client certs with metadata exchange support ([commit adc660e](https://github.com/googleapis/google-cloud-dotnet/commit/adc660e37b842eac165982bd8d1c8e479a11ba65))

### Documentation improvements

- Clarify that `readPoolConfig` is required under certain circumstances, and fix doc formatting on `allocatedIpRange`. ([commit adc660e](https://github.com/googleapis/google-cloud-dotnet/commit/adc660e37b842eac165982bd8d1c8e479a11ba65))

## Version 1.3.0, released 2023-10-02

### New features

- Add support to generate client certificate and get connection info for auth proxy in AlloyDB v1 ([commit 70f274b](https://github.com/googleapis/google-cloud-dotnet/commit/70f274b3403655350cb3db768ae678fda5543c22))

## Version 1.2.0, released 2023-09-25

### New features

- Changed description for recovery_window_days in ContinuousBackupConfig ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added NetworkConfig, deprecated network ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added ClientConnectionConfig ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added DatabaseVersion ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added QuantityBasedExpiry ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
## Version 1.1.0, released 2023-06-20

### Bug fixes

- Deprecated SSL modes SSL_MODE_ALLOW, SSL_MODE_REQUIRE, SSL_MODE_VERIFY_CA ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))

### New features

- Added new SSL modes ALLOW_UNENCRYPTED_AND_ENCRYPTED, ENCRYPTED_ONLY ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added support for continuous backups ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added support for cross-region replication (secondary clusters/instances and promotion) ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added users API ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added fault injection API ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))

## Version 1.0.0, released 2023-06-12

Primary purpose of release is to update dependencies and promote to 1.0.0.

### Documentation improvements

- Minor formatting in description of AvailabilityType ([commit fa13762](https://github.com/googleapis/google-cloud-dotnet/commit/fa13762d844bda825fd8caa4473c55c405e0c5b1))

## Version 1.0.0-beta01, released 2023-03-02

Initial release.
