// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.Extensions.Logging;
using Modules.Customers.Domain.Events;
using Modules.Customers.Domain.Interfaces;
using Modules.Customers.Application.EventHandlers;

namespace Modules.Customers.Application.Services
{
    public class ComplaintDomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly ILogger<ComplaintDomainEventDispatcher> _logger;
        private readonly ComplaintSubmittedEventHandler _submittedHandler;
        private readonly ComplaintStatusChangedEventHandler _statusChangedHandler;
        private readonly ComplaintAssignedEventHandler _assignedHandler;
        private readonly ComplaintCancelledEventHandler _cancelledHandler;
        private readonly ComplaintReopenedEventHandler _reopenedHandler;
        private readonly ComplaintClosedEventHandler _closedHandler;
        private readonly ComplaintAcknowledgedEventHandler _acknowledgedHandler;
        private readonly ComplaintDispatchedEventHandler _dispatchedHandler;

        public ComplaintDomainEventDispatcher(
            ILogger<ComplaintDomainEventDispatcher> logger,
            ComplaintSubmittedEventHandler submittedHandler,
            ComplaintStatusChangedEventHandler statusChangedHandler,
            ComplaintAssignedEventHandler assignedHandler,
            ComplaintCancelledEventHandler cancelledHandler,
            ComplaintReopenedEventHandler reopenedHandler,
            ComplaintClosedEventHandler closedHandler,
            ComplaintAcknowledgedEventHandler acknowledgedHandler,
            ComplaintDispatchedEventHandler dispatchedHandler)
        {
            _logger = logger;
            _submittedHandler = submittedHandler;
            _statusChangedHandler = statusChangedHandler;
            _assignedHandler = assignedHandler;
            _cancelledHandler = cancelledHandler;
            _reopenedHandler = reopenedHandler;
            _closedHandler = closedHandler;
            _acknowledgedHandler = acknowledgedHandler;
            _dispatchedHandler = dispatchedHandler;
        }

        public async Task DispatchEventsAsync(IEnumerable<ComplaintDomainEvent> domainEvents)
        {
            foreach (var domainEvent in domainEvents)
            {
                try
                {
                    switch (domainEvent)
                    {
                        case ComplaintSubmittedEvent submittedEvent:
                            await _submittedHandler.HandleAsync(submittedEvent);
                            break;
                        case ComplaintStatusChangedEvent statusChangedEvent:
                            await _statusChangedHandler.HandleAsync(statusChangedEvent);
                            break;
                        case ComplaintAssignedEvent assignedEvent:
                            await _assignedHandler.HandleAsync(assignedEvent);
                            break;
                        case ComplaintCancelledEvent cancelledEvent:
                            await _cancelledHandler.HandleAsync(cancelledEvent);
                            break;
                        case ComplaintReopenedEvent reopenedEvent:
                            await _reopenedHandler.HandleAsync(reopenedEvent);
                            break;
                        case ComplaintClosedEvent closedEvent:
                            await _closedHandler.HandleAsync(closedEvent);
                            break;
                        case ComplaintAcknowledgedEvent acknowledgedEvent:
                            await _acknowledgedHandler.HandleAsync(acknowledgedEvent);
                            break;
                        case ComplaintDispatchedEvent dispatchedEvent:
                            await _dispatchedHandler.HandleAsync(dispatchedEvent);
                            break;
                        default:
                            _logger.LogWarning("Unknown domain event type: {EventType}", domainEvent.GetType().Name);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error handling domain event {EventType} for complaint {ComplaintNumber}",
                        domainEvent.GetType().Name, domainEvent.ComplaintNumber);
                    throw;
                }
            }
        }
    }
}