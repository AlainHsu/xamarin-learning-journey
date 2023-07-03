# Create multi-page Xamarin.Forms apps with stack and tab navigation

|           | **When to use**                                              | **How to implement**                                         |
| :-------- | :----------------------------------------------------------- | :----------------------------------------------------------- |
| **Stack** | When your content has a linear progression of pages from general to specific. | `NavigationPage` and its `PushAsync` and `PopAsync` methods. |
| **Tab**   | When you have a small number of top-level pages that have equal importance to the user. You want it to be easy to switch among them. | `TabbedPage` and its `Children` property.                    |
| **Modal** | When a page requires an affirmative action from the user before dismissal. | The `PushModalAsync` and `PopModalAsync` methods, available from the `Navigation` property in all page types. |

Xamarin.Forms recommends using only three to four tabs. If you include more tabs, you're not guaranteed to have enough space to show all of the tabs on all devices. The operating systems supported by Xamarin.Forms do allow for an overflow area. This area provides additional UI to access tabs that don't fit on screen. However, navigating to these overflow tabs requires additional steps by the user. These sections are less discoverable.

If you need more than four tabs, consider using another navigation pattern, like master-detail or drawer navigation.
