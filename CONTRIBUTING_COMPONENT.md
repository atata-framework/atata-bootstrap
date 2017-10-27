# How to Contribute a Component

## Development Prerequisites

- Visual Studio 2017 (any edition)
- [SonarLint for Visual Studio 2017](https://marketplace.visualstudio.com/items?itemName=SonarSource.SonarLintforVisualStudio2017) for code analysis.

## Fork Repository

Fork repository and open VS solution `src\Atata.Bootstrap.sln`.

## Component Development

Create class in `Atata.Bootstrap` project for a component named ``{{Component}}`1.cs`` ("1" means that component has one generic argument).
Custom triggers should be placed into `Triggers` folder.

Choose which component to inherit, e.g.:

- `EditableField<T, TOwner>` - for single-value editable controls like text box or drop-down.
- `Field<T, TOwner>` - for single-value read-only controls.
- `ItemsControl<TItem, TOwner>` - for item list controls.
- `Table<THeader, TRow, TOwner>` - for tables and grids views.
- `PopupWindow<TOwner>` - for popup/modal windows.
- `Control<TOwner>` - for other custom kinds of control.

Define required attribues on component class and implement needed properties or methods.

Be sure to keep disabled and read-only component states working.
You can override `GetIsReadOnly` and `GetIsEnabled` methods.

## Testing

- Create test page in `Atata.Bootstrap.TestApp` project named `{{Component}}.html`. Add single or multiple HTML components to the page for testing with different component options.
- Create page object class in Atata.Bootstrap.Tests project named `{{Component}}Page.cs`. Add required component properties.
- Create test fixture class in Atata.Bootstrap.Tests project named `{{Component}}Tests.cs`
- Add primary test method to fixture named `{{Component}}` for basic control testing.
- Optionally, if actual component has settings, add additional test methods to fixture named `{{Component}}_{{State}}` for specific component state testing.
- Ensure that new and existing tests are executing succesfully. 

## Code Analysis

Please use code analysis and fix produced issues.

To run code analysis: In VS top menu choose "Analyze/Run Code Analysis/On Solution".
Then verify warnings and messages in "Error List" panel.

## Pull Request

Commit and [create pull request](https://help.github.com/articles/creating-a-pull-request-from-a-fork/).