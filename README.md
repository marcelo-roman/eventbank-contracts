# EventBank contracts

The messages the [EventBank](https://github.com/marcelo-roman/eventbank-platform) microservices exchange over RabbitMQ, shipped as the `EventBank.Contracts` NuGet package. Each message is published to the `eventbank` topic exchange with its type name as the routing key.

| Message | Published by | Consumed by | Meaning |
| --- | --- | --- | --- |
| `CustomerRegistered` | Customers | Notifications | Someone applied to become a customer |
| `CustomerApproved` | Customers | Accounts, Transfers, Notifications | The application was approved; Accounts opens the checking account |
| `CustomerRejected` | Customers | Notifications | The application was rejected, with a reason |
| `AccountOpened` | Accounts | Transfers, Cards, Notifications | A new account exists, with its owner and number |
| `AccountClosed` | Accounts | Transfers, Cards | The account no longer accepts transfers or card purchases |
| `DebitAccount` | Transfers | Accounts | Take the amount from the source account for this transfer |
| `AccountDebited` / `AccountDebitDeclined` | Accounts | Transfers | The debit happened, or was declined with a reason |
| `CreditAccount` | Transfers | Accounts | Give the amount to the destination account |
| `AccountCredited` / `AccountCreditDeclined` | Accounts | Transfers | The credit happened, or was declined with a reason |
| `RefundAccount` | Transfers | Accounts | Compensation: return a debited amount to the source |
| `AccountRefunded` | Accounts | Transfers | The refund happened; the transfer is reversed |
| `TransferCompleted` | Transfers | Notifications | Money arrived at the destination |
| `ChargeAccount` | Cards | Accounts | Charge a card purchase to the card's account |
| `AccountCharged` / `AccountChargeDeclined` | Accounts | Cards | The charge happened, or was declined with a reason |
| `CardPurchaseCaptured` / `CardPurchaseDeclined` | Cards | Notifications | The outcome of a card purchase |

Messages are records of primitives (`Guid`, `decimal`, `string`) so that no service leaks its value objects into another.

Changing a message is a breaking change for the other service: add fields instead of renaming them, and publish a new package version.

## License

[MIT](LICENSE)
