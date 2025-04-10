using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Modules.Estates.Domain.Entities.Registration;
using Modules.Estates.Domain.Events;
using Modules.Estates.Domain.Events.Customer;

namespace Modules.Estates.Application.Services
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DomainEventDispatcher> _logger;

        public DomainEventDispatcher(IUnitOfWork unitOfWork, ILogger<DomainEventDispatcher> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public void Dispatch(DomainEvent domainEvent)
        {
            if (domainEvent is CustomerCreatedEvent customerCreated)
            {
                HandleCustomerCreatedEvent(customerCreated);
            }
            // Add handlers for other event types
        }

        Task IDomainEventDispatcher.Dispatch(DomainEvent domainEvent)
        {
            throw new NotImplementedException();
        }

        private void HandleCustomerCreatedEvent(CustomerCreatedEvent @event)
        {
            try
            {
                // Log the event
                _logger.LogInformation($"New {@event.CustomerType} customer created: {@event.CustomerCode}");

                // Create audit record
                // var audit = new CustomerAudit
                // {
                //     CustomerMasterId = @event.CustomerMasterId,
                //     Action = "Created",
                //     CustomerType = @event.CustomerType,
                //     PerformedBy = @event.CreatedBy,
                //     PerformedOn = @event.OccurredOn
                // };

                // await _unitOfWork.CustomerAuditRepository.AddAsync(audit);
                // await _unitOfWork.SaveChangesAsync();

                // Additional operations (e.g., sending notifications)
                // await _notificationService.SendCustomerCreatedNotification(@event);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error handling customer creation event for {@event.CustomerCode}");
                throw;
            }
        }
    }
}
