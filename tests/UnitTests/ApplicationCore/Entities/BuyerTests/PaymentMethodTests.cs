using Microsoft.eShopWeb.ApplicationCore.Entities.BuyerAggregate;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Entities.BuyerTests;

public class PaymentMethodTests
{
    [Fact]
    public void CreatePaymentMethodWithCreditCard()
    {
        var paymentMethod = new PaymentMethod("My Credit Card", "card_123", "1234", CardType.Credit);
        
        Assert.Equal("My Credit Card", paymentMethod.Alias);
        Assert.Equal("card_123", paymentMethod.CardId);
        Assert.Equal("1234", paymentMethod.Last4);
        Assert.Equal(CardType.Credit, paymentMethod.CardType);
    }

    [Fact]
    public void CreatePaymentMethodWithDebitCard()
    {
        var paymentMethod = new PaymentMethod("My Debit Card", "card_456", "5678", CardType.Debit);
        
        Assert.Equal("My Debit Card", paymentMethod.Alias);
        Assert.Equal("card_456", paymentMethod.CardId);
        Assert.Equal("5678", paymentMethod.Last4);
        Assert.Equal(CardType.Debit, paymentMethod.CardType);
    }

    [Fact]
    public void CreatePaymentMethodDefaultsToCreditCard()
    {
        var paymentMethod = new PaymentMethod("Default Card", "card_789", "9012");
        
        Assert.Equal(CardType.Credit, paymentMethod.CardType);
    }
}
