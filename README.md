# Developer424Changes
I refactored the bank project with .Net5.
1. Divide the solution into three parts, Bank.WebApi, Bank.Core and Bank.Infrastructure
2. Use EntityFramework to persist entities.
3. Use dependency injection to layer business logic.
4. EntityFramework Repository is used for data reading and writing.
5. Interface design is used to reduce program coupling.
6. In-memory database is enabled for easy debugging.
7. A small amount of modification was made to the business logic, adding a transfer-in account and a transfer-out account for Transacation.
8. Object-oriented design for the entity.

future improvements
Due to time constraints, no more changes could be made.
1. The parameter model and response data model should be passed for Api design.
2. The logic of bank transfer should be made more reasonable.
3. Complete notes should be added.