# Change Log

## [1.9.0] 2024.06.14.

### Added

-   Code completion (for HLSL functions)
-   Document highlights (for HLSL functions)
-   Hover (for HLSL functions)
-   Document symbols (for HLSL functions)
-   Signature help (for HLSL functions)
-   Go to definition (for user HLSL functions)
-   Go to declaration (for user HLSL functions)
-   Go to implementation (for user HLSL functions)
-   Rename (for all language constructs)
-   Find all references (for all language constructs)

### Improved

-   Adding descriptions to several DSHL keywords, modifiers, types, channels, functions, and properties in code completion
-   Adding shader stages and compile targets to code completion, and syntax highlight
-   Improving how document symbols work
-   Updated packages

### Fixed

-   Fixing an error where the function name range wasn't contained by the whole function range
-   Removing backticks from DSHL code completion descriptions, because Visual Studio can't handle markdown
-   Making loop, if, and switch scopes more accurate

## [1.8.1] 2024.05.17.

### Fixed

-   In 1.8.0 I accidentally published the language server 1.7.0, instead of 1.8.0, this release fixes this and makes new features available

## [1.8.0] 2024.05.14.

### Added

-   Code completion (for HLSL struct, class, and enum members)
-   Document highlights (for HLSL struct, class, and enum members)
-   Hover (for HLSL struct, class, and enum members)
-   Go to definition (for HLSL struct, class, and enum members)
-   Go to declaration (for HLSL struct, class, and enum members)
-   Go to implementation (for HLSL struct, and class members)
-   Go to type definition (for HLSL struct, and class members)

### Improved

-   Handling inherited HLSL struct, and class members
-   Handling embedded HLSL structs, classes, interfaces, and enums
-   Handling inline struct, class, interface, and enum declarations
-   Handling anonymous struct, class, interface, and enum declarations
-   Handling arrays
-   Adding type inheritance to syntax highlight
-   Handling built-in HLSL structs and enums
-   Adding built-in struct and enum members with descriptions and values
-   Adding descriptions to code completion from the new DSHL docs
-   Handling casting
-   Making enum members available in enum declarations
-   Handling non-class enum members
-   Handling prefixed enum members
-   Adding type usages from function return types
-   Making identifiers before double colons colored as types

### Fixed

-   Fixing a bug where the extension couldn't find type declarations outside of the current hlsl block
-   Removing the public modifier, from syntax highlight and code completion
-   Fixing an error where function parameters and some other variables could leak out of their scopes
-   Fixing enum positions in macros
-   Coloring built-in HLSL structs and enums as entity types to better match general syntax highlight

## [1.7.0] 2024.04.22.

### Added

-   Code completion (for HLSL variables, structs, enums, classes, and interfaces)
-   Document highlights (for HLSL variables, structs, enums, classes, and interfaces)
-   Hover (for HLSL variables, structs, enums, classes, and interfaces)
-   Document symbols (for HLSL variables, structs, enums, classes, and interfaces)
-   Go to definition (for HLSL variables, structs, enums, classes, and interfaces)
-   Go to declaration (for HLSL variables, structs, enums, classes, and interfaces)
-   Go to implementation (for HLSL structs, enums, classes, and interfaces)
-   Go to type definition (for HLSL variables)

### Improved

-   Updated packages

### Fixed

-   Preventing duplicated items in code completion
-   Fixing a formatting bug where line continuation characters caused formatting inside defines

## [1.5.0] - 2024.04.09.

### Added

-   Diagnostics (only on save at the moment)
-   Code formatting (whole document, range, ranges)
-   Includes work with go to declaration/definition/implementation

### Fixed

-   Fixing an error where certain modifiers' range was used instead of the variable's range
-   Updated packages

## [1.3.0] - 2024.03.14.

### Added

-   Code completion (for DSHL variables, shaders, and block statements)
-   Document highlights (for DSHL variables, functions, shaders, and block statements)
-   Hover (for DSHL variables, functions, shaders, and block statements)
-   Document symbols (for DSHL variables, shaders, and block statements)
-   Signature help (for DSHL functions)
-   Go to definition (for DSHL variables, functions, shaders, and block statements)
-   Go to declaration (for DSHL variables, functions, shaders, and block statements)
-   Go to implementation (for DSHL functions, shaders, and block statements)
-   Adding folding ranges based on blocks

### Improved

-   Better type informations in code completion
-   Updated packages
-   Various optimizations

### Fixed

-   Fixing a bug where closing and reopening a file prevented to update the file analyzation
-   Fixing preprocessor directives in one liner hlsl blocks in syntax highlight
-   Fixing macros before loops and ifs in syntax highlight
-   Fixing syntax highlight when #defines contain ##
-   Adding @sampler to the HLSL syntax highlight
-   Using the cleaned content of DSHL macros for expansion instead of the original to get rid of comments
-   Fixing a bug in HLSL macro expansion, where positions were wrong positions were computed

## [1.2.0] - 2024.02.15.

### Added

-   Code completion (for HLSL defines, include statements, DSHL macro parameters)
-   Document highlights (for HLSL defines, DSHL macro parameters)
-   Hover (for HLSL defines)
-   Document symbols (for HLSL defines)
-   Go to definition (for HLSL defines, DSHL macro parameters)
-   Go to declaration (for HLSL defines, DSHL macro parameters)
-   Go to implementation (for HLSL defines)

### Improved

-   Various optimizations

### Fixed

-   Providing HLSL code completion instead of DSHL code completion in .hlsli files
-   Adding ##assert to code completion and syntax highlight
-   Adding the missing DSHL modifiers, properties, and functions to the code completion and the syntax highlight, removing unused operators from the syntax highlight
-   Fixing a bug if there are more DSHL macro arguments than macro parameters
-   Fixing a bug when a DSHL macro appeared multiple times in code completion
-   Preventing unnecessary analyzations, when file is not changed, just opened in the IDE

## [1.1.0] - 2024.01.16.

### Added

- Code completion (for built-on items, and DSHL macros)
- Signature help (for DSHL macros)
- Document highlights (for DSHL macros)
- Hover (for DSHL macros)
- Document symbols (for DSHL macros)
- Go to definition (for DSHL macros)
- Go to declaration (for DSHL macros)
- Go to implementation (for DSHL macros)

### Improved

- HLSL snippets are only provided inside HLSL blocks
- DSHL snippets are only provided outside HLSL blocks

### Fixed

- Added missing functions, types and semantics, mostly related to ray-tracing functionality to HLSL syntax highlight
- Added missing modifiers (optional, global, register) to DSHL syntax highlight
- Added missing ##assert to HLSL syntax highlight
- Removed unavailable operators from DSHL syntax highlight
- Removed assembly-only registers from HLSL syntax highlight
- Removed the bad indentation after if statements
- Fixed the misspelled packoffset in HLSL syntax highlight

## [1.0.0] - 2023.12.11.

### Added

- Syntax highlight
- Comment toggling
- Bracket matching
- Auto closing pairs
- Indentation
- File icons
