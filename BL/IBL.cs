namespace BL;
public interface IBL
{
     List<Customer> GetAllCustomers();
    List<Storefront> GetAllStorefronts();
    List<Product> GetAllProducts();
 //   List<Order> GetAllOrder();
    List<Orders> GetAllOrders();
    List<Inventory> GetAllInventories();
    List<LineItem> GetAllLineItems();

    void AddCustomer(Customer CustomerToAdd);
    void AddStorefront(Storefront StorefrontToAdd);
    void AddOrders(Orders OrdersToAdd);
    void AddProduct(int StoreIndex, Product ProductToAdd);
//    void AddOrder(int OrderbyIndex, Order OrderToAdd);
    void AddInventory(int StorefrontIndex, Inventory InventoryToAdd);
    void ChangeInventory(int InventoryIndex, int qtyToC);
    void RemoveOrder(int IdToRem);
    void AddLineItem(int OrderIndex, LineItem LineItemToAdd);
}