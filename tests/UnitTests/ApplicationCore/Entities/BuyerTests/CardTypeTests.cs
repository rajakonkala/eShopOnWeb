using Microsoft.eShopWeb.ApplicationCore.Entities.BuyerAggregate;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Entities.BuyerTests;

public class CardTypeTests
{
    [Fact]
    public void CardTypeHasCreditValue()
    {
        var cardType = CardType.Credit;
        Assert.Equal(1, (int)cardType);
    }

    [Fact]
    public void CardTypeHasDebitValue()
    {
        var cardType = CardType.Debit;
        Assert.Equal(2, (int)cardType);
    }

    [Fact]
    public void CanCompareCardTypes()
    {
        var credit = CardType.Credit;
        var debit = CardType.Debit;
        
        Assert.NotEqual(credit, debit);
        Assert.Equal(CardType.Credit, credit);
        Assert.Equal(CardType.Debit, debit);
    }
}
