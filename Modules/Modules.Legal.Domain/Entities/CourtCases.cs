// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/CourtCases.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/09/2025 9:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Domain.Entities.Setups;
using System.Threading.Tasks;

namespace Modules.Legal.Domain.Entities
{
    //public class CourtCase //: Entity<CourtCaseId>, IAggregateRoot
    //{
    //    // Identity
    //    public string CaseNumber { get; private set; }

    //    // Core Case Information
    //    public int CaseTypeId { get; private set; }
    //    public string PropertyNumber { get; private set; }
    //    public string CustomerCode { get; private set; }
    //    public string CaseTitle { get; private set; }
    //    public int CourtTypeId { get; private set; }
    //    public int CourtTypeDivisionId { get; private set; }
    //    public DateTime DateFiled { get; private set; }
    //    public string ReasonsCaseStarted { get; private set; }

    //    // Documents
    //    private readonly List<CaseDocument> _documents = new();
    //    public IReadOnlyList<CaseDocument> Documents => _documents.AsReadOnly();

    //    // Status & Tracking
    //    public CaseStatus Status { get; private set; }
    //    public DateTime? DateOfFinalRuling { get; private set; }
    //    public decimal FinancialCost { get; private set; }
    //    public bool? JudgementOnAppeal { get; private set; }
    //    public string FinalJudgementOutcome { get; private set; }
    //    public string ReasonsCaseClosed { get; private set; }
    //    public string LawyersNotes { get; private set; }

    //    // Assignment
    //    public string AssignedTo { get; private set; }
    //    public DateTime? DateAssigned { get; private set; }
    //    public string AssignedBy { get; private set; }

    //    // Reopening
    //    public DateTime? ReOpenDate { get; private set; }
    //    public string ReasonsForReopening { get; private set; }
    //    public string ReopenedBy { get; private set; }

    //    // Private constructor for EF Core
    //    private CourtCase() { }

    //    // Factory method for creating new case
    //    public static CourtCase OpenCase(
    //        CaseNumber caseNumber,
    //        CaseTypeId caseTypeId,
    //        string propertyNumber,
    //        string customerCode,
    //        string caseTitle,
    //        CourtTypeId courtTypeId,
    //        CourtTypeDivisionId courtTypeDivisionId,
    //        DateTime dateFiled,
    //        string reasonsCaseStarted,
    //        string openedBy)
    //    {
    //        return new CourtCase
    //        {
    //            CaseNumber = caseNumber,
    //            CaseTypeId = caseTypeId,
    //            PropertyNumber = propertyNumber,
    //            CustomerCode = customerCode,
    //            CaseTitle = caseTitle,
    //            CourtTypeId = courtTypeId,
    //            CourtTypeDivisionId = courtTypeDivisionId,
    //            DateFiled = dateFiled,
    //            ReasonsCaseStarted = reasonsCaseStarted,
    //            Status = CaseStatus.Open,
    //            AssignedBy = openedBy,
    //            DateAssigned = DateTime.UtcNow
    //        };
    //    }

    //    // Domain Methods
    //    public void AssignCase(string assignedTo, string assignedBy)
    //    {
    //        if (Status != CaseStatus.Open)
    //            throw new DomainException("Cannot assign a case that is not open");

    //        AssignedTo = assignedTo;
    //        AssignedBy = assignedBy;
    //        DateAssigned = DateTime.UtcNow;

    //        AddDomainEvent(new CaseAssignedEvent(Id, assignedTo, assignedBy));
    //    }

    //    public void ApproveCase(string approvedBy, string lawyersNotes = null)
    //    {
    //        if (Status != CaseStatus.Open)
    //            throw new DomainException("Only open cases can be approved");

    //        Status = CaseStatus.Approved;
    //        LawyersNotes = lawyersNotes;

    //        AddDomainEvent(new CaseApprovedEvent(Id, approvedBy));
    //    }

    //    public void CloseCase(
    //        DateTime dateOfFinalRuling,
    //        decimal financialCost,
    //        bool? judgementOnAppeal,
    //        string finalJudgementOutcome,
    //    string reasonsCaseClosed,
    //        string closedBy)
    //    {
    //        if (Status != CaseStatus.Approved && Status != CaseStatus.Open)
    //            throw new DomainException("Only approved or open cases can be closed");

    //        Status = CaseStatus.Closed;
    //        DateOfFinalRuling = dateOfFinalRuling;
    //        FinancialCost = financialCost;
    //        JudgementOnAppeal = judgementOnAppeal;
    //        FinalJudgementOutcome = finalJudgementOutcome;
    //        ReasonsCaseClosed = reasonsCaseClosed;

    //        AddDomainEvent(new CaseClosedEvent(Id, closedBy));
    //    }

    //    public void ReopenCase(
    //        string reasonsForReopening,
    //    string reopenedBy,
    //        string lawyersNotes = null)
    //    {
    //        if (Status != CaseStatus.Closed)
    //            throw new DomainException("Only closed cases can be reopened");

    //        Status = CaseStatus.Reopened;
    //        ReOpenDate = DateTime.UtcNow;
    //        ReasonsForReopening = reasonsForReopening;
    //        ReopenedBy = reopenedBy;
    //        LawyersNotes = lawyersNotes;

    //        AddDomainEvent(new CaseReopenedEvent(Id, reopenedBy));
    //    }

    //    public void EditCase(
    //        string caseTitle = null,
    //        string propertyNumber = null,
    //        string customerCode = null,
    //        string reasonsCaseStarted = null,
    //        string lawyersNotes = null)
    //    {
    //        if (Status == CaseStatus.Closed)
    //            throw new DomainException("Cannot edit a closed case");

    //        if (!string.IsNullOrEmpty(caseTitle))
    //            CaseTitle = caseTitle;

    //        if (!string.IsNullOrEmpty(propertyNumber))
    //            PropertyNumber = propertyNumber;

    //        if (!string.IsNullOrEmpty(customerCode))
    //            CustomerCode = customerCode;

    //        if (!string.IsNullOrEmpty(reasonsCaseStarted))
    //            ReasonsCaseStarted = reasonsCaseStarted;

    //        if (!string.IsNullOrEmpty(lawyersNotes))
    //            LawyersNotes = lawyersNotes;

    //        AddDomainEvent(new CaseEditedEvent(Id));
    //    }

    //    public void AddDocument(string documentName, string documentPath, string addedBy)
    //    {
    //        var document = CaseDocument.Create(documentName, documentPath, addedBy);
    //        _documents.Add(document);

    //        AddDomainEvent(new DocumentAddedEvent(Id, document.Id));
    //    }

    //    public void RemoveDocument(CaseDocumentId documentId)
    //    {
    //        var document = _documents.FirstOrDefault(d => d.Id == documentId);
    //        if (document != null)
    //        {
    //            _documents.Remove(document);
    //            AddDomainEvent(new DocumentRemovedEvent(Id, documentId));
    //        }
    //    }
    //}
}

