namespace KlebertsWebshop.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductDTO>>> GetCartProducts(List<CartItem> cartItems);
}
