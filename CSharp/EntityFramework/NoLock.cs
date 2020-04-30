ProductsNewViewData viewData = new ProductsNewViewData();
using var t = new TransactionScope(TransactionScopeOption.Required,
    new TransactionOptions { 
        IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted 
    }));
viewData.Suppliers = northwind.Suppliers.ToList();
viewData.Categories = northwind.Categories.ToList();
 
 //http://pt.stackoverflow.com/q/185994/101
