---
discussion: false
---

# Change log

See [upgrade notes][1] for helpful information when upgrading from previous versions.

  [1]: https://aka.ms/ps-rule/upgrade

**Important notes**:

- Several options have been renamed and the old names will be removed in v3.
  See [deprecations][2] for details.
- Several properties of rule and language block elements will be removed from v3.
  See [deprecations][2] for details.

  [2]: https://aka.ms/ps-rule/deprecations#deprecations-for-v3

**Experimental features**:

- Baseline groups allow you to use a friendly name to reference baselines.
  See [baselines][6] for more information.
- Functions within YAML and JSON expressions can be used to perform manipulation prior to testing a condition.
  See [functions][3] for more information.
- Sub-selectors within YAML and JSON expressions can be used to filter rules and list properties.
  See [sub-selectors][4] for more information.
- Processing of changes files only within a pipeline.
  See [creating your pipeline][5] for more information.

  [3]: expressions/functions.md
  [4]: expressions/sub-selectors.md
  [5]: creating-your-pipeline.md#processing-changed-files-only
  [6]: concepts/baselines.md

!!! Attention
    We are currently working towards the next release of PSRule.
    For more information see [v3][7] release notes.
    Please check out our [upgrade notes][1] to get prepared for upgrading to the latest version.

  [7]: https://microsoft.github.io/PSRule/latest/CHANGELOG-v3/

## v2.9.0

What's changed since release v2.8.1:

