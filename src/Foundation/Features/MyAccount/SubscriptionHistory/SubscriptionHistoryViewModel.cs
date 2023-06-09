using Mediachase.Commerce.Orders;

namespace Foundation.Features.MyAccount.SubscriptionHistory
{
    /// <summary>
    /// Model for list all payment plans
    /// </summary>
    public class SubscriptionHistoryViewModel : ContentViewModel<SubscriptionHistoryPage>
    {
        public SubscriptionHistoryViewModel(SubscriptionHistoryPage currentPage) : base(currentPage)
        {
        }

        public List<PaymentPlan> PaymentPlans { get; set; }
        public string PaymentPlanDetailsPageUrl { get; set; }
    }
}