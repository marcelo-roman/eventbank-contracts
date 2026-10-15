namespace EventBank.Contracts;

public sealed record AccountOpened(Guid AccountId, Guid OwnerId, string Holder, string Currency, string Number);

public sealed record AccountClosed(Guid AccountId);

public sealed record AccountDebited(Guid TransferId, Guid AccountId, decimal Amount);

public sealed record AccountDebitDeclined(Guid TransferId, Guid AccountId, string Reason);

public sealed record AccountCredited(Guid TransferId, Guid AccountId, decimal Amount);

public sealed record AccountCreditDeclined(Guid TransferId, Guid AccountId, string Reason);

public sealed record AccountRefunded(Guid TransferId, Guid AccountId, decimal Amount);

public sealed record AccountCharged(Guid ChargeId, Guid AccountId, decimal Amount);

public sealed record AccountChargeDeclined(Guid ChargeId, Guid AccountId, string Reason);
