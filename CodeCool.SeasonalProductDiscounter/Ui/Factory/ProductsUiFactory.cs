﻿using CodeCool.SeasonalProductDiscounter.Service.Products.Browser;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui.Factory;

public class ProductsUiFactory : UiFactoryBase
{
    private readonly ProductBrowser _productBrowser;

    public ProductsUiFactory(IAuthenticationService authenticationService, ProductBrowser productBrowser) : base(authenticationService)
    {
        _productBrowser = productBrowser;
    }


    public override string UiName => "Products";

    public override UiBase Create()
    {
        return new ProductsUi(AuthenticationService, _productBrowser, UiName);
    }
}
