namespace EventBank.Contracts;

public sealed record CustomerRegistered(Guid CustomerId, string FullName, string Email);

public sealed record CustomerApproved(Guid CustomerId, string FullName, string Email, string Cpf);

public sealed record CustomerRejected(Guid CustomerId, string FullName, string Email, string Reason);
