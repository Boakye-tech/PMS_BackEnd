// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Stock.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 11:05 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class Stock : AuditableEntity
{
    [Key]
    [Required]
    public int StockId { get; private set; }

    [Required]
    [StringLength(20)]
    public string? StockNumber { get; private set; }

    [Required]
    [StringLength(20)]
    public string? ItemCode { get; private set; }

    [Required]
    public int Quantity { get; private set; }

    [Required]
    public decimal UnitPrice { get; private set; }

    [Required]
    public int SupplierId { get; private set; }

    [Required]
    public DateTime TransactionDate { get; private set; }

    [Required]
    [StringLength(20)]
    public string? TransactionType { get; private set; }

    [StringLength(50)]
    public string? ReceiptNoteNumber { get; private set; }

    public int? QuantityReceived { get; private set; }

    [StringLength(50)]
    public string? IssueNoteNumber { get; private set; }

    public int? QuantityIssues { get; private set; }

    [StringLength(500)]
    public string? Remarks { get; private set; }

    [Required]
    public int LowStockThreshold { get; private set; }

    public DateTime? LastRestockedDate { get; private set; }

    // Navigation properties
    public virtual Items? Items { get; private set; }
    public virtual Suppliers? Suppliers { get; private set; }


    public Stock()
    {
    }

    public Stock(int stockId, string? stockNumber, string? itemCode, int quantity, decimal unitPrice,
                int supplierId, DateTime transactionDate, string? transactionType, string? receiptNoteNumber,
                int? quantityReceived, string? issueNoteNumber, int? quantityIssues, string? remarks,
                int lowStockThreshold, DateTime? lastRestockedDate)
    {
        StockId = stockId;
        StockNumber = stockNumber;
        ItemCode = itemCode;
        Quantity = quantity;
        UnitPrice = unitPrice;
        SupplierId = supplierId;
        TransactionDate = transactionDate;
        TransactionType = transactionType;
        ReceiptNoteNumber = receiptNoteNumber;
        QuantityReceived = quantityReceived;
        IssueNoteNumber = issueNoteNumber;
        QuantityIssues = quantityIssues;
        Remarks = remarks;
        LowStockThreshold = lowStockThreshold;
        LastRestockedDate = lastRestockedDate;
    }

    public static Stock Create(int stockId, string? stockNumber, string? itemCode, int quantity, decimal unitPrice,
                             int supplierId, DateTime transactionDate, string? transactionType, string? receiptNoteNumber,
                             int? quantityReceived, string? issueNoteNumber, int? quantityIssues, string? remarks,
                             int lowStockThreshold, DateTime? lastRestockedDate)
    {
        Validate(stockId, stockNumber, itemCode, quantity, unitPrice, supplierId, transactionDate, transactionType, lowStockThreshold);
        return new Stock(stockId, stockNumber, itemCode, quantity, unitPrice, supplierId, transactionDate,
                        transactionType, receiptNoteNumber, quantityReceived, issueNoteNumber, quantityIssues,
                        remarks, lowStockThreshold, lastRestockedDate);
    }

    public void Update(int stockId, string? stockNumber, string? itemCode, int quantity, decimal unitPrice,
                      int supplierId, DateTime transactionDate, string? transactionType, string? receiptNoteNumber,
                      int? quantityReceived, string? issueNoteNumber, int? quantityIssues, string? remarks,
                      int lowStockThreshold, DateTime? lastRestockedDate)
    {
        Validate(stockId, stockNumber, itemCode, quantity, unitPrice, supplierId, transactionDate, transactionType, lowStockThreshold);

        StockId = stockId;
        StockNumber = stockNumber;
        ItemCode = itemCode;
        Quantity = quantity;
        UnitPrice = unitPrice;
        SupplierId = supplierId;
        TransactionDate = transactionDate;
        TransactionType = transactionType;
        ReceiptNoteNumber = receiptNoteNumber;
        QuantityReceived = quantityReceived;
        IssueNoteNumber = issueNoteNumber;
        QuantityIssues = quantityIssues;
        Remarks = remarks;
        LowStockThreshold = lowStockThreshold;
        LastRestockedDate = lastRestockedDate;
    }

    private static void Validate(int stockId, string? stockNumber, string? itemCode, int quantity, decimal unitPrice,
                                int supplierId, DateTime transactionDate, string? transactionType, int lowStockThreshold)
    {
        if (stockId < 0 || string.IsNullOrWhiteSpace(stockNumber) || string.IsNullOrWhiteSpace(itemCode) ||
            quantity < 0 || unitPrice < 0 || supplierId < 0 || string.IsNullOrWhiteSpace(transactionType) ||
            lowStockThreshold < 0)
        {
            throw new ArgumentException("Stock data is invalid.");
        }

        if (stockId < 0)
            throw new ArgumentException("Stock ID must be greater than zero.");

        if (string.IsNullOrWhiteSpace(stockNumber) || stockNumber.Length > 20)
            throw new ArgumentException("Stock Number cannot be empty or exceed 20 characters.");

        if (string.IsNullOrWhiteSpace(itemCode) || itemCode.Length > 20)
            throw new ArgumentException("Item Code cannot be empty or exceed 20 characters.");

        if (quantity < 0)
            throw new ArgumentException("Quantity must be greater than or equal to zero.");

        if (unitPrice < 0)
            throw new ArgumentException("Unit Price must be greater than or equal to zero.");

        if (supplierId < 0)
            throw new ArgumentException("Supplier ID must be greater than zero.");

        if (transactionDate == default(DateTime))
            throw new ArgumentException("Transaction Date must be a valid date.");

        if (string.IsNullOrWhiteSpace(transactionType) || transactionType.Length > 20)
            throw new ArgumentException("Transaction Type cannot be empty or exceed 20 characters.");

        if (lowStockThreshold < 0)
            throw new ArgumentException("Low Stock Threshold must be greater than or equal to zero.");
    }
}