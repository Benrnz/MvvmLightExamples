# MvvmLightExamples
Some examples for Windows 10 Universal App development using MvvmLight

## Conventions
Some guiding rules I use in implementing the MVVM model in UWP (and WPF).

1. ViewModels should not contain a reference to any views (pages).
2. Always prefer XAML over code behind. 99% of all problems can be solved in XAML, and code behind creates problems of its own.
3. Code behind for views (pages) must be as minimalistic as possible. 99% of ViewModels should only contain a reference to their ViewModel and a GoBack event handler.
4. Prefer x:Bind over Binding.  Reach for Binding when x:Bind does not offer the required functionality. (x:Bind is far faster at runtime and offers excellent strong typing which provides design time error detection).
5. Navigation to a view must only occur inside a ViewModel.  A ViewModel must only navigate to its own view.
6. A ViewModel should only have one matching View, but remember #1.
7. Avoid creating your own events inside ViewModels, rather prefer a Message Hub / PubSub pattern. (See Mvvm Light's IMessenger).
8. A ViewModel should be fully unit testable, but a View does not need to be unit tested because it contains no code.
9. Prefer commands over event handler methods in code behind. This allows for direct binding from the XAML to the ViewModel with no special code behind. Commands can potentially be in a class of their own.
10. Always use Styles, avoid inline styles for XAML elements. Keep XAML DRY. (non-DRY XAML doesn't refactor well).

