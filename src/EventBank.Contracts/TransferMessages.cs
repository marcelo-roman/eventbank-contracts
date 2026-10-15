namespace EventBank.Contracts;

public sealed record DebitAccount(Guid TransferId, Guid AccountId, decimal Amount, string Currency);

public sealed record CreditAccount(Guid TransferId, Guid AccountId, decimal Amount, string Currency);

public sealed record RefundAccount(Guid TransferId, Guid AccountId);

public sealed record TransferCompleted(
    Guid TransferId,
    Guid SourceAccountId,
    Guid DestinationAccountId,
    decimal Amount,
    string Currency);
