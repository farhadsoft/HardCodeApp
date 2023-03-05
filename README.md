
# ASP.NET Core Web API for managing product categories and items

This project is an ASP.NET Core Web API that enables users to manage product categories and items. It provides the following pages:

1.  Product categories page: This page displays a list of existing categories and allows the user to add or delete a category. When adding a category, the user can also add additional fields for the items in that category, such as color, weight, size, and so on.
    
2.  Create item page: This page allows the user to fill in general information about an item (photo, name, description, price, category) and specify values for any additional fields that were created for the selected category.
    
3.  View item list page: This page displays a list of items with filters for categories and additional fields.
    
4.  View selected item from item list page: This page allows the user to view details about a selected item from the item list page.
    

The project has two endpoints for saving and retrieving items. The main goal is to test the approach to designing the mechanism for "dynamic fields" that are created in the category and should be filled in and returned in the item.

## Prerequisites

-   .NET Core 3.1 or later
-   Visual Studio or Visual Studio Code

## Getting Started

1.  Clone the repository
2.  Open the project in Visual Studio or Visual Studio Code
3.  Run the project

## Authors

-   [Farhad Mammadov](https://farhad.su)

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).