- New features:
  - Added sub-selector quantifiers for `allOf` or `anyOf` operators by @BernieWhite.
    [#1423](https://github.com/microsoft/PSRule/issues/1423)
    - Quantifiers allow you to specify the number of matches with `count`, `less`, `lessOrEqual`, `greater`, or `greaterOrEqual`.
    - See [Sub-selectors][4] for more information.
  - Added support for new functions by @BernieWhite.
    [#1422](https://github.com/microsoft/PSRule/issues/1422)
    - Added support for `padLeft`, and `padRight`.
  - **Experimental**: Added support for baseline groups by @BernieWhite.
    [#1541](https://github.com/microsoft/PSRule/issues/1541)
    - Baseline groups allow you to reference a baseline by a friendly name.
    - Update the baseline group to point to a new baseline.
    - Currently only a single baseline can be referenced by a baseline group.
    - See [baselines][6] for more information.
- General improvements:
  - Added style and improved handling for restore command by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)
  - **Important change**: Rename of execution options by @BernieWhite.
    [#1456](https://github.com/microsoft/PSRule/issues/1456)
    - Renamed options allow configuration of output level as `Ignore`, `Warn`, `Error`, or `Debug`.
    - `Execution.AliasReferenceWarning` is replaced with `Execution.AliasReference`.
    - `Execution.InconclusiveWarning` is replaced with `Execution.RuleInconclusive`.
    - `Execution.InvariantCultureWarning` is replaced with `Execution.InvariantCulture`.
    - `Execution.NotProcessedWarning` is replaced with `Execution.UnprocessedObject`.
    - Deprecated `AliasReferenceWarning` option, which will be removed in v3.
    - Deprecated `InconclusiveWarning` option, which will be removed in v3.
    - Deprecated `InvariantCultureWarning` option, which will be removed in v3.
    - Deprecated `NotProcessedWarning` option, which will be removed in v3.
  - Improved schema display names by @BernieWhite.
    [#1488](https://github.com/microsoft/PSRule/issues/1488)
- Engineering:
  - Bump Pester to v5.4.1.
    [#1510](https://github.com/microsoft/PSRule/pull/1510)
  - Bump Microsoft.NET.Test.Sdk to v17.6.2.
    [#1544](https://github.com/microsoft/PSRule/pull/1544)
  - Bump Microsoft.CodeAnalysis.Common to v4.6.0.
    [#1534](https://github.com/microsoft/PSRule/pull/1534)
- Bug fixes:
  - Fixed tool output on access denied to path by @BernieWhite.
    [#1490](https://github.com/microsoft/PSRule/issues/1490)
  - Fixed tool exit code on error or failure by @BernieWhite.
    [#1491](https://github.com/microsoft/PSRule/issues/1491)
  - Fixed include local not automatically being enabled for default module baseline by @BernieWhite.
    [#1506](https://github.com/microsoft/PSRule/issues/1506)

What's changed since pre-release v2.9.0-B0068:

- No additional changes.

## v2.9.0-B0068 (pre-release)

What's changed since pre-release v2.9.0-B0033:

- New features:
  - **Experimental**: Added support for baseline groups by @BernieWhite.
    [#1541](https://github.com/microsoft/PSRule/issues/1541)
    - Baseline groups allow you to reference a baseline by a friendly name.
    - Update the baseline group to point to a new baseline.
    - Currently only a single baseline can be referenced by a baseline group.
    - See [baselines][6] for more information.
- General improvements:
  - Added style and improved handling for restore command by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)
- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.6.2.
    [#1544](https://github.com/microsoft/PSRule/pull/1544)
  - Bump Microsoft.CodeAnalysis.Common to v4.6.0.
    [#1534](https://github.com/microsoft/PSRule/pull/1534)
- Bug fixes:
  - Fixed include local not automatically being enabled for default module baseline by @BernieWhite.
    [#1506](https://github.com/microsoft/PSRule/issues/1506)

## v2.9.0-B0033 (pre-release)

What's changed since pre-release v2.9.0-B0013:

- New features:
  - Added sub-selector quantifiers for `allOf` or `anyOf` operators by @BernieWhite.
    [#1423](https://github.com/microsoft/PSRule/issues/1423)
    - Quantifiers allow you to specify the number of matches with `count`, `less`, `lessOrEqual`, `greater`, or `greaterOrEqual`.
    - See [Sub-selectors][4] for more information.
  - Added support for new functions by @BernieWhite.
    [#1422](https://github.com/microsoft/PSRule/issues/1422)
    - Added support for `padLeft`, and `padRight`.

## v2.9.0-B0013 (pre-release)

What's changed since release v2.8.1:

- General improvements:
  - **Important change**: Rename of execution options by @BernieWhite.
    [#1456](https://github.com/microsoft/PSRule/issues/1456)
    - Renamed options allow configuration of output level as `Ignore`, `Warn`, `Error`, or `Debug`.
    - `Execution.AliasReferenceWarning` is replaced with `Execution.AliasReference`.
    - `Execution.InconclusiveWarning` is replaced with `Execution.RuleInconclusive`.
    - `Execution.InvariantCultureWarning` is replaced with `Execution.InvariantCulture`.
    - `Execution.NotProcessedWarning` is replaced with `Execution.UnprocessedObject`.
    - Deprecated `AliasReferenceWarning` option, which will be removed in v3.
    - Deprecated `InconclusiveWarning` option, which will be removed in v3.
    - Deprecated `InvariantCultureWarning` option, which will be removed in v3.
    - Deprecated `NotProcessedWarning` option, which will be removed in v3.
  - Improved schema display names by @BernieWhite.
    [#1488](https://github.com/microsoft/PSRule/issues/1488)
- Engineering:
  - Bump Pester to v5.4.1.
    [#1510](https://github.com/microsoft/PSRule/pull/1510)
  - Bump Microsoft.CodeAnalysis.Common to v4.5.0.
    [#1455](https://github.com/microsoft/PSRule/pull/1455)
- Bug fixes:
  - Fixed tool output on access denied to path by @BernieWhite.
    [#1490](https://github.com/microsoft/PSRule/issues/1490)
  - Fixed tool exit code on error or failure by @BernieWhite.
    [#1491](https://github.com/microsoft/PSRule/issues/1491)

## v2.8.1

What's changed since release v2.8.0:

- Bug fixes:
  - Fixed wrong message for excluded rules by @BernieWhite.
    [#1493](https://github.com/microsoft/PSRule/issues/1493)
  - Fixed job summary reports completed time by @BernieWhite.
    [#1492](https://github.com/microsoft/PSRule/issues/1492)

## v2.8.0

What's changed since release v2.7.0:

- General improvements:
  - **Important change**: Replaced `SuppressedRuleWarning` execution option with `RuleSuppressed` by @BernieWhite.
    [#1456](https://github.com/microsoft/PSRule/issues/1456)
    - Improved options for output of suppressed rules with `RuleSuppressed` option.
    - Deprecated `SuppressedRuleWarning` option, which will be removed in v3.
  - Added support for logging excluded rules by @BernieWhite.
    [#1432](https://github.com/microsoft/PSRule/issues/1432)
  - Added additional options to schema for PSRule for Azure by @BernieWhite.
    [#1446](https://github.com/microsoft/PSRule/issues/1446)
  - Improved error message for failing to read options file by @BernieWhite.
    [#1433](https://github.com/microsoft/PSRule/issues/1433)
  - Added support for import within initialize block by @BernieWhite.
    [#1448](https://github.com/microsoft/PSRule/issues/1448)
  - Added support for direct typing on import by @BernieWhite.
    [#1449](https://github.com/microsoft/PSRule/issues/1449)
    - Use the `$PSRule.ImportWithType` method to import an object with a specific type.
  - Added support for case sensitivity matching with `match` and `notMatch` expressions by @BernieWhite.
    [#1480](https://github.com/microsoft/PSRule/issues/1480)
- Engineering:
  - Bump Pester to v5.4.0.
    [#1414](https://github.com/microsoft/PSRule/pull/1414)
    Bump Microsoft.CodeAnalysis.Common to v4.4.0.
    [#1341](https://github.com/microsoft/PSRule/pull/1341)
  - Bump BenchmarkDotNet to v0.13.5.
    [#1413](https://github.com/microsoft/PSRule/pull/1437)
  - Bump BenchmarkDotNet.Diagnostics.Windows to v0.13.5.
    [#1413](https://github.com/microsoft/PSRule/pull/1437)
  - Bump Microsoft.NET.Test.Sdk to v17.5.0.
    [#1442](https://github.com/microsoft/PSRule/pull/1442)
  - Bump Newtonsoft.Json to v13.0.3.
    [#1467](https://github.com/microsoft/PSRule/pull/1467)
  - Bump Microsoft.CodeAnalysis.NetAnalyzers to v7.0.1.
    [#1468](https://github.com/microsoft/PSRule/pull/1468)
- Bug fixes:
  - Fixes handling of numerics in tests for that are impacted by regional format by @BernieWhite.
    [#1405](https://github.com/microsoft/PSRule/issues/1405)
  - Fixed no output with using job summary with as summary by @BernieWhite.
    [#1483](https://github.com/microsoft/PSRule/issues/1483)
    - Fixed output and added error for unsupported scenarios.
  - Fixed LocalizedData is not exposed to if pre-conditions by @BernieWhite.
    [#1083](https://github.com/microsoft/PSRule/issues/1083)
  - Fixed LocalizedData is not exposed to conventions by @BernieWhite.
    [#1477](https://github.com/microsoft/PSRule/issues/1477)
  - Fixed problem binding when not set locally by @BernieWhite.
    [#1473](https://github.com/microsoft/PSRule/issues/1473)

What's changed since pre-release v2.8.0-B0171:

- No additional changes.

## v2.8.0-B0171 (pre-release)

What's changed since pre-release v2.8.0-B0121:

- General improvements:
  - Added support for case sensitivity matching with `match` and `notMatch` expressions by @BernieWhite.
    [#1480](https://github.com/microsoft/PSRule/issues/1480)
- Bug fixes:
  - Fixed no output with using job summary with as summary by @BernieWhite.
    [#1483](https://github.com/microsoft/PSRule/issues/1483)
    - Fixed output and added error for unsupported scenarios.

## v2.8.0-B0121 (pre-release)

What's changed since pre-release v2.8.0-B0076:

- Bug fixes:
  - Fixed LocalizedData is not exposed to if pre-conditions by @BernieWhite.
    [#1083](https://github.com/microsoft/PSRule/issues/1083)
  - Fixed LocalizedData is not exposed to conventions by @BernieWhite.
    [#1477](https://github.com/microsoft/PSRule/issues/1477)

## v2.8.0-B0076 (pre-release)

What's changed since pre-release v2.8.0-B0034:

- Engineering:
  - Bump Newtonsoft.Json to v13.0.3.
    [#1467](https://github.com/microsoft/PSRule/pull/1467)
  - Bump Microsoft.CodeAnalysis.NetAnalyzers to v7.0.1.
    [#1468](https://github.com/microsoft/PSRule/pull/1468)
- Bug fixes:
  - Fixed problem binding when not set locally by @BernieWhite.
    [#1473](https://github.com/microsoft/PSRule/issues/1473)

## v2.8.0-B0034 (pre-release)

What's changed since v2.7.0:

- General improvements:
  - **Important change**: Replaced `SuppressedRuleWarning` execution option with `RuleSuppressed` by @BernieWhite.
    [#1456](https://github.com/microsoft/PSRule/issues/1456)
    - Improved options for output of suppressed rules with `RuleSuppressed` option.
    - Deprecated `SuppressedRuleWarning` option, which will be removed in v3.
  - Added support for logging excluded rules by @BernieWhite.
    [#1432](https://github.com/microsoft/PSRule/issues/1432)
  - Added additional options to schema for PSRule for Azure by @BernieWhite.
    [#1446](https://github.com/microsoft/PSRule/issues/1446)
  - Improved error message for failing to read options file by @BernieWhite.
    [#1433](https://github.com/microsoft/PSRule/issues/1433)
  - Added support for import within initialize block by @BernieWhite.
    [#1448](https://github.com/microsoft/PSRule/issues/1448)
  - Added support for direct typing on import by @BernieWhite.
    [#1449](https://github.com/microsoft/PSRule/issues/1449)
    - Use the `$PSRule.ImportWithType` method to import an object with a specific type.
- Engineering:
  - Bump Pester to v5.4.0.
    [#1414](https://github.com/microsoft/PSRule/pull/1414)
  - Bump Microsoft.CodeAnalysis.NetAnalyzers to v7.0.0.
    [#1374](https://github.com/microsoft/PSRule/pull/1374)
    Bump Microsoft.CodeAnalysis.Common to v4.4.0.
    [#1341](https://github.com/microsoft/PSRule/pull/1341)
  - Bump BenchmarkDotNet to v0.13.5.
    [#1413](https://github.com/microsoft/PSRule/pull/1437)
  - Bump BenchmarkDotNet.Diagnostics.Windows to v0.13.5.
    [#1413](https://github.com/microsoft/PSRule/pull/1437)
  - Bump Microsoft.NET.Test.Sdk to v17.5.0.
    [#1442](https://github.com/microsoft/PSRule/pull/1442)
- Bug fixes:
  - Fixes handling of numerics in tests for that are impacted by regional format by @BernieWhite.
    [#1405](https://github.com/microsoft/PSRule/issues/1405)

## v2.7.0

What's changed since v2.6.0:

- New features:
  - Added API version date comparison assertion method and expression by @BernieWhite.
    [#1356](https://github.com/microsoft/PSRule/issues/1356)
  - Added support for new functions by @BernieWhite.
    [#1227](https://github.com/microsoft/PSRule/issues/1227)
    - Added support for `trim`, `replace`, `split`, `first`, and `last`.
- General improvements:
  - Added support target scope by @BernieWhite.
    [#1350](https://github.com/microsoft/PSRule/issues/1350)
  - Added support for `hasValue` expression with `scope` by @BernieWhite.
    [#1382](https://github.com/microsoft/PSRule/issues/1382)
  - Return target object scope as an array by @BernieWhite.
    [#1383](https://github.com/microsoft/PSRule/issues/1383)
  - Improve support of string comparisons to support an array of strings by @BernieWhite.
    [#1384](https://github.com/microsoft/PSRule/issues/1384)
  - Added help properties to rules from YAML/ JSON resources by @BernieWhite.
    [#1386](https://github.com/microsoft/PSRule/issues/1386)
- Engineering:
  - Bump Newtonsoft.Json to v13.0.2.
    [#1358](https://github.com/microsoft/PSRule/pull/1358)
  - Bump System.Drawing.Common to v7.0.0.
    [#1332](https://github.com/microsoft/PSRule/pull/1332)
  - Bump Microsoft.NET.Test.Sdk to v17.4.1.
    [#1389](https://github.com/microsoft/PSRule/pull/1389)
- Bug fixes:
  - Fixed exception with comments in JSON baselines by @BernieWhite.
    [#1336](https://github.com/microsoft/PSRule/issues/1336)
  - Fixed handling of constrained language mode with PowerShell 7.3 by @BernieWhite.
    [#1348](https://github.com/microsoft/PSRule/issues/1348)
  - Fixed exception calling `RuleSource` value cannot be null by @BernieWhite.
    [#1343](https://github.com/microsoft/PSRule/issues/1343)
  - Fixed null reference for link property by @BernieWhite.
    [#1393](https://github.com/microsoft/PSRule/issues/1393)
  - Fixed reason are emitted for pre-condition sub-selectors by @BernieWhite.
    [#1394](https://github.com/microsoft/PSRule/issues/1394)
  - Fixed CLI failed to load required assemblies by @BernieWhite.
    [#1361](https://github.com/microsoft/PSRule/issues/1361)
  - Fixed CLI ignores modules specified in `Include.Modules` by @BernieWhite.
    [#1362](https://github.com/microsoft/PSRule/issues/1362)
  - Fixed job summary directory creation by @BernieWhite.
    [#1353](https://github.com/microsoft/PSRule/issues/1353)
  - Fixed same key for ref and name by @BernieWhite
    [#1354](https://github.com/microsoft/PSRule/issues/1354)
  - Fixed object path fails to iterate JSON object with wildcard selector by @BernieWhite.
    [#1376](https://github.com/microsoft/PSRule/issues/1376)
  - Fixed rule annotations are not included from YAML/ JSON definition by @BernieWhite.
    [#1378](https://github.com/microsoft/PSRule/issues/1378)
  - Fixed loop stuck parsing JSON `allOf` `not` rule condition by @BernieWhite.
    [#1370](https://github.com/microsoft/PSRule/issues/1370)
  - Fixed handling of uint64 with `LessOrEqual` assertion method by @BernieWhite.
    [#1366](https://github.com/microsoft/PSRule/issues/1366)

What's changed since pre-release v2.7.0-B0126:

- No additional changes.

## v2.7.0-B0126 (pre-release)

What's changed since pre-release v2.7.0-B0097:

- Bug fixes:
  - Fixed null reference for link property by @BernieWhite.
    [#1393](https://github.com/microsoft/PSRule/issues/1393)
  - Fixed reason are emitted for pre-condition sub-selectors by @BernieWhite.
    [#1394](https://github.com/microsoft/PSRule/issues/1394)

## v2.7.0-B0097 (pre-release)

What's changed since pre-release v2.7.0-B0070:

- General improvements:
  - Added support for `hasValue` expression with `scope` by @BernieWhite.
    [#1382](https://github.com/microsoft/PSRule/issues/1382)
  - Return target object scope as an array by @BernieWhite.
    [#1383](https://github.com/microsoft/PSRule/issues/1383)
  - Improve support of string comparisons to support an array of strings by @BernieWhite.
    [#1384](https://github.com/microsoft/PSRule/issues/1384)
  - Added help properties to rules from YAML/ JSON resources by @BernieWhite.
    [#1386](https://github.com/microsoft/PSRule/issues/1386)
- Engineering:
  - Bump Newtonsoft.Json to v13.0.2.
    [#1358](https://github.com/microsoft/PSRule/pull/1358)
  - Bump System.Drawing.Common to v7.0.0.
    [#1332](https://github.com/microsoft/PSRule/pull/1332)
  - Bump Microsoft.NET.Test.Sdk to v17.4.1.
    [#1389](https://github.com/microsoft/PSRule/pull/1389)

## v2.7.0-B0070 (pre-release)

What's changed since pre-release v2.7.0-B0049:

- Bug fixes:
  - Fixed object path fails to iterate JSON object with wildcard selector by @BernieWhite.
    [#1376](https://github.com/microsoft/PSRule/issues/1376)
  - Fixed rule annotations are not included from YAML/ JSON definition by @BernieWhite.
    [#1378](https://github.com/microsoft/PSRule/issues/1378)

## v2.7.0-B0049 (pre-release)

What's changed since pre-release v2.7.0-B0031:

- Bug fixes:
  - Fixed loop stuck parsing JSON `allOf` `not` rule condition by @BernieWhite.
    [#1370](https://github.com/microsoft/PSRule/issues/1370)
  - Fixed handling of uint64 with `LessOrEqual` assertion method by @BernieWhite.
    [#1366](https://github.com/microsoft/PSRule/issues/1366)

## v2.7.0-B0031 (pre-release)

What's changed since pre-release v2.7.0-B0016:

- New features:
  - Added API version date comparison assertion method and expression by @BernieWhite.
    [#1356](https://github.com/microsoft/PSRule/issues/1356)
  - Added support for new functions by @BernieWhite.
    [#1227](https://github.com/microsoft/PSRule/issues/1227)
    - Added support for `trim`, `replace`, `split`, `first`, and `last`.
- Bug fixes:
  - Fixed CLI failed to load required assemblies by @BernieWhite.
    [#1361](https://github.com/microsoft/PSRule/issues/1361)
  - Fixed CLI ignores modules specified in `Include.Modules` by @BernieWhite.
    [#1362](https://github.com/microsoft/PSRule/issues/1362)

## v2.7.0-B0016 (pre-release)

What's changed since pre-release v2.7.0-B0006:

- Bug fixes:
  - Fixed job summary directory creation by @BernieWhite.
    [#1353](https://github.com/microsoft/PSRule/issues/1353)
  - Fixed same key for ref and name by @BernieWhite
    [#1354](https://github.com/microsoft/PSRule/issues/1354)

## v2.7.0-B0006 (pre-release)

What's changed since pre-release v2.7.0-B0001:

- General improvements:
  - Added support target scope by @BernieWhite.
    [#1350](https://github.com/microsoft/PSRule/issues/1350)
- Bug fixes:
  - Fixed exception with comments in JSON baselines by @BernieWhite.
    [#1336](https://github.com/microsoft/PSRule/issues/1336)
  - Fixed handling of constrained language mode with PowerShell 7.3 by @BernieWhite.
    [#1348](https://github.com/microsoft/PSRule/issues/1348)

## v2.7.0-B0001 (pre-release)

What's changed since v2.6.0:

- Bug fixes:
  - Fixed exception calling `RuleSource` value cannot be null by @BernieWhite.
    [#1343](https://github.com/microsoft/PSRule/issues/1343)

## v2.6.0

What's changed since v2.5.3:

- New features:
  - Added support for generating job summaries by @BernieWhite.
    [#1264](https://github.com/microsoft/PSRule/issues/1264)
    - Job summaries provide a markdown output for pipelines in addition to other supported output formats.
    - To use, configure the `Output.JobSummaryPath` option.
  - Added support for time bound suppression groups by @BernieWhite.
    [#1335](https://github.com/microsoft/PSRule/issues/1335)
    - Suppression groups can be configured to expire after a specified time by setting the `spec.expiresOn` property.
    - When a suppression group expires, the suppression group will generate a warning by default.
    - Configure the `Execution.SuppressionGroupExpired` option to ignore or error on expired suppression groups.
- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.4.0.
    [#1331](https://github.com/microsoft/PSRule/pull/1331)
  - Bump PSScriptAnalyzer to v1.21.0.
    [#1318](https://github.com/microsoft/PSRule/pull/1318)
  - Class clean up and documentation by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)

What's changed since pre-release v2.6.0-B0034:

- No additional changes.

## v2.6.0-B0034 (pre-release)

What's changed since pre-release v2.6.0-B0013:

- New features:
  - Added support for generating job summaries by @BernieWhite.
    [#1264](https://github.com/microsoft/PSRule/issues/1264)
    - Job summaries provide a markdown output for pipelines in addition to other supported output formats.
    - To use, configure the `Output.JobSummaryPath` option.
  - Added support for time bound suppression groups by @BernieWhite.
    [#1335](https://github.com/microsoft/PSRule/issues/1335)
    - Suppression groups can be configured to expire after a specified time by setting the `spec.expiresOn` property.
    - When a suppression group expires, the suppression group will generate a warning by default.
    - Configure the `Execution.SuppressionGroupExpired` option to ignore or error on expired suppression groups.
- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.4.0.
    [#1331](https://github.com/microsoft/PSRule/pull/1331)

## v2.6.0-B0013 (pre-release)

What's changed since v2.5.3:

- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.3.2.
    [#1283](https://github.com/microsoft/PSRule/pull/1283)
  - Bump PSScriptAnalyzer to v1.21.0.
    [#1318](https://github.com/microsoft/PSRule/pull/1318)
  - Class clean up and documentation by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)

## v2.5.3

What's changed since v2.5.2:

- Bug fixes:
  - Fixed incorrect XML header for encoding by @BernieWhite.
    [#1322](https://github.com/microsoft/PSRule/issues/1322)

## v2.5.2

What's changed since v2.5.1:

- Bug fixes:
  - Fixed NUnit output does not escape characters in all result properties by @BernieWhite.
    [#1316](https://github.com/microsoft/PSRule/issues/1316)

## v2.5.1

What's changed since v2.5.0:

- Bug fixes:
  - Fixed `In` with array source object and dot object path by @BernieWhite.
    [#1314](https://github.com/microsoft/PSRule/issues/1314)

## v2.5.0

What's changed since v2.4.2:

- New features:
  - **Experimental**: Added support for only processing changed files by @BernieWhite.
    [#688](https://github.com/microsoft/PSRule/issues/688)
    - To ignore unchanged files, set the `Input.IgnoreUnchangedPath` option to `true`.
    - See [creating your pipeline][5] for more information.
- General improvements:
  - Added labels metadata from grouping and filtering rules by @BernieWhite.
    [#1272](https://github.com/microsoft/PSRule/issues/1272)
    - Labels are metadata that extends on tags to provide a more structured way to group rules.
    - Rules can be classified by setting the `metadata.labels` property or `-Labels` parameter.
  - Provide unblock for command line tools by @BernieWhite.
    [#1261](https://github.com/microsoft/PSRule/issues/1261)
- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.3.1.
    [#1248](https://github.com/microsoft/PSRule/pull/1248)
- Bug fixes:
  - Fixed could not load Microsoft.Management.Infrastructure by @BernieWhite.
    [#1249](https://github.com/microsoft/PSRule/issues/1249)
    - To use minimal initial session state set `Execution.InitialSessionState` to `Minimal`.
  - Fixed unhandled exception with GetRootedPath by @BernieWhite.
    [#1251](https://github.com/microsoft/PSRule/issues/1251)
  - Fixed Dockerfile case sensitivity by @BernieWhite.
    [#1269](https://github.com/microsoft/PSRule/issues/1269)

What's changed since pre-release v2.5.0-B0080:

- No additional changes.

## v2.5.0-B0080 (pre-release)

What's changed since pre-release v2.5.0-B0045:

- Bug fixes:
  - Fixed exception with `PathExpressionBuilder.GetAllRecurse` by @BernieWhite.
    [#1301](https://github.com/microsoft/PSRule/issues/1301)

## v2.5.0-B0045 (pre-release)

What's changed since pre-release v2.5.0-B0015:

- New features:
  - **Experimental**: Added support for only processing changed files by @BernieWhite.
    [#688](https://github.com/microsoft/PSRule/issues/688)
    - To ignore unchanged files, set the `Input.IgnoreUnchangedPath` option to `true`.
    - See [creating your pipeline][5] for more information.
- General improvements:
  - Added labels metadata from grouping and filtering rules by @BernieWhite.
    [#1272](https://github.com/microsoft/PSRule/issues/1272)
    - Labels are metadata that extends on tags to provide a more structured way to group rules.
    - Rules can be classified by setting the `metadata.labels` property or `-Labels` parameter.
- Bug fixes:
  - Fixed Dockerfile case sensitivity by @BernieWhite.
    [#1269](https://github.com/microsoft/PSRule/issues/1269)
  - Fixed markdown parsing of Spanish translated help fails by @BernieWhite @jonathanruiz.
    [#1286](https://github.com/microsoft/PSRule/issues/1286)
    [#1285](https://github.com/microsoft/PSRule/pull/1285)

## v2.5.0-B0015 (pre-release)

What's changed since pre-release v2.5.0-B0004:

- General improvements:
  - Provide unblock for command line tools by @BernieWhite.
    [#1261](https://github.com/microsoft/PSRule/issues/1261)

## v2.5.0-B0004 (pre-release)

What's changed since v2.4.0:

- Engineering:
  - Bump Microsoft.NET.Test.Sdk to v17.3.1.
    [#1248](https://github.com/microsoft/PSRule/pull/1248)
- Bug fixes:
  - Fixed could not load Microsoft.Management.Infrastructure by @BernieWhite.
    [#1249](https://github.com/microsoft/PSRule/issues/1249)
    - To use minimal initial session state set `Execution.InitialSessionState` to `Minimal`.
  - Fixed unhandled exception with GetRootedPath by @BernieWhite.
    [#1251](https://github.com/microsoft/PSRule/issues/1251)

## v2.4.2

What's changed since v2.4.1:

- Bug fixes:
  - Fixed exception with `PathExpressionBuilder.GetAllRecurse` by @BernieWhite.
    [#1301](https://github.com/microsoft/PSRule/issues/1301)

## v2.4.1

What's changed since v2.4.0:

- Bug fixes:
  - Fixed markdown parsing of Spanish translated help fails by @BernieWhite @jonathanruiz.
    [#1286](https://github.com/microsoft/PSRule/issues/1286)
    [#1285](https://github.com/microsoft/PSRule/pull/1285)

## v2.4.0

What's changed since v2.3.2:

- New features:
  - **Experimental**: Added support for functions within YAML and JSON expressions by @BernieWhite.
    [#1227](https://github.com/microsoft/PSRule/issues/1227)
    [#1016](https://github.com/microsoft/PSRule/issues/1016)
    - Added conversion functions `boolean`, `string`, and `integer`.
    - Added lookup functions `configuration`, and `path`.
    - Added string functions `concat`, `substring`.
    - See [functions][3] for more information.
  - **Experimental**: Added support for sub-selector YAML and JSON expressions by @BernieWhite.
    [#1024](https://github.com/microsoft/PSRule/issues/1024)
    [#1045](https://github.com/microsoft/PSRule/issues/1045)
    - Sub-selector pre-conditions add an additional expression to determine if a rule is executed.
    - Sub-selector object filters provide an way to filter items from list properties.
    - See [sub-selectors][4] for more information.
- Engineering:
  - Improvements to PSRule engine API documentation by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)
  - Updates to PSRule engine API by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)
    - Added tool support for baselines parameter.
    - Added module path discovery.
    - Added output for verbose and debug messages.
  - Bump support projects to .NET 6 by @BernieWhite.
    [#1209](https://github.com/microsoft/PSRule/issues/1209)
  - Bump Microsoft.NET.Test.Sdk to v17.3.0.
    [#1213](https://github.com/microsoft/PSRule/pull/1213)
  - Bump BenchmarkDotNet to v0.13.2.
    [#1241](https://github.com/microsoft/PSRule/pull/1241)
  - Bump BenchmarkDotNet.Diagnostics.Windows to v0.13.2.
    [#1242](https://github.com/microsoft/PSRule/pull/1242)
- Bug fixes:
  - Fixed reporting of duplicate identifiers which were not generating an error for all cases by @BernieWhite.
    [#1229](https://github.com/microsoft/PSRule/issues/1229)
    - Added `Execution.DuplicateResourceId` option to configure PSRule behaviour.
    - By default, duplicate resource identifiers return an error.
  - Fixed exception on JSON baseline without a synopsis by @BernieWhite.
    [#1230](https://github.com/microsoft/PSRule/issues/1230)
  - Fixed repository information not in output by @BernieWhite.
    [#1219](https://github.com/microsoft/PSRule/issues/1219)

What's changed since pre-release v2.4.0-B0091:

- No additional changes.

## v2.4.0-B0091 (pre-release)

What's changed since pre-release v2.4.0-B0063:

- Engineering:
  - Bump BenchmarkDotNet to v0.13.2.
    [#1241](https://github.com/microsoft/PSRule/pull/1241)
  - Bump BenchmarkDotNet.Diagnostics.Windows to v0.13.2.
    [#1242](https://github.com/microsoft/PSRule/pull/1242)

## v2.4.0-B0063 (pre-release)

What's changed since pre-release v2.4.0-B0039:

- New features:
  - **Experimental**: Added support for sub-selector YAML and JSON expressions by @BernieWhite.
    [#1024](https://github.com/microsoft/PSRule/issues/1024)
    [#1045](https://github.com/microsoft/PSRule/issues/1045)
    - Sub-selector pre-conditions add an additional expression to determine if a rule is executed.
    - Sub-selector object filters provide an way to filter items from list properties.
    - See [sub-selectors][4] for more information.
- Engineering:
  - Improvements to PSRule engine API documentation by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)

## v2.4.0-B0039 (pre-release)

What's changed since pre-release v2.4.0-B0022:

- New features:
  - **Experimental**: Added support for functions within YAML and JSON expressions by @BernieWhite.
    [#1227](https://github.com/microsoft/PSRule/issues/1227)
    [#1016](https://github.com/microsoft/PSRule/issues/1016)
    - Added conversion functions `boolean`, `string`, and `integer`.
    - Added lookup functions `configuration`, and `path`.
    - Added string functions `concat`, `substring`.
    - See [functions][3] for more information.
- Bug fixes:
  - Fixed reporting of duplicate identifiers which were not generating an error for all cases by @BernieWhite.
    [#1229](https://github.com/microsoft/PSRule/issues/1229)
    - Added `Execution.DuplicateResourceId` option to configure PSRule behaviour.
    - By default, duplicate resource identifiers return an error.
  - Fixed exception on JSON baseline without a synopsis by @BernieWhite.
    [#1230](https://github.com/microsoft/PSRule/issues/1230)

## v2.4.0-B0022 (pre-release)

What's changed since pre-release v2.4.0-B0009:

- Engineering:
  - Updates to PSRule engine API by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)
    - Added tool support for baselines parameter.
    - Added module path discovery.
    - Added output for verbose and debug messages.

## v2.4.0-B0009 (pre-release)

What's changed since v2.3.2:

- Engineering:
  - Bump support projects to .NET 6 by @BernieWhite.
    [#1209](https://github.com/microsoft/PSRule/issues/1209)
  - Bump Microsoft.NET.Test.Sdk to v17.3.0.
    [#1213](https://github.com/microsoft/PSRule/pull/1213)
- Bug fixes:
  - Fixed repository information not in output by @BernieWhite.
    [#1219](https://github.com/microsoft/PSRule/issues/1219)

## v2.3.2

What's changed since v2.3.1:

- Bug fixes:
  - Fixes lost scope for rules by @BernieWhite.
    [#1214](https://github.com/microsoft/PSRule/issues/1214)

## v2.3.1

What's changed since v2.3.0:

- Bug fixes:
  - Fixed object path join handling of self path identifier by @BernieWhite.
    [#1204](https://github.com/microsoft/PSRule/issues/1204)

## v2.3.0

What's changed since v2.2.0:

- General improvements:
  - Added `PathPrefix` method to add an object path prefix to assertion reasons by @BernieWhite.
    [#1198](https://github.com/microsoft/PSRule/issues/1198)
  - Added support for binding with JSON objects by @BernieWhite.
    [#1182](https://github.com/microsoft/PSRule/issues/1182)
  - Added support for full path from JSON objects by @BernieWhite.
    [#1174](https://github.com/microsoft/PSRule/issues/1174)
  - Improved reporting of full object path from pre-processed results by @BernieWhite.
    [#1169](https://github.com/microsoft/PSRule/issues/1169)
  - Added PSRule for Azure expansion configuration to options schema by @BernieWhite.
    [#1149](https://github.com/microsoft/PSRule/issues/1149)
- Engineering:
  - Bump xunit to v2.4.2.
    [#1200](https://github.com/microsoft/PSRule/pull/1200)
  - Expose online link extension method by @BernieWhite.
    [#1195](https://github.com/microsoft/PSRule/issues/1195)
  - Added comment documentation to .NET classes and interfaces by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)
  - Added publishing support for NuGet symbol packages @BernieWhite.
    [#1173](https://github.com/microsoft/PSRule/issues/1173)
  - Updated outcome option docs by @BernieWhite.
    [#1166](https://github.com/microsoft/PSRule/issues/1166)
  - Bump Sarif.Sdk to v2.4.16.
    [#1177](https://github.com/microsoft/PSRule/pull/1177)
  - Refactoring and updates to interfaces to allow use outside of PowerShell by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)
- Bug fixes:
  - Fixes JSON parsing of string array for single objects by @BernieWhite.
    [#1193](https://github.com/microsoft/PSRule/issues/1193)
  - Fixed handling for JSON objects in rules by @BernieWhite.
    [#1187](https://github.com/microsoft/PSRule/issues/1187)
  - Fixed null object reference for object equity comparison by @BernieWhite.
    [#1157](https://github.com/microsoft/PSRule/issues/1157)
  - Fixed expression evaluation not logging debug output when using the `-Debug` switch by @BernieWhite.
    [#1158](https://github.com/microsoft/PSRule/issues/1158)
  - Fixed startIndex cannot be larger than length of string by @BernieWhite.
    [#1160](https://github.com/microsoft/PSRule/issues/1160)
  - Fixed path within SDK package causes `psd1` to compile by @BernieWhite.
    [#1146](https://github.com/microsoft/PSRule/issues/1146)

What's changed since pre-release v2.3.0-B0163:

- No additional changes.

## v2.3.0-B0163 (pre-release)

What's changed since pre-release v2.3.0-B0130:

- General improvements:
  - Added `PathPrefix` method to add an object path prefix to assertion reasons by @BernieWhite.
    [#1198](https://github.com/microsoft/PSRule/issues/1198)
- Engineering:
  - Bump xunit to v2.4.2.
    [#1200](https://github.com/microsoft/PSRule/pull/1200)

## v2.3.0-B0130 (pre-release)

What's changed since pre-release v2.3.0-B0100:

- Engineering:
  - Expose online link extension method by @BernieWhite.
    [#1195](https://github.com/microsoft/PSRule/issues/1195)
- Bug fixes:
  - Fixes JSON parsing of string array for single objects by @BernieWhite.
    [#1193](https://github.com/microsoft/PSRule/issues/1193)

## v2.3.0-B0100 (pre-release)

What's changed since pre-release v2.3.0-B0074:

- Engineering:
  - Added comment documentation to .NET classes and interfaces by @BernieWhite.
    [#1186](https://github.com/microsoft/PSRule/issues/1186)
- Bug fixes:
  - Fixed handling for JSON objects in rules by @BernieWhite.
    [#1187](https://github.com/microsoft/PSRule/issues/1187)

## v2.3.0-B0074 (pre-release)

What's changed since pre-release v2.3.0-B0051:

- General improvements:
  - Added support for binding with JSON objects by @BernieWhite.
    [#1182](https://github.com/microsoft/PSRule/issues/1182)

## v2.3.0-B0051 (pre-release)

What's changed since pre-release v2.3.0-B0030:

- General improvements:
  - Added support for full path from JSON objects by @BernieWhite.
    [#1174](https://github.com/microsoft/PSRule/issues/1174)
- Engineering:
  - Added publishing support for NuGet symbol packages @BernieWhite.
    [#1173](https://github.com/microsoft/PSRule/issues/1173)
  - Updated outcome option docs by @BernieWhite.
    [#1166](https://github.com/microsoft/PSRule/issues/1166)
  - Bump Sarif.Sdk to v2.4.16.
    [#1177](https://github.com/microsoft/PSRule/pull/1177)

## v2.3.0-B0030 (pre-release)

What's changed since pre-release v2.3.0-B0015:

- General improvements:
  - Improved reporting of full object path from pre-processed results by @BernieWhite.
    [#1169](https://github.com/microsoft/PSRule/issues/1169)

## v2.3.0-B0015 (pre-release)

What's changed since pre-release v2.3.0-B0006:

- Bug fixes:
  - Fixed null object reference for object equity comparison by @BernieWhite.
    [#1157](https://github.com/microsoft/PSRule/issues/1157)
  - Fixed expression evaluation not logging debug output when using the `-Debug` switch by @BernieWhite.
    [#1158](https://github.com/microsoft/PSRule/issues/1158)
  - Fixed startIndex cannot be larger than length of string by @BernieWhite.
    [#1160](https://github.com/microsoft/PSRule/issues/1160)

## v2.3.0-B0006 (pre-release)

What's changed since pre-release v2.3.0-B0001:

- General improvements:
  - Added PSRule for Azure expansion configuration to options schema by @BernieWhite.
    [#1149](https://github.com/microsoft/PSRule/issues/1149)
- Engineering:
  - Refactoring and updates to interfaces to allow use outside of PowerShell by @BernieWhite.
    [#1152](https://github.com/microsoft/PSRule/issues/1152)

## v2.3.0-B0001 (pre-release)

What's changed since v2.2.0:

- Bug fixes:
  - Fixed path within SDK package causes `psd1` to compile by @BernieWhite.
    [#1146](https://github.com/microsoft/PSRule/issues/1146)

## v2.2.0

What's changed since v2.1.0:

- New features:
  - Added `notCount` expression and assertion helper by @ArmaanMcleod.
    [#1091](https://github.com/microsoft/PSRule/issues/1091)
- General improvements:
  - Improved reporting of the object path that caused rule failures by @BernieWhite.
    [#1092](https://github.com/microsoft/PSRule/issues/1092)
    - Output include a new `Detail` property with details of the reason and the object path.
    - Custom methods `ReasonFrom` and `ReasonIf` accept a `path` parameter to specify the object path.
  - Added informational message when output has been written to disk by @BernieWhite.
    [#1074](https://github.com/microsoft/PSRule/issues/1074)
    - The `Output.Footer` option now supports `OutputFile` which reports the output file path.
      This is enabled by default.
  - Added descendant selector to object path syntax by @BernieWhite.
    [#1133](https://github.com/microsoft/PSRule/issues/1133)
    - Use `..` to traverse into child objects, for example `$..name` finds names for all nested objects.
- Engineering:
  - Bump Newtonsoft.Json to 13.0.1.
    [#1137](https://github.com/microsoft/PSRule/pull/1137)
  - Added more object path tests by @ArmaanMcleod.
    [#1110](https://github.com/microsoft/PSRule/issues/1110)
  - Bump xunit.runner.visualstudio to 2.4.5.
    [#1084](https://github.com/microsoft/PSRule/pull/1084)
  - Bump Pester to 5.3.3.
    [#1079](https://github.com/microsoft/PSRule/pull/1079)
  - Bump Microsoft.NET.Test.Sdk to 17.2.0.
    [#1089](https://github.com/microsoft/PSRule/pull/1089)
  - Added NuGet packaging publishing by @BernieWhite.
    [#1093](https://github.com/microsoft/PSRule/issues/1093)
  - Updated NuGet packaging metadata by @BernieWhite.
    [#1093](https://github.com/microsoft/PSRule/issues/1093)
- Bug fixes:
  - Fixed output of reason with wide format by @BernieWhite.
    [#1117](https://github.com/microsoft/PSRule/issues/1117)
  - Fixed piped input does not respect excluded paths by @BernieWhite.
    [#1114](https://github.com/microsoft/PSRule/issues/1114)
    - By default, objects are not excluded by source.
    - To exclude piped input based on source configure the `Input.IgnoreObjectSource` option.
  - Fixed issue building a PSRule project by removing PSRule.psd1 from compile target by @BernieWhite.
    [#1140](https://github.com/microsoft/PSRule/issues/1140)
  - Fixed grouping of logical operators in object path by @BernieWhite.
    [#1101](https://github.com/microsoft/PSRule/issues/1101)

What's changed since pre-release v2.2.0-B0175:

- No additional changes.

## v2.2.0-B0175 (pre-release)

What's changed since pre-release v2.2.0-B0131:

- Bug fixes:
  - Fixed issue building a PSRule project by removing PSRule.psd1 from compile target by @BernieWhite.
    [#1140](https://github.com/microsoft/PSRule/issues/1140)

## v2.2.0-B0131 (pre-release)

What's changed since pre-release v2.2.0-B0089:

- General improvements:
  - Added descendant selector to object path syntax by @BernieWhite.
    [#1133](https://github.com/microsoft/PSRule/issues/1133)
    - Use `..` to traverse into child objects, for example `$..name` finds names for all nested objects.
- Engineering:
  - Bump Newtonsoft.Json to 13.0.1.
    [#1137](https://github.com/microsoft/PSRule/pull/1137)

## v2.2.0-B0089 (pre-release)

What's changed since pre-release v2.2.0-B0052:

- General improvements:
  - Improved reporting of the object path that caused rule failures by @BernieWhite.
    [#1092](https://github.com/microsoft/PSRule/issues/1092)
    - Output include a new `Detail` property with details of the reason and the object path.
    - Custom methods `ReasonFrom` and `ReasonIf` accept a `path` parameter to specify the object path.

## v2.2.0-B0052 (pre-release)

What's changed since pre-release v2.2.0-B0021:

- General improvements:
  - Added informational message when output has been written to disk by @BernieWhite.
    [#1074](https://github.com/microsoft/PSRule/issues/1074)
    - The `Output.Footer` option now supports `OutputFile` which reports the output file path.
      This is enabled by default.
- Engineering:
  - Added more object path tests by @ArmaanMcleod.
    [#1110](https://github.com/microsoft/PSRule/issues/1110)
- Bug fixes:
  - Fixed output of reason with wide format by @BernieWhite.
    [#1117](https://github.com/microsoft/PSRule/issues/1117)
  - Fixed piped input does not respect excluded paths by @BernieWhite.
    [#1114](https://github.com/microsoft/PSRule/issues/1114)
    - By default, objects are not excluded by source.
    - To exclude piped input based on source configure the `Input.IgnoreObjectSource` option.

## v2.2.0-B0021 (pre-release)

What's changed since v2.1.0:

- New features:
  - Added `notCount` expression and assertion helper by @ArmaanMcleod.
    [#1091](https://github.com/microsoft/PSRule/issues/1091)
- Engineering:
  - Bump xunit.runner.visualstudio to 2.4.5.
    [#1084](https://github.com/microsoft/PSRule/pull/1084)
  - Bump Pester to 5.3.3.
    [#1079](https://github.com/microsoft/PSRule/pull/1079)
  - Bump Microsoft.NET.Test.Sdk to 17.2.0.
    [#1089](https://github.com/microsoft/PSRule/pull/1089)
  - Added NuGet packaging publishing by @BernieWhite.
    [#1093](https://github.com/microsoft/PSRule/issues/1093)
  - Updated NuGet packaging metadata by @BernieWhite.
    [#1093](https://github.com/microsoft/PSRule/issues/1093)
- Bug fixes:
  - Fixed grouping of logical operators in object path by @BernieWhite.
    [#1101](https://github.com/microsoft/PSRule/issues/1101)

## v2.1.0

What's changed since v2.0.1:

- General improvements:
  - Added `notStartsWith`, `notEndsWith`, and `notContains` expressions and assertion helpers. [#1047](https://github.com/microsoft/PSRule/issues/1047)
  - Added `like`, `notLike` expressions and assertion helpers. [#1048](https://github.com/microsoft/PSRule/issues/1048)
  - Added additional repository paths to ignore by default. [#1043](https://github.com/microsoft/PSRule/issues/1043)
  - Added custom suppression message during PSRule runs. [#1046](https://github.com/microsoft/PSRule/issues/1046)
    - When a rule is suppressed using a suppression group the synopsis is shown in the suppression warning.
    - Configure the suppression group synopsis to display a custom message.
    - Suppression groups synopsis can be localized using markdown documentation.
    - Use markdown to set a culture specific synopsis.
    - Custom suppression messages are not supported when suppressing individual rules using `ps-rule.yaml`.
    - See [about_PSRule_SuppressionGroups] for details.
  - Added source support for string conditions. [#1068](https://github.com/microsoft/PSRule/issues/1068)
- Engineering:
  - Added code signing of module. [#1049](https://github.com/microsoft/PSRule/issues/1049)
  - Added SBOM manifests to module. [#1050](https://github.com/microsoft/PSRule/issues/1050)
  - Bump Sarif.Sdk to 2.4.15. [#1075](https://github.com/microsoft/PSRule/pull/1075)
  - Bump Pester to 5.3.2. [#1062](https://github.com/microsoft/PSRule/pull/1062)
- Bug fixes:
  - **Important change:** Fixed source scope not updated in multi-module runs. [#1053](https://github.com/microsoft/PSRule/issues/1053)
    - Several properties of rule and language block elements have been renamed to improve consistency.
    - From _v3_ custom scripts may not work correctly until you update these names.
    - For details on the updated property names see [deprecations][2].

What's changed since pre-release v2.1.0-B0069:

- No additional changes.

## v2.1.0-B0069 (pre-release)

What's changed since pre-release v2.1.0-B0040:

- General improvements:
  - Added `notStartsWith`, `notEndsWith`, and `notContains` expressions and assertion helpers. [#1047](https://github.com/microsoft/PSRule/issues/1047)
  - Added `like`, `notLike` expressions and assertion helpers. [#1048](https://github.com/microsoft/PSRule/issues/1048)
  - Added additional repository paths to ignore by default. [#1043](https://github.com/microsoft/PSRule/issues/1043)
- Engineering:
  - Bump Sarif.Sdk to 2.4.15. [#1075](https://github.com/microsoft/PSRule/pull/1075)

## v2.1.0-B0040 (pre-release)

What's changed since pre-release v2.1.0-B0015:

- General improvements:
  - Added custom suppression message during PSRule runs. [#1046](https://github.com/microsoft/PSRule/issues/1046)
    - When a rule is suppressed using a suppression group the synopsis is shown in the suppression warning.
    - Configure the suppression group synopsis to display a custom message.
    - Suppression groups synopsis can be localized using markdown documentation.
    - Use markdown to set a culture specific synopsis.
    - Custom suppression messages are not supported when suppressing individual rules using `ps-rule.yaml`.
    - See [about_PSRule_SuppressionGroups] for details.
  - Added source support for string conditions. [#1068](https://github.com/microsoft/PSRule/issues/1068)
- Engineering:
  - Bump Sarif.Sdk to 2.4.14. [#1064](https://github.com/microsoft/PSRule/pull/1064)
  - Bump Pester to 5.3.2. [#1062](https://github.com/microsoft/PSRule/pull/1062)
- Bug fixes:
  - **Important change:** Fixed source scope not updated in multi-module runs. [#1053](https://github.com/microsoft/PSRule/issues/1053)
    - Several properties of rule and language block elements have been renamed to improve consistency.
    - From _v3_ custom scripts may not work correctly until you update these names.
    - For details on the updated property names see [deprecations][2].

## v2.1.0-B0015 (pre-release)

What's changed since v2.0.1:

- Engineering:
  - Added code signing of module. [#1049](https://github.com/microsoft/PSRule/issues/1049)
  - Added SBOM manifests to module. [#1050](https://github.com/microsoft/PSRule/issues/1050)

## v2.0.1

What's changed since v2.0.0:

- Bug fixes:
  - Fixed read JSON failed with comments. [#1051](https://github.com/microsoft/PSRule/issues/1051)
  - Fixed null reference on elapsed time when required module check fails. [#1054](https://github.com/microsoft/PSRule/issues/1054)
  - Fixed failed to read JSON objects with a empty property name. [#1052](https://github.com/microsoft/PSRule/issues/1052)

## v2.0.0

What's changed since v1.11.1:

- New features:
  - Add support for suppression groups. [#793](https://github.com/microsoft/PSRule/issues/793)
    - New `SuppressionGroup` resource has been included.
    - See [about_PSRule_SuppressionGroups] for details.
  - Added source expression property. [#933](https://github.com/microsoft/PSRule/issues/933)
    - Included the following expressions:
      - `source`
      - `withinPath`
      - `notWithinPath`
  - Added support for rule severity level. [#880](https://github.com/microsoft/PSRule/issues/880)
    - Rules can be configured to be `Error`, `Warning`, or `Information`.
    - Failing rules with the `Error` severity level will cause the pipeline to fail.
    - Rules with the `Warning` severity level will be reported as warnings.
    - Rules with the `Information` severity level will be reported as informational messages.
    - By default, the severity level for a rule is `Error`.
  - Added expression support for type based assertions. [#908](https://github.com/microsoft/PSRule/issues/908)
    - Included the following expressions:
      - `IsArray`
      - `IsBoolean`
      - `IsDateTime`
      - `IsInteger`
      - `IsNumeric`
  - Added support for formatting results as SARIF. [#878](https://github.com/microsoft/PSRule/issues/878)
    - Set `Output.Format` to `Sarif` to output results in the SARIF format.
    - See [about_PSRule_Options] for details.
- General improvements:
  - Add option to disable invariant culture warning. [#899](https://github.com/microsoft/PSRule/issues/899)
    - Added `Execution.InvariantCultureWarning` option.
    - See [about_PSRule_Options] for details.
  - Added support for object path expressions. [#808](https://github.com/microsoft/PSRule/issues/808) [#693](https://github.com/microsoft/PSRule/issues/693)
    - Inspired by JSONPath, object path expressions can be used to access nested objects.
    - Array members can be filtered and enumerated using object path expressions.
    - Object path expressions can be used in YAML, JSON, and PowerShell rules and selectors.
    - See [about_PSRule_Assert] for details.
  - Improve tracking of suppressed objects. [#794](https://github.com/microsoft/PSRule/issues/794)
    - Added `Execution.SuppressedRuleWarning` option to output warning for suppressed rules.
  - Added support for rule aliases. [#792](https://github.com/microsoft/PSRule/issues/792)
    - Aliases allow rules to be references by an alternative name.
    - When renaming rules, add a rule alias to avoid breaking references to the old rule name.
    - To specify an alias use the `-Alias` parameter or `alias` metadata property in YAML or JSON.
  - Added support for stable identifiers with rule refs. [#881](https://github.com/microsoft/PSRule/issues/881)
    - A rule ref may be optionally be used to reference a rule.
    - Rule refs should be:
      stable, not changing between releases;
      opaque, as opposed to being a human-readable string.
      Stable and opaque refs ease web lookup and to help to avoid language difficulties.
    - To specify a rule ref use the `-Ref` parameter or `ref` metadata property in YAML or JSON.
  - Added new properties for module lookup to SARIF results. [#951](https://github.com/microsoft/PSRule/issues/951)
  - Capture and output repository info in Assert-PSRule runs. [#978](https://github.com/microsoft/PSRule/issues/978)
    - Added `Repository.Url` option set repository URL reported in output.
    - Repository URL is detected automatically for GitHub Actions and Azure Pipelines.
    - Added `RepositoryInfo` to `Output.Banner` option.
    - Repository info is shown by default.
  - Added `convert` and `caseSensitive` to string comparison expressions. [#1001](https://github.com/microsoft/PSRule/issues/1001)
    - The following expressions support type conversion and case-sensitive comparison.
      - `startsWith`, `contains`, and `endsWith`.
      - `equals` and `notEquals`.
  - Added `convert` to numeric comparison expressions. [#943](https://github.com/microsoft/PSRule/issues/943)
    - Type conversion is now supported for `less`, `lessOrEquals`, `greater`, and `greaterOrEquals`.
  - Added `Extent` property on rules reported by `Get-PSRule`. [#990](https://github.com/microsoft/PSRule/issues/990)
    - Extent provides the line and position of the rule in the source code.
  - **Breaking change:** Added validation of resource names. [#1012](https://github.com/microsoft/PSRule/issues/1012)
    - Invalid rules names will now produce a specific error.
    - See [upgrade notes][1] for more information.
- Engineering:
  - **Breaking change:** Removal of deprecated default baseline from module manifest. [#755](https://github.com/microsoft/PSRule/issues/755)
    - Set the default module baseline using module configuration.
    - See [upgrade notes][1] for details.
  - **Breaking change:** Require `apiVersion` on YAML and JSON to be specified. [#648](https://github.com/microsoft/PSRule/issues/648)
    - Resources should use `github.com/microsoft/PSRule/v1` as the `apiVersion`.
    - Resources that do not specify an `apiVersion` will be ignored.
    - See [upgrade notes][1] for details.
  - **Breaking change:** Prefer module sources over loose files. [#610](https://github.com/microsoft/PSRule/issues/610)
    - Module sources are discovered before loose files.
    - Warning is shown for duplicate rule names, and exception is thrown for duplicate rule Ids.
    - See [upgrade notes][1] for details.
  - **Breaking change:** Require rule sources from current working directory to be explicitly included. [#760](https://github.com/microsoft/PSRule/issues/760)
    - From v2 onwards, `$PWD` is not included by default unless `-Path .` or `-Path $PWD` is explicitly specified.
    - See [upgrade notes][1] for details.
  - Added more tests for JSON resources. [#929](https://github.com/microsoft/PSRule/issues/929)
  - Bump Sarif.Sdk to 2.4.13. [#1007](https://github.com/microsoft/PSRule/pull/1007)
  - Bump PowerShellStandard.Library to 5.1.1. [#999](https://github.com/microsoft/PSRule/pull/999)
- Bug fixes:
  - Fixed object path handling with dash. [#902](https://github.com/microsoft/PSRule/issues/902)
  - Fixed empty suppression group rules property applies to no rules. [#931](https://github.com/microsoft/PSRule/issues/931)
  - Fixed object reference for suppression group will rule not defined. [#932](https://github.com/microsoft/PSRule/issues/932)
  - Fixed rule source loading twice from `$PWD` and `.ps-rule/`. [#939](https://github.com/microsoft/PSRule/issues/939)
  - Fixed rule references in SARIF format for extensions need a toolComponent reference. [#949](https://github.com/microsoft/PSRule/issues/949)
  - Fixed file objects processed with file input format have no source location. [#950](https://github.com/microsoft/PSRule/issues/950)
  - Fixed GitHub code scanning alerts treats pass as problems. [#955](https://github.com/microsoft/PSRule/issues/955)
    - By default, SARIF output will only include fail or error outcomes.
    - Added `Output.SarifProblemsOnly` option to include pass outcomes.
  - Fixed SARIF output includes rule property for default tool component. [#956](https://github.com/microsoft/PSRule/issues/956)
  - Fixed Invoke-PSRule hanging if JSON rule file is empty. [#969](https://github.com/microsoft/PSRule/issues/969)
  - Fixed SARIF should report base branch. [#964](https://github.com/microsoft/PSRule/issues/964)
  - Fixed unclear error message on invalid rule names. [#1012](https://github.com/microsoft/PSRule/issues/1012)

What's changed since pre-release v2.0.0-B2203045:

- No additional changes.

## v2.0.0-B2203045 (pre-release)

What's changed since pre-release v2.0.0-B2203033:

- General improvements:
  - Added `convert` to numeric comparison expressions. [#943](https://github.com/microsoft/PSRule/issues/943)
    - Type conversion is now supported for `less`, `lessOrEquals`, `greater`, and `greaterOrEquals`.
  - **Breaking change:** Added validation of resource names. [#1012](https://github.com/microsoft/PSRule/issues/1012)
    - Invalid rules names will now produce a specific error.
    - See [upgrade notes][1] for more information.
- Bug fixes:
  - Fixed unclear error message on invalid rule names. [#1012](https://github.com/microsoft/PSRule/issues/1012)

## v2.0.0-B2203033 (pre-release)

What's changed since pre-release v2.0.0-B2203019:

- General improvements:
  - Added `Extent` property on rules reported by `Get-PSRule`. [#990](https://github.com/microsoft/PSRule/issues/990)
    - Extent provides the line and position of the rule in the source code.
- Engineering:
  - Bump Sarif.Sdk to 2.4.13. [#1007](https://github.com/microsoft/PSRule/pull/1007)
  - Bump PowerShellStandard.Library to 5.1.1. [#999](https://github.com/microsoft/PSRule/pull/999)

## v2.0.0-B2203019 (pre-release)

What's changed since pre-release v2.0.0-B2202072:

- General improvements:
  - Added `convert` and `caseSensitive` to string comparison expressions. [#1001](https://github.com/microsoft/PSRule/issues/1001)
    - The following expressions support type conversion and case-sensitive comparison.
      - `startsWith`, `contains`, and `endsWith`.
      - `equals` and `notEquals`.

## v2.0.0-B2202072 (pre-release)

What's changed since pre-release v2.0.0-B2202065:

- General improvements:
  - Capture and output repository info in Assert-PSRule runs. [#978](https://github.com/microsoft/PSRule/issues/978)
    - Added `Repository.Url` option set repository URL reported in output.
    - Repository URL is detected automatically for GitHub Actions and Azure Pipelines.
    - Added `RepositoryInfo` to `Output.Banner` option.
    - Repository info is shown by default.
- Bug fixes:
  - Fixed SARIF should report base branch. [#964](https://github.com/microsoft/PSRule/issues/964)

## v2.0.0-B2202065 (pre-release)

What's changed since pre-release v2.0.0-B2202056:

- Bug fixes:
  - Fixed broken documentation links. [#980](https://github.com/microsoft/PSRule/issues/980)

## v2.0.0-B2202056 (pre-release)

What's changed since pre-release v2.0.0-B2202024:

- Bug fixes:
  - Fixed Invoke-PSRule hanging if JSON rule file is empty. [#969](https://github.com/microsoft/PSRule/issues/969)

## v2.0.0-B2202024 (pre-release)

What's changed since pre-release v2.0.0-B2202017:

- New features:
  - Added source expression property. [#933](https://github.com/microsoft/PSRule/issues/933)
    - Included the following expressions:
      - `source`
      - `withinPath`
      - `notWithinPath`

## v2.0.0-B2202017 (pre-release)

What's changed since pre-release v2.0.0-B2202006:

- Bug fixes:
  - Fixed GitHub code scanning alerts treats pass as problems. [#955](https://github.com/microsoft/PSRule/issues/955)
    - By default, SARIF output will only include fail or error outcomes.
    - Added `Output.SarifProblemsOnly` option to include pass outcomes.
  - Fixed SARIF output includes rule property for default tool component. [#956](https://github.com/microsoft/PSRule/issues/956)

## v2.0.0-B2202006 (pre-release)

What's changed since pre-release v2.0.0-B2201161:

- General improvements:
  - Added new properties for module lookup to SARIF results. [#951](https://github.com/microsoft/PSRule/issues/951)
- Bug fixes:
  - Fixed rule references in SARIF format for extensions need a toolComponent reference. [#949](https://github.com/microsoft/PSRule/issues/949)
  - Fixed file objects processed with file input format have no source location. [#950](https://github.com/microsoft/PSRule/issues/950)

## v2.0.0-B2201161 (pre-release)

What's changed since pre-release v2.0.0-B2201146:

- New features:
  - Added support for rule severity level. [#880](https://github.com/microsoft/PSRule/issues/880)
    - Rules can be configured to be `Error`, `Warning`, or `Information`.
    - Failing rules with the `Error` severity level will cause the pipeline to fail.
    - Rules with the `Warning` severity level will be reported as warnings.
    - Rules with the `Information` severity level will be reported as informational messages.
    - By default, the severity level for a rule is `Error`.
  - Added expression support for type based assertions. [#908](https://github.com/microsoft/PSRule/issues/908)
    - Included the following expressions:
      - `IsArray`
      - `IsBoolean`
      - `IsDateTime`
      - `IsInteger`
      - `IsNumeric`
  - Added support for formatting results as SARIF. [#878](https://github.com/microsoft/PSRule/issues/878)
    - Set `Output.Format` to `Sarif` to output results in the SARIF format.
    - See [about_PSRule_Options] for details.

## v2.0.0-B2201146 (pre-release)

What's changed since pre-release v2.0.0-B2201135:

- Engineering:
  - **Breaking change:** Require rule sources from current working directory to be explicitly included. [#760](https://github.com/microsoft/PSRule/issues/760)
    - From v2 onwards, `$PWD` is not included by default unless `-Path .` or `-Path $PWD` is explicitly specified.
    - See [upgrade notes][1] for details.
- Bug fixes:
  - Fixed rule source loading twice from `$PWD` and `.ps-rule/`. [#939](https://github.com/microsoft/PSRule/issues/939)

## v2.0.0-B2201135 (pre-release)

What's changed since pre-release v2.0.0-B2201117:

- Engineering:
  - **Breaking change:** Prefer module sources over loose files. [#610](https://github.com/microsoft/PSRule/issues/610)
    - Module sources are discovered before loose files.
    - Warning is shown for duplicate rule names, and exception is thrown for duplicate rule Ids.
    - See [upgrade notes][1] for details.
  - Added more tests for JSON resources. [#929](https://github.com/microsoft/PSRule/issues/929)
- Bug fixes:
  - Fixed empty suppression group rules property applies to no rules. [#931](https://github.com/microsoft/PSRule/issues/931)
  - Fixed object reference for suppression group will rule not defined. [#932](https://github.com/microsoft/PSRule/issues/932)

## v2.0.0-B2201117 (pre-release)

What's changed since pre-release v2.0.0-B2201093:

- General improvements:
  - Add option to disable invariant culture warning. [#899](https://github.com/microsoft/PSRule/issues/899)
    - Added `Execution.InvariantCultureWarning` option.
    - See [about_PSRule_Options] for details.

## v2.0.0-B2201093 (pre-release)

What's changed since pre-release v2.0.0-B2201075:

- New features:
  - Add support for suppression groups. [#793](https://github.com/microsoft/PSRule/issues/793)
    - New `SuppressionGroup` resource has been included.
    - See [about_PSRule_SuppressionGroups] for details.

## v2.0.0-B2201075 (pre-release)

What's changed since pre-release v2.0.0-B2201054:

- General improvements:
  - Added support for rule aliases. [#792](https://github.com/microsoft/PSRule/issues/792)
    - Aliases allow rules to be references by an alternative name.
    - When renaming rules, add a rule alias to avoid breaking references to the old rule name.
    - To specify an alias use the `-Alias` parameter or `alias` metadata property in YAML or JSON.
  - Added support for stable identifiers with rule refs. [#881](https://github.com/microsoft/PSRule/issues/881)
    - A rule ref may be optionally be used to reference a rule.
    - Rule refs should be:
      stable, not changing between releases;
      opaque, as opposed to being a human-readable string.
      Stable and opaque refs ease web lookup and to help to avoid language difficulties.
    - To specify a rule ref use the `-Ref` parameter or `ref` metadata property in YAML or JSON.
- Bug fixes:
  - Fixed object path handling with dash. [#902](https://github.com/microsoft/PSRule/issues/902)

## v2.0.0-B2201054 (pre-release)

What's changed since v1.11.0:

- General improvements:
  - Added support for object path expressions. [#808](https://github.com/microsoft/PSRule/issues/808) [#693](https://github.com/microsoft/PSRule/issues/693)
    - Inspired by JSONPath, object path expressions can be used to access nested objects.
    - Array members can be filtered and enumerated using object path expressions.
    - Object path expressions can be used in YAML, JSON, and PowerShell rules and selectors.
    - See [about_PSRule_Assert] for details.
  - Improve tracking of suppressed objects. [#794](https://github.com/microsoft/PSRule/issues/794)
    - Added `Execution.SuppressedRuleWarning` option to output warning for suppressed rules.
- Engineering:
  - **Breaking change:** Removal of deprecated default baseline from module manifest. [#755](https://github.com/microsoft/PSRule/issues/755)
    - Set the default module baseline using module configuration.
    - See [upgrade notes][1] for details.
  - **Breaking change:** Require `apiVersion` on YAML and JSON to be specified. [#648](https://github.com/microsoft/PSRule/issues/648)
    - Resources should use `github.com/microsoft/PSRule/v1` as the `apiVersion`.
    - Resources that do not specify an `apiVersion` will be ignored.
    - See [upgrade notes][1] for details.

[about_PSRule_Assert]: concepts/PSRule/en-US/about_PSRule_Assert.md
[about_PSRule_Options]: concepts/PSRule/en-US/about_PSRule_Options.md
[about_PSRule_SuppressionGroups]: concepts/PSRule/en-US/about_PSRule_SuppressionGroups.md
