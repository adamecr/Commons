# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [1.1.0] - 2018-12-29 ##

### Added ###
- CommonLogging: extended methods for Trace
- CommonLogging: extended methods for pass-throu exception logging of existing exceptions
- CommonLogging: extended methods for exception logging in catch filters

### Changed ###
- CommonLogging: Removed dependency on ProxyFoo
- CommonLogging: Extensions class LoggerExtensions replaced by "regular" class LoggerExt, interface ILogger extended with the methods directly
- CommonLogging: Explicit methods for logging with the correlation ID
- Adjusted (somehow unified) argument validations
- Small corrections in code and package documentation

## [1.0.0] - 2018-12-21 ##
### Added ###
- Packages published to NuGet

### Fixed ###
- Fixes in build process related to the package generators


## [0.1.0] - 2018-12-21 ##
### Added ###
- Initial release
- NuGet packages are not published yet, they will be published with v1.0.0

[1.1.0]: https://github.com/adamecr/Commons/compare/v1.0.0...v1.1.0
[1.0.0]: https://github.com/adamecr/Commons/compare/v0.1.0...v1.0.0
[0.1.0]: https://github.com/adamecr/Commons/releases/tag/v0.1.0
