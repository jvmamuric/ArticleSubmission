# Centralized Package Management

This directory contains centralized configuration for managing NuGet package versions across the solution.

## Architecture

- **Directory.packages.props** - Located at the solution root `src/`, defines all package versions in one place
- **Directory.Build.props** - Located at the solution root `src/`, automatically imported by all projects
- **props/** - Contains helper property files (currently empty but reserved for future configurations)

## How It Works

The .NET SDK automatically discovers and imports:

1. `Directory.packages.props` - Defines `<PackageVersion>` items for all third-party dependencies
2. `Directory.Build.props` - General build properties inherited by all projects

Projects no longer specify versions in their `*.csproj` files. Instead, they reference packages by name only:

```xml
<ItemGroup>
  <PackageReference Include="MediatR" />
</ItemGroup>
```

The version is automatically resolved from `Directory.packages.props`.

## Benefits

✅ Single point of dependency version management
✅ Consistent versions across all projects
✅ Easier to update packages (change once, applies everywhere)
✅ Reduced duplication in project files
✅ Better collaboration (fewer merge conflicts)

## Adding New Packages

1. Add a new `<PackageVersion>` entry to `Directory.packages.props`
2. Reference it by name in project files using `<PackageReference Include="PackageName" />`
3. Run `dotnet restore` or `dotnet build`

## Current Packages

See [../Directory.packages.props](../Directory.packages.props) for the complete list of managed packages.
