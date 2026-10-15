namespace EventBank.Contracts;

public sealed record ChargeAccount(Guid ChargeId, Guid AccountId, decimal Amount, string Currency, string Description);

public sealed record CardPurchaseCaptured(
    Guid PurchaseId,
    Guid CardId,
    Guid AccountId,
    string Merchant,
    decimal Amount,
    string Currency);

public sealed record CardPurchaseDeclined(
    Guid PurchaseId,
    Guid CardId,
    Guid AccountId,
    string Merchant,
    decimal Amount,
    string Currency,
    string Reason);
