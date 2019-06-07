using System;

namespace Putn
{
    public class ShoppingController
    {
        private readonly IShoppingService shoppingService;

        public ShoppingController(IShoppingService shoppingService)
        {
            this.shoppingService = shoppingService;
        }

        public void Buy(BuyRequest request)
        {
            this.shoppingService.Buy(request.ItemIDs, ContextualMemberID, request.PromoCode, DateTime.Now);
        }

        private int ContextualMemberID = 20190620;
    }
}