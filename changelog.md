# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [1.2.0] - 2019-01-22 ##
### Added ###
- Added `Disposer` - Keeps the stack of disposable objects, and disposes them when the disposer is being disposed.
- Added `Scope` - The runtime "container" for scoped operations.
  The scope can be both state-less and state-full and it's valid until it's disposed.
  The scopes can be nested (when the scope is disposed, the children are disposed as well)
  and there can be multiple child scopes (siblings) living in parallel.
  The base implementation just manages the life time, child scopes and keeps the state (when provided).
  Inherit from the `Scope<TState>` (and `IScope<TState>`)
  to add the scope related operations (inherited classes have the access to state).
- Added `Context` - The runtime "container" for context operations.
  The context can be both state-less and state-full and it's valid until it's disposed.
  The current context is accessible via static property `Current`.
  The contexts are chained, when a new context is created using static method `BeginContext()`,
  the `Current` context became the `Parent` of the new one and
  the newly created context will be set as the `Current` one.
  When the context is disposed, the `Current` context is set to `Parent` of disposing context.
  The base implementation just manages the life time, context chain and keeps the state (when provided).
  Inherit from the `Context<TState>` to add the context related operations
  (inherited classes have the access to state).
- Common Logging - added StackTrace event property that will be filled from the exception stacktrace or from the current stack trace when the exception has not been thrown yet
- Added `ArrayExtensions.AppendBytes` - adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one).

### Changed ###
- BaseDisposable - thread safety, added AssertNotDisposed check

## [1.1.0] - 2018-12-29 ##

### Added ###
- CommonLogging: extended methods for Trace
- CommonLogging: extended methods for pass-through exception logging of existing exceptions
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

[1.2.0]: https://github.com/adamecr/Commons/compare/v1.1.0...v1.2.0
[1.1.0]: https://github.com/adamecr/Commons/compare/v1.0.0...v1.1.0
[1.0.0]: https://github.com/adamecr/Commons/compare/v0.1.0...v1.0.0
[0.1.0]: https://github.com/adamecr/Commons/releases/tag/v0.1.0
