// See https://aka.ms/new-console-template for more information


void basis_1()
{

    int employeeLevel = 100;
    string employeeName = "John Smith";

    string title = "";

    switch (employeeLevel)
    {
        case 100:
        case 200:
            title = "Senior Associate";
            break;
        case 300:
            title = "Manager";
            break;
        case 400:
            title = "Senior Manager";
            break;
        default:
            title = "Associate";
            break;
    }

    Console.WriteLine($"{employeeName}, {title}");

}

void basis_2()
{
    // SKU = Stock Keeping Unit. 
    // SKU value format: <product #>-<2-letter color code>-<size code>
    string sku = "01-MN-L";

    string[] product = sku.Split('-');

    string type = "";
    string color = "";
    string size = "";

    type = product[0] switch
    {
        "01" => "Sweat shirt",
        "02" => "T-Shirt",
        "03" => "Sweat pants",
        _ => "Other",
    };

    color = product[1] switch
    {
        "BL" => "Black",
        "MN" => "Maroon",
        _ => "White",
    };

    size = product[2] switch
    {
        "S" => "Small",
        "M" => "Medium",
        "L" => "Large",
        _ => "One Size Fits All",
    };

    Console.WriteLine($"Product: {size} - {color} - {type}");
}

basis_2();
